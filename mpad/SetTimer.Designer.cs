
using System.Windows.Forms;

namespace mpad
{
    partial class SetTimer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetTimer));
            this.lblTimerTitle = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblTimerText = new Bunifu.UI.WinForms.BunifuLabel();
            this.hslTimer = new Bunifu.UI.WinForms.BunifuHSlider();
            this.lblBarTimer = new System.Windows.Forms.Label();
            this.btnConfirmTimer = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // lblTimerTitle
            // 
            this.lblTimerTitle.AllowParentOverrides = false;
            this.lblTimerTitle.AutoEllipsis = false;
            this.lblTimerTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTimerTitle.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblTimerTitle.Font = new System.Drawing.Font("Lato", 20F, System.Drawing.FontStyle.Bold);
            this.lblTimerTitle.Location = new System.Drawing.Point(183, 4);
            this.lblTimerTitle.Name = "lblTimerTitle";
            this.lblTimerTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTimerTitle.Size = new System.Drawing.Size(116, 33);
            this.lblTimerTitle.TabIndex = 0;
            this.lblTimerTitle.Text = "Set Timer";
            this.lblTimerTitle.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblTimerTitle.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblTimerText
            // 
            this.lblTimerText.AllowParentOverrides = false;
            this.lblTimerText.AutoEllipsis = false;
            this.lblTimerText.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTimerText.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblTimerText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTimerText.Location = new System.Drawing.Point(22, 48);
            this.lblTimerText.Name = "lblTimerText";
            this.lblTimerText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTimerText.Size = new System.Drawing.Size(438, 15);
            this.lblTimerText.TabIndex = 1;
            this.lblTimerText.Text = "Select a save interval below. WARNING: This WILL reset the current auto-save time" +
    "r.";
            this.lblTimerText.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblTimerText.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // hslTimer
            // 
            this.hslTimer.AllowCursorChanges = true;
            this.hslTimer.AllowHomeEndKeysDetection = false;
            this.hslTimer.AllowIncrementalClickMoves = true;
            this.hslTimer.AllowMouseDownEffects = false;
            this.hslTimer.AllowMouseHoverEffects = false;
            this.hslTimer.AllowScrollingAnimations = true;
            this.hslTimer.AllowScrollKeysDetection = true;
            this.hslTimer.AllowScrollOptionsMenu = true;
            this.hslTimer.AllowShrinkingOnFocusLost = false;
            this.hslTimer.BackColor = System.Drawing.Color.Transparent;
            this.hslTimer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hslTimer.BackgroundImage")));
            this.hslTimer.BindingContainer = null;
            this.hslTimer.BorderRadius = 2;
            this.hslTimer.BorderThickness = 1;
            this.hslTimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hslTimer.DrawThickBorder = false;
            this.hslTimer.DurationBeforeShrink = 2000;
            this.hslTimer.ElapsedColor = System.Drawing.Color.DodgerBlue;
            this.hslTimer.LargeChange = 1;
            this.hslTimer.Location = new System.Drawing.Point(8, 72);
            this.hslTimer.Maximum = 7;
            this.hslTimer.Minimum = 1;
            this.hslTimer.MinimumSize = new System.Drawing.Size(0, 31);
            this.hslTimer.MinimumThumbLength = 18;
            this.hslTimer.Name = "hslTimer";
            this.hslTimer.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.hslTimer.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.hslTimer.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.hslTimer.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.hslTimer.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.hslTimer.ShrinkSizeLimit = 3;
            this.hslTimer.Size = new System.Drawing.Size(466, 31);
            this.hslTimer.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.hslTimer.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thin;
            this.hslTimer.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular;
            this.hslTimer.SmallChange = 1;
            this.hslTimer.TabIndex = 4;
            this.hslTimer.ThumbColor = System.Drawing.Color.DodgerBlue;
            this.hslTimer.ThumbFillColor = System.Drawing.SystemColors.Control;
            this.hslTimer.ThumbLength = 66;
            this.hslTimer.ThumbMargin = 1;
            this.hslTimer.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Medium;
            this.hslTimer.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Outline;
            this.hslTimer.Value = 1;
            this.hslTimer.Scroll += new System.EventHandler<Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs>(this.hslTimer_Scroll);
            // 
            // lblBarTimer
            // 
            this.lblBarTimer.AutoSize = true;
            this.lblBarTimer.Location = new System.Drawing.Point(209, 104);
            this.lblBarTimer.Name = "lblBarTimer";
            this.lblBarTimer.Size = new System.Drawing.Size(64, 13);
            this.lblBarTimer.TabIndex = 5;
            this.lblBarTimer.Text = "30 Seconds";
            // 
            // btnConfirmTimer
            // 
            this.btnConfirmTimer.Animated = true;
            this.btnConfirmTimer.AutoRoundedCorners = true;
            this.btnConfirmTimer.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirmTimer.BorderRadius = 15;
            this.btnConfirmTimer.BorderThickness = 1;
            this.btnConfirmTimer.CheckedState.Parent = this.btnConfirmTimer;
            this.btnConfirmTimer.CustomImages.Parent = this.btnConfirmTimer;
            this.btnConfirmTimer.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnConfirmTimer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnConfirmTimer.ForeColor = System.Drawing.Color.White;
            this.btnConfirmTimer.HoverState.Parent = this.btnConfirmTimer;
            this.btnConfirmTimer.ImageSize = new System.Drawing.Size(0, 0);
            this.btnConfirmTimer.Location = new System.Drawing.Point(138, 130);
            this.btnConfirmTimer.Name = "btnConfirmTimer";
            this.btnConfirmTimer.ShadowDecoration.Parent = this.btnConfirmTimer;
            this.btnConfirmTimer.Size = new System.Drawing.Size(198, 33);
            this.btnConfirmTimer.TabIndex = 3;
            this.btnConfirmTimer.Text = "Confirm";
            this.btnConfirmTimer.UseTransparentBackground = true;
            this.btnConfirmTimer.Click += new System.EventHandler(this.btnConfirmTimer_Click);
            // 
            // SetTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 175);
            this.Controls.Add(this.btnConfirmTimer);
            this.Controls.Add(this.lblBarTimer);
            this.Controls.Add(this.hslTimer);
            this.Controls.Add(this.lblTimerText);
            this.Controls.Add(this.lblTimerTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SetTimer";
            this.Text = "SetTimer";
            this.Load += new System.EventHandler(this.SetTimer_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SetTimer_keyDown);
            this.ParentChanged += new System.EventHandler(this.SetTimer_ParentChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuLabel lblTimerTitle;
        private Bunifu.UI.WinForms.BunifuLabel lblTimerText;
        private Bunifu.UI.WinForms.BunifuHSlider hslTimer;
        private System.Windows.Forms.Label lblBarTimer;
        private Guna.UI2.WinForms.Guna2Button btnConfirmTimer;
    }
}