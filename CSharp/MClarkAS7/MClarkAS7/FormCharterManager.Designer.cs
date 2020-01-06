namespace MClarkAS7
{
    partial class FormCharterManager
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuDisplay = new System.Windows.Forms.ToolStripMenuItem();
            this.allChartersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numberOfChartersForAYachtTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chartersSummaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReset = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.addYachtTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeYachtTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cBoxYachtTypes = new System.Windows.Forms.ComboBox();
            this.cMenuYachtTypes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addYachtTypeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.removeYachtTypeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblYachtTypes = new System.Windows.Forms.Label();
            this.lBoxYachtSize = new System.Windows.Forms.ListBox();
            this.lblYachtSize = new System.Windows.Forms.Label();
            this.tBoxCustomerName = new System.Windows.Forms.TextBox();
            this.nudHoursChartered = new System.Windows.Forms.NumericUpDown();
            this.lblHoursChartered = new System.Windows.Forms.Label();
            this.btnAddCharter = new System.Windows.Forms.Button();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.menu.SuspendLayout();
            this.cMenuYachtTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoursChartered)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDisplay,
            this.menuEdit});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(399, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "Menu";
            // 
            // menuDisplay
            // 
            this.menuDisplay.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allChartersToolStripMenuItem,
            this.numberOfChartersForAYachtTypeToolStripMenuItem,
            this.chartersSummaryToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.menuDisplay.Name = "menuDisplay";
            this.menuDisplay.Size = new System.Drawing.Size(57, 20);
            this.menuDisplay.Text = "Display";
            // 
            // allChartersToolStripMenuItem
            // 
            this.allChartersToolStripMenuItem.Enabled = false;
            this.allChartersToolStripMenuItem.Name = "allChartersToolStripMenuItem";
            this.allChartersToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.allChartersToolStripMenuItem.Size = new System.Drawing.Size(309, 22);
            this.allChartersToolStripMenuItem.Text = "All Charters";
            this.allChartersToolStripMenuItem.Click += new System.EventHandler(this.allChartersToolStripMenuItem_Click);
            // 
            // numberOfChartersForAYachtTypeToolStripMenuItem
            // 
            this.numberOfChartersForAYachtTypeToolStripMenuItem.Enabled = false;
            this.numberOfChartersForAYachtTypeToolStripMenuItem.Name = "numberOfChartersForAYachtTypeToolStripMenuItem";
            this.numberOfChartersForAYachtTypeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.numberOfChartersForAYachtTypeToolStripMenuItem.Size = new System.Drawing.Size(309, 22);
            this.numberOfChartersForAYachtTypeToolStripMenuItem.Text = "Number of Charters for a Yacht Type";
            // 
            // chartersSummaryToolStripMenuItem
            // 
            this.chartersSummaryToolStripMenuItem.Enabled = false;
            this.chartersSummaryToolStripMenuItem.Name = "chartersSummaryToolStripMenuItem";
            this.chartersSummaryToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.chartersSummaryToolStripMenuItem.Size = new System.Drawing.Size(309, 22);
            this.chartersSummaryToolStripMenuItem.Text = "Charters Summary";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(306, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(309, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // menuEdit
            // 
            this.menuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuReset,
            this.toolStripSeparator2,
            this.addYachtTypeToolStripMenuItem,
            this.removeYachtTypeToolStripMenuItem});
            this.menuEdit.Name = "menuEdit";
            this.menuEdit.Size = new System.Drawing.Size(39, 20);
            this.menuEdit.Text = "Edit";
            // 
            // menuReset
            // 
            this.menuReset.Name = "menuReset";
            this.menuReset.Size = new System.Drawing.Size(189, 22);
            this.menuReset.Text = "Reset for Next Charter";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(186, 6);
            // 
            // addYachtTypeToolStripMenuItem
            // 
            this.addYachtTypeToolStripMenuItem.Name = "addYachtTypeToolStripMenuItem";
            this.addYachtTypeToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.addYachtTypeToolStripMenuItem.Text = "Add Yacht Type";
            // 
            // removeYachtTypeToolStripMenuItem
            // 
            this.removeYachtTypeToolStripMenuItem.Name = "removeYachtTypeToolStripMenuItem";
            this.removeYachtTypeToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.removeYachtTypeToolStripMenuItem.Text = "Remove Yacht Type";
            // 
            // cBoxYachtTypes
            // 
            this.cBoxYachtTypes.ContextMenuStrip = this.cMenuYachtTypes;
            this.cBoxYachtTypes.FormattingEnabled = true;
            this.cBoxYachtTypes.Items.AddRange(new object[] {
            "Express Cruiser",
            "Flybridge",
            "Sedan Bridge",
            "Motor Yacht",
            "Tri-Deck",
            "Sportfish",
            "Skylounge",
            "Mega Yacht"});
            this.cBoxYachtTypes.Location = new System.Drawing.Point(175, 153);
            this.cBoxYachtTypes.Name = "cBoxYachtTypes";
            this.cBoxYachtTypes.Size = new System.Drawing.Size(121, 21);
            this.cBoxYachtTypes.TabIndex = 1;
            // 
            // cMenuYachtTypes
            // 
            this.cMenuYachtTypes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addYachtTypeToolStripMenuItem1,
            this.removeYachtTypeToolStripMenuItem1});
            this.cMenuYachtTypes.Name = "cMenuYachtTypes";
            this.cMenuYachtTypes.Size = new System.Drawing.Size(178, 48);
            // 
            // addYachtTypeToolStripMenuItem1
            // 
            this.addYachtTypeToolStripMenuItem1.Name = "addYachtTypeToolStripMenuItem1";
            this.addYachtTypeToolStripMenuItem1.Size = new System.Drawing.Size(177, 22);
            this.addYachtTypeToolStripMenuItem1.Text = "Add Yacht Type";
            // 
            // removeYachtTypeToolStripMenuItem1
            // 
            this.removeYachtTypeToolStripMenuItem1.Name = "removeYachtTypeToolStripMenuItem1";
            this.removeYachtTypeToolStripMenuItem1.Size = new System.Drawing.Size(177, 22);
            this.removeYachtTypeToolStripMenuItem1.Text = "Remove Yacht Type";
            // 
            // lblYachtTypes
            // 
            this.lblYachtTypes.AutoSize = true;
            this.lblYachtTypes.Location = new System.Drawing.Point(172, 137);
            this.lblYachtTypes.Name = "lblYachtTypes";
            this.lblYachtTypes.Size = new System.Drawing.Size(67, 13);
            this.lblYachtTypes.TabIndex = 2;
            this.lblYachtTypes.Text = "Yacht Types";
            // 
            // lBoxYachtSize
            // 
            this.lBoxYachtSize.AllowDrop = true;
            this.lBoxYachtSize.FormattingEnabled = true;
            this.lBoxYachtSize.Items.AddRange(new object[] {
            "",
            "22",
            "24",
            "30",
            "32",
            "36",
            "38",
            "45"});
            this.lBoxYachtSize.Location = new System.Drawing.Point(314, 153);
            this.lBoxYachtSize.Name = "lBoxYachtSize";
            this.lBoxYachtSize.ScrollAlwaysVisible = true;
            this.lBoxYachtSize.Size = new System.Drawing.Size(58, 30);
            this.lBoxYachtSize.TabIndex = 3;
            // 
            // lblYachtSize
            // 
            this.lblYachtSize.AutoSize = true;
            this.lblYachtSize.Location = new System.Drawing.Point(314, 137);
            this.lblYachtSize.Name = "lblYachtSize";
            this.lblYachtSize.Size = new System.Drawing.Size(58, 13);
            this.lblYachtSize.TabIndex = 4;
            this.lblYachtSize.Text = "Yacht Size";
            // 
            // tBoxCustomerName
            // 
            this.tBoxCustomerName.Location = new System.Drawing.Point(175, 60);
            this.tBoxCustomerName.Name = "tBoxCustomerName";
            this.tBoxCustomerName.Size = new System.Drawing.Size(197, 20);
            this.tBoxCustomerName.TabIndex = 5;
            this.tBoxCustomerName.WordWrap = false;
            // 
            // nudHoursChartered
            // 
            this.nudHoursChartered.Location = new System.Drawing.Point(318, 99);
            this.nudHoursChartered.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nudHoursChartered.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudHoursChartered.Name = "nudHoursChartered";
            this.nudHoursChartered.Size = new System.Drawing.Size(54, 20);
            this.nudHoursChartered.TabIndex = 6;
            this.nudHoursChartered.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudHoursChartered.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblHoursChartered
            // 
            this.lblHoursChartered.AutoSize = true;
            this.lblHoursChartered.Location = new System.Drawing.Point(175, 101);
            this.lblHoursChartered.Name = "lblHoursChartered";
            this.lblHoursChartered.Size = new System.Drawing.Size(84, 13);
            this.lblHoursChartered.TabIndex = 7;
            this.lblHoursChartered.Text = "Hours Chartered";
            // 
            // btnAddCharter
            // 
            this.btnAddCharter.Location = new System.Drawing.Point(297, 204);
            this.btnAddCharter.Name = "btnAddCharter";
            this.btnAddCharter.Size = new System.Drawing.Size(75, 23);
            this.btnAddCharter.TabIndex = 8;
            this.btnAddCharter.Text = "Add Charter";
            this.btnAddCharter.UseVisualStyleBackColor = true;
            this.btnAddCharter.Click += new System.EventHandler(this.btnAddCharter_Click);
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(175, 41);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(110, 13);
            this.lblCustomerName.TabIndex = 10;
            this.lblCustomerName.Text = "Enter Customer Name";
            // 
            // FormCharterManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 260);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.btnAddCharter);
            this.Controls.Add(this.lblHoursChartered);
            this.Controls.Add(this.nudHoursChartered);
            this.Controls.Add(this.tBoxCustomerName);
            this.Controls.Add(this.lblYachtSize);
            this.Controls.Add(this.lBoxYachtSize);
            this.Controls.Add(this.lblYachtTypes);
            this.Controls.Add(this.cBoxYachtTypes);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "FormCharterManager";
            this.Text = "FormCharterManager";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.cMenuYachtTypes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudHoursChartered)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem menuDisplay;
        private System.Windows.Forms.ToolStripMenuItem allChartersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem numberOfChartersForAYachtTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chartersSummaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuEdit;
        private System.Windows.Forms.ToolStripMenuItem menuReset;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem addYachtTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeYachtTypeToolStripMenuItem;
        private System.Windows.Forms.ComboBox cBoxYachtTypes;
        private System.Windows.Forms.Label lblYachtTypes;
        private System.Windows.Forms.ListBox lBoxYachtSize;
        private System.Windows.Forms.Label lblYachtSize;
        private System.Windows.Forms.TextBox tBoxCustomerName;
        private System.Windows.Forms.NumericUpDown nudHoursChartered;
        private System.Windows.Forms.Label lblHoursChartered;
        private System.Windows.Forms.Button btnAddCharter;
        private System.Windows.Forms.ContextMenuStrip cMenuYachtTypes;
        private System.Windows.Forms.ToolStripMenuItem addYachtTypeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem removeYachtTypeToolStripMenuItem1;
        private System.Windows.Forms.Label lblCustomerName;
    }
}