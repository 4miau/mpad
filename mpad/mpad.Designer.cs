
using System.ComponentModel;
using System.Windows.Forms;

namespace mpad
{
    partial class mpadMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mpadMain));
            this.mnuOptions = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.fiNew = new System.Windows.Forms.ToolStripMenuItem();
            this.fiNewWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.fiSeperator1 = new System.Windows.Forms.ToolStripSeparator();
            this.fiOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.fiSeperator2 = new System.Windows.Forms.ToolStripSeparator();
            this.fiSave = new System.Windows.Forms.ToolStripMenuItem();
            this.fiSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.fiSeperator3 = new System.Windows.Forms.ToolStripSeparator();
            this.fiAutoSave = new System.Windows.Forms.ToolStripMenuItem();
            this.ASaveTimer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.edUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.edRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.edSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.edCut = new System.Windows.Forms.ToolStripMenuItem();
            this.edCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.edPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.edSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.edFind = new System.Windows.Forms.ToolStripMenuItem();
            this.edReplace = new System.Windows.Forms.ToolStripMenuItem();
            this.edSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.edTD = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.foWrap = new System.Windows.Forms.ToolStripMenuItem();
            this.foFont = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSelection = new System.Windows.Forms.ToolStripMenuItem();
            this.seSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuView = new System.Windows.Forms.ToolStripMenuItem();
            this.viZoomIn = new System.Windows.Forms.ToolStripMenuItem();
            this.viZoomOut = new System.Windows.Forms.ToolStripMenuItem();
            this.viResZoom = new System.Windows.Forms.ToolStripMenuItem();
            this.viSeperator1 = new System.Windows.Forms.ToolStripSeparator();
            this.viTheme = new System.Windows.Forms.ToolStripMenuItem();
            this.thLight = new System.Windows.Forms.ToolStripMenuItem();
            this.thDark = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.heCredits = new System.Windows.Forms.ToolStripMenuItem();
            this.heNotes = new System.Windows.Forms.ToolStripMenuItem();
            this.heSeperator1 = new System.Windows.Forms.ToolStripSeparator();
            this.heAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.txtMain = new Guna.UI2.WinForms.Guna2TextBox();
            this.mnuOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuOptions
            // 
            this.mnuOptions.AllowMerge = false;
            this.mnuOptions.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.mnuOptions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mnuOptions.GripMargin = new System.Windows.Forms.Padding(0);
            this.mnuOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuEdit,
            this.mnuFormat,
            this.mnuSelection,
            this.mnuView,
            this.mnuHelp});
            this.mnuOptions.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.mnuOptions.Location = new System.Drawing.Point(0, 0);
            this.mnuOptions.Name = "mnuOptions";
            this.mnuOptions.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.mnuOptions.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mnuOptions.Size = new System.Drawing.Size(800, 19);
            this.mnuOptions.Stretch = false;
            this.mnuOptions.TabIndex = 0;
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fiNew,
            this.fiNewWindow,
            this.fiSeperator1,
            this.fiOpen,
            this.fiSeperator2,
            this.fiSave,
            this.fiSaveAs,
            this.fiSeperator3,
            this.fiAutoSave});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.mnuFile.Size = new System.Drawing.Size(33, 19);
            this.mnuFile.Text = "File";
            this.mnuFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fiNew
            // 
            this.fiNew.Name = "fiNew";
            this.fiNew.Size = new System.Drawing.Size(145, 22);
            this.fiNew.Text = "New ";
            this.fiNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fiNew.Click += new System.EventHandler(this.fiNew_Click);
            // 
            // fiNewWindow
            // 
            this.fiNewWindow.Name = "fiNewWindow";
            this.fiNewWindow.Size = new System.Drawing.Size(145, 22);
            this.fiNewWindow.Text = "New Window";
            this.fiNewWindow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fiNewWindow.Click += new System.EventHandler(this.fiNewWindow_Click);
            // 
            // fiSeperator1
            // 
            this.fiSeperator1.Name = "fiSeperator1";
            this.fiSeperator1.Size = new System.Drawing.Size(142, 6);
            // 
            // fiOpen
            // 
            this.fiOpen.Name = "fiOpen";
            this.fiOpen.Size = new System.Drawing.Size(145, 22);
            this.fiOpen.Text = "Open";
            this.fiOpen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fiOpen.Click += new System.EventHandler(this.fiOpen_Click);
            // 
            // fiSeperator2
            // 
            this.fiSeperator2.Name = "fiSeperator2";
            this.fiSeperator2.Size = new System.Drawing.Size(142, 6);
            // 
            // fiSave
            // 
            this.fiSave.Name = "fiSave";
            this.fiSave.Size = new System.Drawing.Size(145, 22);
            this.fiSave.Text = "Save";
            this.fiSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fiSave.Click += new System.EventHandler(this.fiSave_Click);
            // 
            // fiSaveAs
            // 
            this.fiSaveAs.Name = "fiSaveAs";
            this.fiSaveAs.Size = new System.Drawing.Size(145, 22);
            this.fiSaveAs.Text = "Save As";
            this.fiSaveAs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fiSaveAs.Click += new System.EventHandler(this.fiSaveAs_Click);
            // 
            // fiSeperator3
            // 
            this.fiSeperator3.Name = "fiSeperator3";
            this.fiSeperator3.Size = new System.Drawing.Size(142, 6);
            // 
            // fiAutoSave
            // 
            this.fiAutoSave.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ASaveTimer});
            this.fiAutoSave.Name = "fiAutoSave";
            this.fiAutoSave.Size = new System.Drawing.Size(145, 22);
            this.fiAutoSave.Text = "Auto-Save";
            this.fiAutoSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fiAutoSave.Click += new System.EventHandler(this.fiAutoSave_Click);
            // 
            // ASaveTimer
            // 
            this.ASaveTimer.Name = "ASaveTimer";
            this.ASaveTimer.Size = new System.Drawing.Size(123, 22);
            this.ASaveTimer.Text = "Set Timer";
            this.ASaveTimer.Click += new System.EventHandler(this.ASaveTimer_Click);
            // 
            // mnuEdit
            // 
            this.mnuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.edUndo,
            this.edRedo,
            this.edSeparator1,
            this.edCut,
            this.edCopy,
            this.edPaste,
            this.edSeparator2,
            this.edFind,
            this.edReplace,
            this.edSeparator3,
            this.edTD});
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.mnuEdit.Size = new System.Drawing.Size(35, 19);
            this.mnuEdit.Text = "Edit";
            this.mnuEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // edUndo
            // 
            this.edUndo.Name = "edUndo";
            this.edUndo.Size = new System.Drawing.Size(140, 22);
            this.edUndo.Text = "Undo";
            this.edUndo.Click += new System.EventHandler(this.edUndo_Click);
            // 
            // edRedo
            // 
            this.edRedo.Name = "edRedo";
            this.edRedo.Size = new System.Drawing.Size(140, 22);
            this.edRedo.Text = "Redo";
            this.edRedo.Click += new System.EventHandler(this.edRedo_Click);
            // 
            // edSeparator1
            // 
            this.edSeparator1.Name = "edSeparator1";
            this.edSeparator1.Size = new System.Drawing.Size(137, 6);
            // 
            // edCut
            // 
            this.edCut.Name = "edCut";
            this.edCut.Size = new System.Drawing.Size(140, 22);
            this.edCut.Text = "Cut";
            this.edCut.Click += new System.EventHandler(this.edCut_Click);
            // 
            // edCopy
            // 
            this.edCopy.Name = "edCopy";
            this.edCopy.Size = new System.Drawing.Size(140, 22);
            this.edCopy.Text = "Copy";
            this.edCopy.Click += new System.EventHandler(this.edCopy_Click);
            // 
            // edPaste
            // 
            this.edPaste.Name = "edPaste";
            this.edPaste.Size = new System.Drawing.Size(140, 22);
            this.edPaste.Text = "Paste";
            this.edPaste.Click += new System.EventHandler(this.edPaste_Click);
            // 
            // edSeparator2
            // 
            this.edSeparator2.Name = "edSeparator2";
            this.edSeparator2.Size = new System.Drawing.Size(137, 6);
            // 
            // edFind
            // 
            this.edFind.Name = "edFind";
            this.edFind.Size = new System.Drawing.Size(140, 22);
            this.edFind.Text = "Find";
            // 
            // edReplace
            // 
            this.edReplace.Name = "edReplace";
            this.edReplace.Size = new System.Drawing.Size(140, 22);
            this.edReplace.Text = "Replace";
            // 
            // edSeparator3
            // 
            this.edSeparator3.Name = "edSeparator3";
            this.edSeparator3.Size = new System.Drawing.Size(137, 6);
            // 
            // edTD
            // 
            this.edTD.Name = "edTD";
            this.edTD.Size = new System.Drawing.Size(140, 22);
            this.edTD.Text = "Time && Date";
            this.edTD.Click += new System.EventHandler(this.edTD_Click);
            // 
            // mnuFormat
            // 
            this.mnuFormat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.foWrap,
            this.foFont});
            this.mnuFormat.Name = "mnuFormat";
            this.mnuFormat.Size = new System.Drawing.Size(57, 19);
            this.mnuFormat.Text = "Format";
            this.mnuFormat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // foWrap
            // 
            this.foWrap.Name = "foWrap";
            this.foWrap.Size = new System.Drawing.Size(102, 22);
            this.foWrap.Text = "Wrap";
            this.foWrap.Click += new System.EventHandler(this.foWrap_Click);
            // 
            // foFont
            // 
            this.foFont.Name = "foFont";
            this.foFont.Size = new System.Drawing.Size(102, 22);
            this.foFont.Text = "Font";
            this.foFont.Click += new System.EventHandler(this.foFont_Click);
            // 
            // mnuSelection
            // 
            this.mnuSelection.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seSelectAll});
            this.mnuSelection.Name = "mnuSelection";
            this.mnuSelection.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.mnuSelection.Size = new System.Drawing.Size(63, 19);
            this.mnuSelection.Text = "Selection";
            this.mnuSelection.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // seSelectAll
            // 
            this.seSelectAll.Name = "seSelectAll";
            this.seSelectAll.Size = new System.Drawing.Size(122, 22);
            this.seSelectAll.Text = "Select All";
            this.seSelectAll.Click += new System.EventHandler(this.seSelectAll_Click);
            // 
            // mnuView
            // 
            this.mnuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viZoomIn,
            this.viZoomOut,
            this.viResZoom,
            this.viSeperator1,
            this.viTheme});
            this.mnuView.Name = "mnuView";
            this.mnuView.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.mnuView.Size = new System.Drawing.Size(40, 19);
            this.mnuView.Text = "View";
            this.mnuView.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // viZoomIn
            // 
            this.viZoomIn.Name = "viZoomIn";
            this.viZoomIn.Size = new System.Drawing.Size(189, 22);
            this.viZoomIn.Text = "Zoom In";
            this.viZoomIn.Click += new System.EventHandler(this.viZoomIn_Click);
            // 
            // viZoomOut
            // 
            this.viZoomOut.Name = "viZoomOut";
            this.viZoomOut.Size = new System.Drawing.Size(189, 22);
            this.viZoomOut.Text = "Zoom Out";
            this.viZoomOut.Click += new System.EventHandler(this.viZoomOut_Click);
            // 
            // viResZoom
            // 
            this.viResZoom.Name = "viResZoom";
            this.viResZoom.Size = new System.Drawing.Size(189, 22);
            this.viResZoom.Text = "Restore Default Zoom";
            this.viResZoom.Click += new System.EventHandler(this.viResZoom_Click);
            // 
            // viSeperator1
            // 
            this.viSeperator1.Name = "viSeperator1";
            this.viSeperator1.Size = new System.Drawing.Size(186, 6);
            // 
            // viTheme
            // 
            this.viTheme.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thLight,
            this.thDark});
            this.viTheme.Name = "viTheme";
            this.viTheme.Size = new System.Drawing.Size(189, 22);
            this.viTheme.Text = "Theme";
            // 
            // thLight
            // 
            this.thLight.Name = "thLight";
            this.thLight.Size = new System.Drawing.Size(101, 22);
            this.thLight.Text = "Light";
            this.thLight.Click += new System.EventHandler(this.thLight_Click);
            // 
            // thDark
            // 
            this.thDark.Name = "thDark";
            this.thDark.Size = new System.Drawing.Size(101, 22);
            this.thDark.Text = "Dark";
            this.thDark.Click += new System.EventHandler(this.thDark_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.heCredits,
            this.heNotes,
            this.heSeperator1,
            this.heAbout});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.mnuHelp.Size = new System.Drawing.Size(40, 19);
            this.mnuHelp.Text = "Help";
            this.mnuHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // heCredits
            // 
            this.heCredits.Name = "heCredits";
            this.heCredits.Size = new System.Drawing.Size(111, 22);
            this.heCredits.Text = "Credits";
            // 
            // heNotes
            // 
            this.heNotes.Name = "heNotes";
            this.heNotes.Size = new System.Drawing.Size(111, 22);
            this.heNotes.Text = "Notes";
            // 
            // heSeperator1
            // 
            this.heSeperator1.Name = "heSeperator1";
            this.heSeperator1.Size = new System.Drawing.Size(108, 6);
            // 
            // heAbout
            // 
            this.heAbout.Name = "heAbout";
            this.heAbout.Size = new System.Drawing.Size(111, 22);
            this.heAbout.Text = "About";
            // 
            // txtMain
            // 
            this.txtMain.AcceptsReturn = true;
            this.txtMain.AcceptsTab = true;
            this.txtMain.Animated = true;
            this.txtMain.AutoScroll = true;
            this.txtMain.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.txtMain.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtMain.BorderColor = System.Drawing.Color.DimGray;
            this.txtMain.BorderRadius = 1;
            this.txtMain.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMain.CustomizableEdges.BottomLeft = false;
            this.txtMain.CustomizableEdges.BottomRight = false;
            this.txtMain.CustomizableEdges.TopLeft = false;
            this.txtMain.CustomizableEdges.TopRight = false;
            this.txtMain.DefaultText = "";
            this.txtMain.DisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.txtMain.DisabledState.FillColor = System.Drawing.Color.Transparent;
            this.txtMain.DisabledState.ForeColor = System.Drawing.Color.Transparent;
            this.txtMain.DisabledState.Parent = this.txtMain;
            this.txtMain.DisabledState.PlaceholderForeColor = System.Drawing.Color.Transparent;
            this.txtMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMain.FocusedState.BorderColor = System.Drawing.Color.DimGray;
            this.txtMain.FocusedState.Parent = this.txtMain;
            this.txtMain.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtMain.ForeColor = System.Drawing.Color.Black;
            this.txtMain.HideSelection = false;
            this.txtMain.HoverState.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtMain.HoverState.Parent = this.txtMain;
            this.txtMain.IconLeftSize = new System.Drawing.Size(0, 0);
            this.txtMain.IconRightSize = new System.Drawing.Size(0, 0);
            this.txtMain.Location = new System.Drawing.Point(0, 19);
            this.txtMain.Margin = new System.Windows.Forms.Padding(0);
            this.txtMain.MaxLength = 99999999;
            this.txtMain.Multiline = true;
            this.txtMain.Name = "txtMain";
            this.txtMain.PasswordChar = '\0';
            this.txtMain.PlaceholderText = "";
            this.txtMain.SelectedText = "";
            this.txtMain.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.txtMain.ShadowDecoration.Parent = this.txtMain;
            this.txtMain.Size = new System.Drawing.Size(800, 431);
            this.txtMain.TabIndex = 1;
            this.txtMain.TextOffset = new System.Drawing.Point(-8, -8);
            this.txtMain.TextChanged += new System.EventHandler(this.updateContent);
            this.txtMain.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDown);
            // 
            // mpadMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtMain);
            this.Controls.Add(this.mnuOptions);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuOptions;
            this.Name = "mpadMain";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mpadUnload);
            this.Load += new System.EventHandler(this.mpadLoad);
            this.mnuOptions.ResumeLayout(false);
            this.mnuOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuOptions;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuFormat;
        private System.Windows.Forms.ToolStripMenuItem mnuSelection;
        private System.Windows.Forms.ToolStripMenuItem mnuView;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem fiNew;
        private System.Windows.Forms.ToolStripSeparator fiSeperator1;
        private System.Windows.Forms.ToolStripMenuItem fiOpen;
        private System.Windows.Forms.ToolStripSeparator fiSeperator2;
        private System.Windows.Forms.ToolStripMenuItem fiSave;
        private System.Windows.Forms.ToolStripMenuItem fiSaveAs;
        private System.Windows.Forms.ToolStripSeparator fiSeperator3;
        private System.Windows.Forms.ToolStripMenuItem fiAutoSave;
        private System.Windows.Forms.ToolStripMenuItem edUndo;
        private System.Windows.Forms.ToolStripMenuItem edRedo;
        private System.Windows.Forms.ToolStripSeparator edSeparator1;
        private System.Windows.Forms.ToolStripMenuItem edCut;
        private System.Windows.Forms.ToolStripMenuItem edCopy;
        private System.Windows.Forms.ToolStripMenuItem edPaste;
        private System.Windows.Forms.ToolStripSeparator edSeparator2;
        private System.Windows.Forms.ToolStripMenuItem edFind;
        private System.Windows.Forms.ToolStripMenuItem edReplace;
        private System.Windows.Forms.ToolStripSeparator edSeparator3;
        private System.Windows.Forms.ToolStripMenuItem edTD;
        private System.Windows.Forms.ToolStripMenuItem seSelectAll;
        private System.Windows.Forms.ToolStripMenuItem viZoomIn;
        private System.Windows.Forms.ToolStripMenuItem viZoomOut;
        private System.Windows.Forms.ToolStripMenuItem viResZoom;
        private System.Windows.Forms.ToolStripSeparator viSeperator1;
        private System.Windows.Forms.ToolStripMenuItem viTheme;
        private System.Windows.Forms.ToolStripMenuItem thLight;
        private System.Windows.Forms.ToolStripMenuItem thDark;
        private System.Windows.Forms.ToolStripMenuItem heCredits;
        private System.Windows.Forms.ToolStripMenuItem heNotes;
        private System.Windows.Forms.ToolStripSeparator heSeperator1;
        private System.Windows.Forms.ToolStripMenuItem heAbout;
        private System.Windows.Forms.ToolStripMenuItem foWrap;
        private System.Windows.Forms.ToolStripMenuItem foFont;
        private System.Windows.Forms.ToolStripMenuItem fiNewWindow;
        private System.Windows.Forms.ToolStripMenuItem ASaveTimer;
        private Guna.UI2.WinForms.Guna2TextBox txtMain;
    }
}

