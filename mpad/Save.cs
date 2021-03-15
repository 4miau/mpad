using Guna.UI2.WinForms;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mpad
{
    public static class Save
    {
        public static void SaveFunc(Guna2TextBox txtMain, Form frm)
        {
            switch (Data.saved)
            {
                case false when Data.path == "":
                case false when !File.Exists(Data.path):
                    Scheduler.Save(txtMain.Text);
                    frm.Text = Data.filename + " - " + "mpad";
                    break;
                case false when File.Exists(Data.path):
                    try
                    {
                        using (StreamWriter sw = new StreamWriter(Data.path))
                        {
                            sw.Write(txtMain.Text);
                        }

                        frm.Text = Data.filename + " - " + "mpad";
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error saving the file, fix this please Miau.");
                    }

                    break;
            }
        }

        public static void SaveAsFunc(Guna2TextBox txtMain, Form frm)
        {
            Scheduler.Save(txtMain.Text);
            Data.saved = true;
            frm.Text = Data.filename + " - " + "mpad";
        }

        public static void AutoSaveEnable(ToolStripMenuItem fiAutoSave, Form frm)
        {
            bool check = File.Exists(Data.path);

            switch (check)
            {
                case true:
                    if (fiAutoSave.Checked)
                    {
                        fiAutoSave.Checked = false;
                        Data.autoSaveCheck = false;
                        break;
                    }
                    else
                    {
                        fiAutoSave.Checked = true;
                        Data.autoSaveCheck = true;
                        AutoSaveFunc(frm);
                        break;
                    }
                case false:
                    fiAutoSave.Checked = false;
                    MessageBox.Show("You need to at least save/open a file before you can use the auto-save feature.",
                        "File has not been saved", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        public static async void AutoSaveFunc(Form frm)
        {
            int totalTimer = 0;
            const int intervalTimer = 30000;

            int ctCancel = 0;

        go:
            int localTimer = getSaveTimer();

            while (File.Exists(Data.path) && getAutoSaveState())
            {
            Task1:
                await Task.Delay(intervalTimer);
                await Task.Run(() =>
                {
                    totalTimer += intervalTimer;

                    if (localTimer == getSaveTimer()) return;
                    totalTimer = 0;
                    ctCancel = 1;
                });

                if (ctCancel == 1)
                {
                    ctCancel = 0;
                    goto go;
                }

                if (File.Exists(Data.path) && getAutoSaveState() && totalTimer >= getSaveTimer())
                {
                    try
                    {
                        using (StreamWriter sw = new StreamWriter(Data.path)) sw.Write(getText());
                        frm.Text = Data.filename + " - " + "mpad";
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

        private static bool getAutoSaveState()
        {
            return Data.autoSaveCheck;
        }

        private static string getText()
        {
            return Data.content;
        }


        private static int getSaveTimer()
        {
            return Settings.impConfig.saveTimer;
        }
    }
}