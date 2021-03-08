using System;
using System.Windows.Forms;

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
            TopMost = true;
            Activate();
        }

        /*
30 Seconds
1 Minute
2 Minutes
5 Minutes
10 Minutes
30 Minutes
1 Hour
         */

        private void btnConfirmTimer_Click(object sender, EventArgs e)
        {
            switch (cbxSelectTimer.SelectedIndex)
            {
                case 0:
                    MessageBox.Show("30 seconds selected.");
                    mpadMain.currentTimer = 30000;
                    break;
                case 1:
                    MessageBox.Show("1 minute selected.");
                    mpadMain.currentTimer = 60000;
                    break;
                case 2:
                    MessageBox.Show("2 minutes selected.");
                    mpadMain.currentTimer = 120000;
                    break;
                case 3:
                    MessageBox.Show("5 minutes selected.");
                    mpadMain.currentTimer = 300000;
                    break;
                case 4:
                    MessageBox.Show("10 minutes selected.");
                    mpadMain.currentTimer = 600000;
                    break;
                case 5:
                    MessageBox.Show("30 minutes selected.");
                    mpadMain.currentTimer = 1800000;
                    break;
                case 6:
                    MessageBox.Show("1 hour selected.");
                    mpadMain.currentTimer = 3600000;
                    break;
                default:
                    MessageBox.Show("You did not pick an option so no changes have been made.", "Nothing selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }

            Close();
        }
    }
}