using System;
using System.IO;
using Guna.UI2.WinForms;
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
        
        
    }
}