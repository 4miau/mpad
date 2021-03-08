using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace mpad
{
    partial class Confirmation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Confirmation));
            this.lblConfirmTitle = new System.Windows.Forms.Label();
            this.lblConfirmText = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.pnlBackground = new Bunifu.UI.WinForms.BunifuPanel();
            this.btnUnconfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblConfirmTitle
            // 
            this.lblConfirmTitle.AutoSize = true;
            this.lblConfirmTitle.Font = new System.Drawing.Font("Lato", 16F, System.Drawing.FontStyle.Bold);
            this.lblConfirmTitle.Location = new System.Drawing.Point(165, 9);
            this.lblConfirmTitle.Name = "lblConfirmTitle";
            this.lblConfirmTitle.Size = new System.Drawing.Size(144, 27);
            this.lblConfirmTitle.TabIndex = 1;
            this.lblConfirmTitle.Text = "Are you sure?";
            // 
            // lblConfirmText
            // 
            this.lblConfirmText.AutoSize = true;
            this.lblConfirmText.Location = new System.Drawing.Point(12, 57);
            this.lblConfirmText.Name = "lblConfirmText";
            this.lblConfirmText.Size = new System.Drawing.Size(87, 13);
            this.lblConfirmText.TabIndex = 2;
            this.lblConfirmText.Text = "Placeholder Text";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Location = new System.Drawing.Point(29, 144);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(130, 23);
            this.btnConfirm.TabIndex = 3;
            this.btnConfirm.Text = "Save";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // pnlBackground
            // 
            this.pnlBackground.BackgroundColor = System.Drawing.Color.Transparent;
            this.pnlBackground.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlBackground.BackgroundImage")));
            this.pnlBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlBackground.BorderColor = System.Drawing.Color.Transparent;
            this.pnlBackground.BorderRadius = 3;
            this.pnlBackground.BorderThickness = 0;
            this.pnlBackground.Controls.Add(this.btnCancel);
            this.pnlBackground.Controls.Add(this.btnUnconfirm);
            this.pnlBackground.Controls.Add(this.btnConfirm);
            this.pnlBackground.Controls.Add(this.lblConfirmText);
            this.pnlBackground.Controls.Add(this.lblConfirmTitle);
            this.pnlBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBackground.Location = new System.Drawing.Point(0, 0);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.ShowBorders = false;
            this.pnlBackground.Size = new System.Drawing.Size(491, 179);
            this.pnlBackground.TabIndex = 0;
            // 
            // btnUnconfirm
            // 
            this.btnUnconfirm.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUnconfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnconfirm.Location = new System.Drawing.Point(179, 144);
            this.btnUnconfirm.Name = "btnUnconfirm";
            this.btnUnconfirm.Size = new System.Drawing.Size(130, 23);
            this.btnUnconfirm.TabIndex = 4;
            this.btnUnconfirm.Text = "Don\'t Save";
            this.btnUnconfirm.UseVisualStyleBackColor = false;
            this.btnUnconfirm.Click += new System.EventHandler(this.btnUnconfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(329, 144);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(130, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Confirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 179);
            this.Controls.Add(this.pnlBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Confirmation";
            this.Text = "mpad";
            this.Load += new System.EventHandler(this.Confirmation_Load);
            this.FormClosing += new FormClosingEventHandler(this.ConfirmFormClosing);
            this.pnlBackground.ResumeLayout(false);
            this.pnlBackground.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblConfirmTitle;
        private System.Windows.Forms.Label lblConfirmText;
        private System.Windows.Forms.Button btnConfirm;
        private Bunifu.UI.WinForms.BunifuPanel pnlBackground;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUnconfirm;
    }
}