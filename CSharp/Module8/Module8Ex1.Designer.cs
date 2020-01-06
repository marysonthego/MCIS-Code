namespace Module8
{
    partial class Module8Ex1
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
            this.components = new System.ComponentModel.Container();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditFont = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditColor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuView = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewToolBar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewSummary = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.lblQuote = new System.Windows.Forms.Label();
            this.mnuContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stbInfo = new System.Windows.Forms.StatusStrip();
            this.stbPanel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.stbPanel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.stbPanel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.mnuMain.SuspendLayout();
            this.mnuContext.SuspendLayout();
            this.stbInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuEdit,
            this.mnuView,
            this.mnuHelp});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(579, 40);
            this.mnuMain.TabIndex = 0;
            this.mnuMain.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileOpen,
            this.mnuFileSaveAs,
            this.toolStripSeparator1,
            this.mnuFileExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(64, 36);
            this.mnuFile.Text = "&File";
            // 
            // mnuFileOpen
            // 
            this.mnuFileOpen.Name = "mnuFileOpen";
            this.mnuFileOpen.Size = new System.Drawing.Size(178, 36);
            this.mnuFileOpen.Text = "&Open";
            this.mnuFileOpen.Click += new System.EventHandler(this.mnuFileOpen_Click);
            // 
            // mnuFileSaveAs
            // 
            this.mnuFileSaveAs.Name = "mnuFileSaveAs";
            this.mnuFileSaveAs.Size = new System.Drawing.Size(178, 36);
            this.mnuFileSaveAs.Text = "Save &As";
            this.mnuFileSaveAs.Click += new System.EventHandler(this.mnuFileSaveAs_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(175, 6);
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.Size = new System.Drawing.Size(178, 36);
            this.mnuFileExit.Text = "E&xit";
            this.mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);
            // 
            // mnuEdit
            // 
            this.mnuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEditFont,
            this.mnuEditColor});
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Size = new System.Drawing.Size(67, 36);
            this.mnuEdit.Text = "&Edit";
            // 
            // mnuEditFont
            // 
            this.mnuEditFont.Name = "mnuEditFont";
            this.mnuEditFont.Size = new System.Drawing.Size(153, 36);
            this.mnuEditFont.Text = "&Font";
            this.mnuEditFont.Click += new System.EventHandler(this.mnuEditFont_Click);
            // 
            // mnuEditColor
            // 
            this.mnuEditColor.Name = "mnuEditColor";
            this.mnuEditColor.Size = new System.Drawing.Size(153, 36);
            this.mnuEditColor.Text = "&Color";
            this.mnuEditColor.Click += new System.EventHandler(this.mnuEditColor_Click);
            // 
            // mnuView
            // 
            this.mnuView.Checked = true;
            this.mnuView.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuViewToolBar,
            this.mnuViewSummary});
            this.mnuView.Name = "mnuView";
            this.mnuView.Size = new System.Drawing.Size(78, 36);
            this.mnuView.Text = "&View";
            // 
            // mnuViewToolBar
            // 
            this.mnuViewToolBar.Checked = true;
            this.mnuViewToolBar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuViewToolBar.Name = "mnuViewToolBar";
            this.mnuViewToolBar.Size = new System.Drawing.Size(197, 36);
            this.mnuViewToolBar.Text = "Tool Bar";
            this.mnuViewToolBar.Click += new System.EventHandler(this.mnuViewToolBar_Click);
            // 
            // mnuViewSummary
            // 
            this.mnuViewSummary.Enabled = false;
            this.mnuViewSummary.Name = "mnuViewSummary";
            this.mnuViewSummary.Size = new System.Drawing.Size(197, 36);
            this.mnuViewSummary.Text = "Summary";
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHelpAbout});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(77, 36);
            this.mnuHelp.Text = "&Help";
            // 
            // mnuHelpAbout
            // 
            this.mnuHelpAbout.Name = "mnuHelpAbout";
            this.mnuHelpAbout.Size = new System.Drawing.Size(161, 36);
            this.mnuHelpAbout.Text = "About";
            // 
            // lblQuote
            // 
            this.lblQuote.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblQuote.ContextMenuStrip = this.mnuContext;
            this.lblQuote.Location = new System.Drawing.Point(25, 66);
            this.lblQuote.Name = "lblQuote";
            this.lblQuote.Size = new System.Drawing.Size(530, 178);
            this.lblQuote.TabIndex = 1;
            this.lblQuote.Text = "Any fool can write code that a computer can understand. Good programmers write co" +
    "de that humans can understand.\r\n--Martin Fowler";
            // 
            // mnuContext
            // 
            this.mnuContext.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem,
            this.colorToolStripMenuItem,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem});
            this.mnuContext.Name = "mnuContext";
            this.mnuContext.Size = new System.Drawing.Size(115, 82);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.fontToolStripMenuItem.Text = "Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.mnuEditFont_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.colorToolStripMenuItem.Text = "Color";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.mnuEditColor_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(111, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.mnuFileExit_Click);
            // 
            // stbInfo
            // 
            this.stbInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stbInfo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.stbInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stbPanel1,
            this.stbPanel2,
            this.stbPanel3});
            this.stbInfo.Location = new System.Drawing.Point(0, 267);
            this.stbInfo.Name = "stbInfo";
            this.stbInfo.Size = new System.Drawing.Size(579, 41);
            this.stbInfo.TabIndex = 2;
            this.stbInfo.Text = "statusStrip1";
            // 
            // stbPanel1
            // 
            this.stbPanel1.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.stbPanel1.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.stbPanel1.Name = "stbPanel1";
            this.stbPanel1.Size = new System.Drawing.Size(393, 36);
            this.stbPanel1.Text = "Demo for Menus and Dialog Boxes";
            // 
            // stbPanel2
            // 
            this.stbPanel2.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.stbPanel2.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.stbPanel2.Name = "stbPanel2";
            this.stbPanel2.Size = new System.Drawing.Size(4, 36);
            // 
            // stbPanel3
            // 
            this.stbPanel3.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.stbPanel3.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.stbPanel3.Name = "stbPanel3";
            this.stbPanel3.Size = new System.Drawing.Size(4, 36);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Module8Ex1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 308);
            this.Controls.Add(this.stbInfo);
            this.Controls.Add(this.lblQuote);
            this.Controls.Add(this.mnuMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.mnuMain;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Module8Ex1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Module 8 - Example 1";
            this.Load += new System.EventHandler(this.Module8Ex1_Load);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.mnuContext.ResumeLayout(false);
            this.stbInfo.ResumeLayout(false);
            this.stbInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuFileSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuEditFont;
        private System.Windows.Forms.ToolStripMenuItem mnuEditColor;
        private System.Windows.Forms.ToolStripMenuItem mnuView;
        private System.Windows.Forms.ToolStripMenuItem mnuViewToolBar;
        private System.Windows.Forms.ToolStripMenuItem mnuViewSummary;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuHelpAbout;
        private System.Windows.Forms.Label lblQuote;
        private System.Windows.Forms.ContextMenuStrip mnuContext;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip stbInfo;
        private System.Windows.Forms.ToolStripStatusLabel stbPanel1;
        private System.Windows.Forms.ToolStripStatusLabel stbPanel2;
        private System.Windows.Forms.ToolStripStatusLabel stbPanel3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

