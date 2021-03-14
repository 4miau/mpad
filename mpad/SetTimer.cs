using Guna.UI2.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;
using static mpad.Settings;

namespace mpad
{
    public partial class SetTimer : Form
    {
        public SetTimer()
        {
            InitializeComponent();
        }

        private void SetTimer_Load(object sender, EventArgs e)
        {
            Text = "Set Save Interval: " + mpadMain.currentTimer / 1000 + "s";

            setTheme();

            switch (mpadMain.currentTimer / 1000)
            {
                case 30:
                    hslTimer.Value = 1;
                    lblBarTimer.Text = "30 seconds";
                    break;
                case 60:
                    hslTimer.Value = 2;
                    lblBarTimer.Text = "1 minute";
                    break;
                case 120:
                    hslTimer.Value = 3;
                    lblBarTimer.Text = "2 minutes";
                    break;
                case 300:
                    hslTimer.Value = 4;
                    lblBarTimer.Text = "5 minutes";
                    break;
                case 600:
                    hslTimer.Value = 5;
                    lblBarTimer.Text = "10 minutes";
                    break;
                case 1800:
                    hslTimer.Value = 6;
                    lblBarTimer.Text = "30 minutes";
                    break;
                case 3600:
                    hslTimer.Value = 7;
                    lblBarTimer.Text = "1 hour";
                    break;
            }

            TopMost = true;
            Activate();
        }

        private void btnConfirmTimer_Click(object sender, EventArgs e)
        {
            switch (hslTimer.Value)
            {
                case 1:
                    mpadMain.currentTimer = 30000;
                    break;
                case 2:
                    mpadMain.currentTimer = 60000;
                    break;
                case 3:
                    mpadMain.currentTimer = 120000;
                    break;
                case 4:
                    mpadMain.currentTimer = 300000;
                    break;
                case 5:
                    mpadMain.currentTimer = 600000;
                    break;
                case 6:
                    mpadMain.currentTimer = 1800000;
                    break;
                case 7:
                    mpadMain.currentTimer = 3600000;
                    break;
                default:
                    MessageBox.Show("You did not pick an option so no changes have been made.", "Nothing selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }

            Close();
        }

        private void hslTimer_Scroll(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs e)
        {
            switch (hslTimer.Value)
            {
                case 0:
                    lblBarTimer.Text = "Unselected";
                    break;
                case 1:
                    lblBarTimer.Text = "30 seconds";
                    break;
                case 2:
                    lblBarTimer.Text = "1 minute";
                    break;
                case 3:
                    lblBarTimer.Text = "2 minutes";
                    break;
                case 4:
                    lblBarTimer.Text = "5 minutes";
                    break;
                case 5:
                    lblBarTimer.Text = "10 minutes";
                    break;
                case 6:
                    lblBarTimer.Text = "30 minutes";
                    break;
                case 7:
                    lblBarTimer.Text = "1 hour";
                    break;
            }
        }

        private void SetTimer_ParentChanged(object sender, EventArgs e)
        {
            setTheme();
        }

        private void setTheme()
        {
            switch (impConfig.theme)
            {
                case "Light":
                    BackColor = Color.White;

                    hslTimer.SliderColor = Color.FromArgb(30, 144, 255);
                    hslTimer.ElapsedColor = Color.FromArgb(30, 144, 255);
                    hslTimer.ThumbColor = Color.FromArgb(210, 232, 255);

                    foreach (Control c in Controls)
                    {
                        switch (c)
                        {
                            case Label _:
                                c.ForeColor = Color.Black;
                                break;
                            case Guna2Button _:
                                c.ForeColor = Color.Black;
                                c.BackColor = Color.FromName("DodgerBlue");
                                break;
                        }
                    }
                    lblTimerTitle.ForeColor = Color.Black;
                    lblTimerText.ForeColor = Color.Black;
                    lblBarTimer.ForeColor = Color.Black;
                    btnConfirmTimer.ForeColor = Color.Black;
                    break;
                case "Dark":
                    BackColor = Color.FromArgb(30, 30, 30);

                    hslTimer.SliderColor = Color.FromArgb(108, 99, 255);
                    hslTimer.ElapsedColor = Color.FromArgb(108, 99, 255);
                    hslTimer.ThumbColor = Color.FromArgb(108, 99, 255);

                    foreach (Control c in Controls)
                    {
                        switch (c)
                        {
                            case Label _:
                                c.ForeColor = Color.White;
                                break;
                            case Guna2Button _:
                                c.ForeColor = Color.White;
                                c.BackColor = Color.FromArgb(108, 99, 255);
                                break;
                        }
                    }

                    lblTimerTitle.ForeColor = Color.White;
                    lblTimerText.ForeColor = Color.White;
                    lblBarTimer.ForeColor = Color.White;
                    btnConfirmTimer.ForeColor = Color.White;
                    btnConfirmTimer.FillColor = Color.FromArgb(108, 99, 255);
                    break;
            }
        }
    }
}