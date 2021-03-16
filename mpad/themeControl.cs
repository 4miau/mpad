using Guna.UI2.WinForms;
using System.Drawing;
using System.Windows.Forms;
using static mpad.Settings;

namespace mpad
{
    public class themeControl
    {
        public static void setTheme(Guna2TextBox txtMain, Form frm)
        {
            switch (impConfig.theme)
            {
                case "Light":
                    txtMain.FillColor = Color.White;
                    txtMain.ForeColor = Color.Black;
                    txtMain.DisabledState.ForeColor = Color.Black;

                    foreach (Control c in frm.Controls)
                    {
                        switch (c)
                        {
                            case MenuStrip _:
                                c.ForeColor = Color.Black;
                                c.BackColor = Color.White;
                                break;
                            case Guna2TextBox _:
                                c.ForeColor = Color.Black;
                                c.BackColor = Color.White;
                                break;
                            case Label _:
                                c.ForeColor = Color.Black;
                                break;
                            case Form _:
                                c.BackColor = Color.White;
                                c.ForeColor = Color.Black;
                                break;
                        }
                    }

                    break;
                case "Dark":
                    txtMain.FillColor = Color.FromArgb(30, 30, 30);
                    txtMain.ForeColor = Color.White;
                    txtMain.DisabledState.ForeColor = Color.White;

                    foreach (Control c in frm.Controls)
                    {
                        switch (c)
                        {
                            case MenuStrip _:
                                c.ForeColor = Color.White;
                                c.BackColor = Color.FromArgb(45, 45, 48);
                                break;
                            case Guna2TextBox _:
                                c.ForeColor = Color.White;
                                c.BackColor = Color.FromArgb(30, 30, 30);
                                break;
                            case Label _:
                                c.ForeColor = Color.White;
                                break;
                            case Form _:
                                c.ForeColor = Color.White;
                                c.BackColor = Color.DarkGray;
                                break;
                        }
                    }
                    break;
            }
        }

        //METHOD OVERLOADING WILL DO WHEN I FIGURE APPROPRIATE METHOD
    }
}