using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace mpad
{
    public partial class Confirmation : Form
    {
        public int Type;

        public Confirmation()
        {
            InitializeComponent();
        }

        private void ConfirmFormClosing(object sender, FormClosingEventArgs e)
        {
            if ((new StackTrace().GetFrames() ?? Array.Empty<StackFrame>()).Any(x => x.GetMethod().Name == "Close")
            ) _ = 1;
            else mpadMain.newReturn = 3;

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            mpadMain.newReturn = 1;
            Close();
        }

        private void btnUnconfirm_Click(object sender, EventArgs e)
        {
            mpadMain.newReturn = 2;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            mpadMain.newReturn = 3;
            Close();
        }

        private void Confirmation_Load(object sender, EventArgs e)
        {
            switch (Type)
            {
                case 1:
                    btnUnconfirm.Hide();
                    btnCancel.Hide();
                    lblConfirmText.Text = "Are you sure that you would like to clear the notepad? All unsaved changes will lost.";
                    btnConfirm.Text = "Confirm";
                    btnConfirm.Location = new Point(160, 144);
                    btnConfirm.Size = new Size(154, 23);
                    break;
                case 2:
                    lblConfirmText.Text =
                        "Are you sure that you would like to close mpad without saving? All unsaved changes will be lost.";

                    btnConfirm.Text = "Save";


                    btnUnconfirm.Text = "Don't Save";

                    btnCancel.Text = "Cancel";
                    break;
            }

            TopMost = true;
            Activate();
        }
    }
}

/*
                    btnConfirm.Location = new Point(29, 144);
                    btnConfirm.Size = new Size(130, 23);
                    btnUnconfirm.Location = new Point(179, 144);
                    btnUnconfirm.Size = new Size(130, 23);

                    btnCancel.Location = new Point(329, 144);
                    btnCancel.Size = new Size(130, 23);
 */