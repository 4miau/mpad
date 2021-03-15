using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static mpad.FileHandler;
using static mpad.Keydowns;
using static mpad.Save;
using static mpad.Settings;
using static mpad.themeControl;
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
                       setTheme(txtMain, this);
                       break;
                   case "Dark":
                       thDark.Checked = true;
                       setTheme(txtMain, this);
                       break;
               }
           })); //Overwrites default

            TopMost = false;

            //txtMain.HorizontalScroll.Enabled = false;
            //txtMain.HorizontalScroll.Visible = false;

            //txtMain.VerticalScroll.Enabled = false;
            //txtMain.VerticalScroll.Visible = false;

            Text = Data.filename + " - " + "mpad";
        }

        private void mpadUnload(object sender, FormClosingEventArgs e)
        {
            Confirmation closeConfirm = new Confirmation
            {
                StartPosition = FormStartPosition.CenterParent,
                Type = 2
            };

            mpadJSON session = new mpadJSON
            {
                id = impConfig.id,
                theme = impConfig.theme,
                wrap = impConfig.wrap,
                font = impConfig.font,
                saveTimer = impConfig.saveTimer,
                fontSize = newZoom
            };

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
            Data.content = txtMain.Text;
            Text = "* " + Data.filename + " - " + "mpad";
        }

        private void keyDown(object sender, KeyEventArgs e)
        {
            if (save_keyDown()) SaveFunc(txtMain, this);
            if (saveAs_keyDown()) SaveAsFunc(txtMain, this);
            if (open_keyDown()) OpenFunc();
            if (new_keyDown()) newFileFunc();
            if (autoSave_keyDown()) AutoSaveEnable(fiAutoSave, this);
            if (find_keyDown())
            {
                Find f = new Find(); f.Show();
            }
            if (themeSet_keyDown()) openSetTheme();
            if (zoomIn_keyDown()) zoomIn();
            if (zoomOut_keyDown()) zoomOut();

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
            SaveAsFunc(txtMain, this);
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// AUTO-SAVE
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void fiAutoSave_Click(object sender, EventArgs e)
        {
            BeginInvoke((MethodInvoker)(() => { AutoSaveEnable(fiAutoSave, this); }));
        }

        private void ASaveTimer_Click(object sender, EventArgs e)
        {
            openSetTheme();
        }

        private void openSetTheme()
        {
            if (!fiAutoSave.Checked)
            {
                MessageBox.Show("Auto-save needs to be enabled to set a timer.", "Auto-save disabled",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            else txtMain.Text = dString;
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
        /// FONT
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void foFont_Click(object sender, EventArgs e)
        {
            Fonts changeFont = new Fonts
            {
                StartPosition = FormStartPosition.CenterParent
            };

            changeFont.ShowDialog();
            
            //after Dialog

            txtMain.Font = new Font(impConfig.font, impConfig.fontSize);
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
            zoomOut();
        }

        private void zoomOut()
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

        private void thLight_Click(object sender, EventArgs e)
        {
            if (thLight.Checked) return;
            thLight.Checked = true;
            thDark.Checked = false;
            impConfig.theme = "Light";
            setTheme(txtMain, this);
        }

        private void thDark_Click(object sender, EventArgs e)
        {
            if (thDark.Checked) return;
            thDark.Checked = true;
            thLight.Checked = false;
            impConfig.theme = "Dark";
            setTheme(txtMain, this);
        }
    }
}