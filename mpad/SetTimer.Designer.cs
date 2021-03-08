
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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.lblTimerTitle = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblTimerText = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnConfirmTimer = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.cbxSelectTimer = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblTimerTitle
            // 
            this.lblTimerTitle.AllowParentOverrides = false;
            this.lblTimerTitle.AutoEllipsis = false;
            this.lblTimerTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTimerTitle.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblTimerTitle.Font = new System.Drawing.Font("Lato", 20F, System.Drawing.FontStyle.Bold);
            this.lblTimerTitle.Location = new System.Drawing.Point(177, 10);
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
            this.lblTimerText.Location = new System.Drawing.Point(12, 62);
            this.lblTimerText.Name = "lblTimerText";
            this.lblTimerText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTimerText.Size = new System.Drawing.Size(461, 15);
            this.lblTimerText.TabIndex = 1;
            this.lblTimerText.Text = "Select one a save interval below. WARNING: This WILL reset the current auto-save " +
    "timer.";
            this.lblTimerText.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblTimerText.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnConfirmTimer
            // 
            this.btnConfirmTimer.AllowAnimations = true;
            this.btnConfirmTimer.AllowMouseEffects = true;
            this.btnConfirmTimer.AllowToggling = false;
            this.btnConfirmTimer.AnimationSpeed = 200;
            this.btnConfirmTimer.AutoGenerateColors = false;
            this.btnConfirmTimer.AutoRoundBorders = false;
            this.btnConfirmTimer.AutoSizeLeftIcon = true;
            this.btnConfirmTimer.AutoSizeRightIcon = true;
            this.btnConfirmTimer.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirmTimer.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnConfirmTimer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConfirmTimer.BackgroundImage")));
            this.btnConfirmTimer.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnConfirmTimer.ButtonText = "Confirm";
            this.btnConfirmTimer.ButtonTextMarginLeft = 0;
            this.btnConfirmTimer.ColorContrastOnClick = 45;
            this.btnConfirmTimer.ColorContrastOnHover = 45;
            this.btnConfirmTimer.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnConfirmTimer.CustomizableEdges = borderEdges1;
            this.btnConfirmTimer.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnConfirmTimer.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnConfirmTimer.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnConfirmTimer.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnConfirmTimer.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnConfirmTimer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnConfirmTimer.ForeColor = System.Drawing.Color.White;
            this.btnConfirmTimer.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmTimer.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnConfirmTimer.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnConfirmTimer.IconMarginLeft = 11;
            this.btnConfirmTimer.IconPadding = 10;
            this.btnConfirmTimer.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfirmTimer.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnConfirmTimer.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnConfirmTimer.IconSize = 25;
            this.btnConfirmTimer.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnConfirmTimer.IdleBorderRadius = 1;
            this.btnConfirmTimer.IdleBorderThickness = 1;
            this.btnConfirmTimer.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnConfirmTimer.IdleIconLeftImage = null;
            this.btnConfirmTimer.IdleIconRightImage = null;
            this.btnConfirmTimer.IndicateFocus = false;
            this.btnConfirmTimer.Location = new System.Drawing.Point(135, 133);
            this.btnConfirmTimer.Name = "btnConfirmTimer";
            this.btnConfirmTimer.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnConfirmTimer.OnDisabledState.BorderRadius = 1;
            this.btnConfirmTimer.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnConfirmTimer.OnDisabledState.BorderThickness = 1;
            this.btnConfirmTimer.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnConfirmTimer.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnConfirmTimer.OnDisabledState.IconLeftImage = null;
            this.btnConfirmTimer.OnDisabledState.IconRightImage = null;
            this.btnConfirmTimer.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnConfirmTimer.onHoverState.BorderRadius = 1;
            this.btnConfirmTimer.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnConfirmTimer.onHoverState.BorderThickness = 1;
            this.btnConfirmTimer.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnConfirmTimer.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnConfirmTimer.onHoverState.IconLeftImage = null;
            this.btnConfirmTimer.onHoverState.IconRightImage = null;
            this.btnConfirmTimer.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnConfirmTimer.OnIdleState.BorderRadius = 1;
            this.btnConfirmTimer.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnConfirmTimer.OnIdleState.BorderThickness = 1;
            this.btnConfirmTimer.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnConfirmTimer.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnConfirmTimer.OnIdleState.IconLeftImage = null;
            this.btnConfirmTimer.OnIdleState.IconRightImage = null;
            this.btnConfirmTimer.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnConfirmTimer.OnPressedState.BorderRadius = 1;
            this.btnConfirmTimer.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnConfirmTimer.OnPressedState.BorderThickness = 1;
            this.btnConfirmTimer.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnConfirmTimer.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnConfirmTimer.OnPressedState.IconLeftImage = null;
            this.btnConfirmTimer.OnPressedState.IconRightImage = null;
            this.btnConfirmTimer.Size = new System.Drawing.Size(198, 33);
            this.btnConfirmTimer.TabIndex = 2;
            this.btnConfirmTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnConfirmTimer.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnConfirmTimer.TextMarginLeft = 0;
            this.btnConfirmTimer.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnConfirmTimer.UseDefaultRadiusAndThickness = true;
            this.btnConfirmTimer.Click += new System.EventHandler(this.btnConfirmTimer_Click);
            // 
            // cbxSelectTimer
            // 
            this.cbxSelectTimer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSelectTimer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbxSelectTimer.FormattingEnabled = true;
            this.cbxSelectTimer.Items.AddRange(new object[] {
            "30 Seconds",
            "1 Minute",
            "2 Minutes",
            "5 Minutes",
            "10 Minutes",
            "30 Minutes",
            "1 Hour"});
            this.cbxSelectTimer.Location = new System.Drawing.Point(7, 87);
            this.cbxSelectTimer.Name = "cbxSelectTimer";
            this.cbxSelectTimer.Size = new System.Drawing.Size(466, 21);
            this.cbxSelectTimer.TabIndex = 3;
            // 
            // SetTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 175);
            this.Controls.Add(this.cbxSelectTimer);
            this.Controls.Add(this.btnConfirmTimer);
            this.Controls.Add(this.lblTimerText);
            this.Controls.Add(this.lblTimerTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SetTimer";
            this.Text = "SetTimer";
            this.Load += new System.EventHandler(this.SetTimer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuLabel lblTimerTitle;
        private Bunifu.UI.WinForms.BunifuLabel lblTimerText;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnConfirmTimer;
        private System.Windows.Forms.ComboBox cbxSelectTimer;
    }
}