using Guna.UI2.WinForms;
using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static mpad.Keydowns;
using static mpad.Settings;
using static mpad.FileHandler;
using static mpad.Save;
using Clipboard = System.Windows.Forms.Clipboard;
using Size = System.Drawing.Size;
// ReSharper disable MethodHasAsyncOverload

namespace mpad
{
    public partial class mpadMain : Form
    {
        private static readonly string EmergencyPath = Settings.configPath + @"\Recovered Files";

        public static int newReturn;
        public static int currentTimer = 30000; //default
        private static float newZoom = impConfig.fontSize;

        public static string Theme = "Light"; //default

        public mpadMain()
        {
            MinimumSize = new Size(300, 200);
            InitializeComponent();
        }

        public sealed override Size MinimumSize
        {
            get => base.MinimumSize;
            set => base.MinimumSize = value;
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// Form Load/Unload Events
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void mpadLoad(object sender, EventArgs e)
        {
            BeginInvoke((MethodInvoker)(() =>
           {
               currentTimer = impConfig.saveTimer;
               txtMain.WordWrap = impConfig.wrap;
               foWrap.Checked = impConfig.wrap;
               txtMain.Font = new Font(impConfig.font, impConfig.fontSize);

               switch (impConfig.theme)
               {
                   case "Light":
                       thLight.Checked = true;
                       setTheme();
                       break;
                   case "Dark":
                       thDark.Checked = true;
                       setTheme();
                       break;
               }
           })); //Overwrites default

            //TopMost = false;

            Text = Data.filename + " - " + "mpad";
        }

        private void mpadUnload(object sender, FormClosingEventArgs e)
        {
            Confirmation closeConfirm = new Confirmation
            {
                StartPosition = FormStartPosition.CenterParent,
                Type = 2
            };

            mpadJSON session = new mpadJSON { id = impConfig.id, theme = impConfig.theme, wrap = impConfig.wrap, font = impConfig.font, saveTimer = impConfig.saveTimer, fontSize = newZoom };

            switch (e.CloseReason)
            {
                case CloseReason.WindowsShutDown when !Data.saved:
                case CloseReason.None:
                case CloseReason.ApplicationExitCall:
                    SerializeConfig(session);
                    EmergencyRecovery(txtMain, EmergencyPath);
                    break;
                case CloseReason.UserClosing when Data.saved:
                    SerializeConfig(session);
                    return;
                case CloseReason.UserClosing:
                    closeConfirm.ShowDialog();

                    switch (newReturn)
                    {
                        case 1:
                            SaveFunc(txtMain, this);
                            if (!Data.saved)
                            {
                                e.Cancel = true;
                            }
                            else SerializeConfig(session);

                            newReturn = 0;
                            break;
                        case 2:
                            SerializeConfig(session);
                            e.Cancel = false;
                            break;
                        case 3:
                            e.Cancel = true;
                            newReturn = 0;
                            break;
                    }

                    break;
                case CloseReason.WindowsShutDown when Data.path != "":
                    {
                        SerializeConfig(session);
                        using (StreamWriter sw = new StreamWriter(Data.path))
                        {
                            sw.Write(txtMain.Text);
                        }
                        break;
                    }
                default:
                    _ = new Exception();
                    break;
            }
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// Events
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// Textbox Events (+ KeyDown)
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void updateContent(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMain.Text)) return;
            Data.saved = false;
            Scheduler.Update(txtMain.Text);
            Text = "* " + Data.filename + " - " + "mpad";
        }

        private void keyDown(object sender, KeyEventArgs e)
        {
            if (save_keyDown()) SaveFunc(txtMain, this);;
            if (open_keyDown()) OpenFunc();
            if (new_keyDown()) newFileFunc();
            if (autoSave_keyDown()) AutoSaveEnable();
            if (themeSet_keyDown()) openSetTheme();
            if (zoomIn_keyDown()) zoomIn();

            //sirhurt verified
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// NEW (CLEARS TEXT)
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void fiNew_Click(object sender, EventArgs e)
        {
            newFileFunc();
        }

        private void newFileFunc()
        {
            var newConfirm = new Confirmation { StartPosition = FormStartPosition.CenterParent, Type = 1 };

            if (!Data.saved)
            {
                newConfirm.ShowDialog();
                if (newReturn == 1) txtMain.Text = string.Empty;
                Text = "Untitled" + " - " + "mpad";
                Data.path = "";
            }
            else txtMain.Text = string.Empty;

            newReturn = 0;
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// NEW WINDOW
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void fiNewWindow_Click(object sender, EventArgs e)
        {
            var tab = new mpadMain();
            tab.Show();
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// OPEN FILE
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void fiOpen_Click(object sender, EventArgs e)
        {
            OpenFunc();
        }

        private void OpenFunc()
        {
            Scheduler.Open();
            if (Data.content != "") txtMain.Text = Data.content;
            Data.opened = true;
            Text = Data.filename + " - " + "mpad";
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// SAVE FILE
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void fiSave_Click(object sender, EventArgs e)
        {
            SaveFunc(txtMain, this);
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// SAVE FILE AS
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void fiSaveAs_Click(object sender, EventArgs e)
        {
            Scheduler.Save(txtMain.Text);
            Data.saved = true;
            Text = Data.filename + " - " + "mpad";
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// AUTO-SAVE
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void fiAutoSave_Click(object sender, EventArgs e)
        {
            AutoSaveEnable();
        }

        private void AutoSaveEnable()
        {
            bool check = File.Exists(Data.path);

            switch (check)
            {
                case true:
                    if (fiAutoSave.Checked)
                    {
                        fiAutoSave.Checked = false;
                        break;
                    }
                    else
                    {
                        fiAutoSave.Checked = true;
                        AutoSaveFunc();
                        break;
                    }
                case false:
                    fiAutoSave.Checked = false;
                    MessageBox.Show("You need to at least save/open before you can use the auto-save feature.",
                        "File is not saved", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private async void AutoSaveFunc()
        {
            int totalTimer = 0;
            const int intervalTimer = 30000;

            int ctCancel = 0;

        go:
            int localTimer = currentTimer;

            while (File.Exists(Data.path) && fiAutoSave.Checked)
            {
            Task1:
                await Task.Delay(intervalTimer);
                await Task.Run(() =>
                {
                    totalTimer += intervalTimer;

                    if (localTimer == currentTimer) return;
                    totalTimer = 0;
                    ctCancel = 1;
                });

                if (ctCancel == 1)
                {
                   ctCancel = 0;
                    goto go;
                }
                if (File.Exists(Data.path) && fiAutoSave.Checked && totalTimer >= currentTimer)
                {
                    try
                    {
                        using (StreamWriter sw = new StreamWriter(Data.path)) sw.Write(txtMain.Text);
                        Text = Data.filename + " - " + "mpad";
                        Data.saved = true;
                        totalTimer = 0;
                    }
                    catch
                    {
                    }
                }
                else goto Task1;
                goto go;
            }
        }

        private void ASaveTimer_Click(object sender, EventArgs e)
        {
            openSetTheme();
        }

        private void openSetTheme()
        {
            if (!fiAutoSave.Checked)
            {
                MessageBox.Show("Auto-save needs to be enabled to set a timer.", "Auto-save disabled", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SetTimer newTimer = new SetTimer { StartPosition = FormStartPosition.CenterParent };
            newTimer.ShowDialog();
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// UNDO
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void edUndo_Click(object sender, EventArgs e)
        {
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// REDO
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void edRedo_Click(object sender, EventArgs e)
        {
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// CUT
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void edCut_Click(object sender, EventArgs e)
        {
            if (txtMain.SelectedText != "") txtMain.Cut();
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// COPY
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void edCopy_Click(object sender, EventArgs e)
        {
            if (txtMain.SelectedText != "") Clipboard.SetText(txtMain.SelectedText);
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// PASTE
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void edPaste_Click(object sender, EventArgs e)
        {
            var ClipLength = Clipboard.GetText().Length;

            txtMain.Paste();
            txtMain.SelectionStart += ClipLength;
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// TIME & DATE
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void edTD_Click(object sender, EventArgs e)
        {
            var d = DateTime.Now;
            dynamic sHour = d.ToString("HH") + ":" + DateTime.Now.Minute;
            var date = d.Date;

            string dString = sHour.ToString() + " " + date.ToString("dd/MM/yyyy");

            if (txtMain.Text.Length > 0)
            {
                int startIndex = txtMain.SelectionStart;
                txtMain.Text = txtMain.Text.Insert(startIndex, dString);
                txtMain.SelectionStart = startIndex + dString.Length;
            }
            else
            {
                txtMain.Text = dString;
            }
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// WRAP
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void foWrap_Click(object sender, EventArgs e)
        {
            switch (foWrap.Checked)
            {
                case true:
                    foWrap.Checked = false;
                    impConfig.wrap = false;
                    txtMain.WordWrap = false;
                    break;
                case false:
                    foWrap.Checked = true;
                    impConfig.wrap = true;
                    txtMain.WordWrap = true;
                    break;
            }
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// SELECT ALL
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void seSelectAll_Click(object sender, EventArgs e)
        {
            if (txtMain.Text != "") txtMain.SelectAll();
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// ZOOM IN 
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void viZoomIn_Click(object sender, EventArgs e)
        {
            zoomIn();
        }

        private void zoomIn()
        {
            if (newZoom < 150) txtMain.Font = new Font(impConfig.font, newZoom += 2);
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// ZOOM OUT
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void viZoomOut_Click(object sender, EventArgs e)
        {
            if (newZoom > 2) txtMain.Font = new Font(impConfig.font, newZoom -= 2);
            
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// RESTORE ZOOM
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void viResZoom_Click(object sender, EventArgs e)
        {
            txtMain.Font = new Font(impConfig.font, impConfig.fontSize);
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// THEMES <3
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///
        private void thLight_Click(object sender, EventArgs e)
        {
            if (thLight.Checked) return;
            thLight.Checked = true;
            thDark.Checked = false;
            impConfig.theme = "Light";
            setTheme();
        }

        private void thDark_Click(object sender, EventArgs e)
        {
            if (thDark.Checked) return;
            thDark.Checked = true;
            thLight.Checked = false;
            impConfig.theme = "Dark";
            setTheme();
        }

        private void setTheme()
        {
            switch (impConfig.theme)
            {
                case "Light":
                    txtMain.FillColor = Color.White;
                    txtMain.ForeColor = Color.Black;

                    foreach (Control c in Controls)
                    {

                        switch (c)
                        {
                            case MenuStrip _:
                                c.ForeColor = Color.Black; c.BackColor = Color.White;
                                break;
                            case Guna2TextBox _:
                                c.ForeColor = Color.Black; c.BackColor = Color.White;
                                break;
                            case Label _:
                                c.ForeColor = Color.Black;
                                break;
                            case Form _:
                                c.BackColor = Color.White; c.ForeColor = Color.Black;
                                break;
                        }
                    }
                    break;
                case "Dark":
                    txtMain.FillColor = Color.FromArgb(30, 30, 30);
                    txtMain.ForeColor = Color.White;

                    foreach (Control c in Controls)
                    {
                        switch (c)
                        {
                            case MenuStrip _:
                                c.ForeColor = Color.White; c.BackColor = Color.FromArgb(45, 45, 48);
                                break;
                            case Guna2TextBox _:
                                c.ForeColor = Color.White; c.BackColor = Color.FromArgb(30, 30, 30);
                                break;
                            case Label _:
                                c.ForeColor = Color.White;
                                break;
                            case Form _:
                                c.ForeColor = Color.White; c.BackColor = Color.DarkGray;
                                break;
                        }
                    }
                    break;
            }
        }

    }
}