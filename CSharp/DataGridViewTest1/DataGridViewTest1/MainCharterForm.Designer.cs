namespace DataGridViewTest1
{
    partial class MainCharterForm
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
            this.tBoxCustomerName = new System.Windows.Forms.TextBox();
            this.toolTips = new System.Windows.Forms.ToolTip(this.components);
            this.listBoxYachtSize = new System.Windows.Forms.ListBox();
            this.listBoxYachtTypes = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.nudCharterHours = new System.Windows.Forms.NumericUpDown();
            this.btnExit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.displayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allChartersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numberOfChartersByYachtSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.summaryOfChartersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addYachtTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeYachtTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddCharter = new System.Windows.Forms.Button();
            this.charterManagerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.lblCustomerNamePrompt = new System.Windows.Forms.Label();
            this.lblDev = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCharterHours)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.charterManagerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tBoxCustomerName
            // 
            this.tBoxCustomerName.Location = new System.Drawing.Point(12, 57);
            this.tBoxCustomerName.Name = "tBoxCustomerName";
            this.tBoxCustomerName.Size = new System.Drawing.Size(251, 27);
            this.tBoxCustomerName.TabIndex = 2;
            this.tBoxCustomerName.WordWrap = false;
            // 
            // toolTips
            // 
            this.toolTips.IsBalloon = true;
            // 
            // listBoxYachtSize
            // 
            this.listBoxYachtSize.FormatString = "N0";
            this.listBoxYachtSize.FormattingEnabled = true;
            this.listBoxYachtSize.ItemHeight = 20;
            this.listBoxYachtSize.Items.AddRange(new object[] {
            "22",
            "24",
            "30",
            "32",
            "36",
            "38",
            "45"});
            this.listBoxYachtSize.Location = new System.Drawing.Point(12, 118);
            this.listBoxYachtSize.Name = "listBoxYachtSize";
            this.listBoxYachtSize.Size = new System.Drawing.Size(54, 84);
            this.listBoxYachtSize.TabIndex = 3;
            this.toolTips.SetToolTip(this.listBoxYachtSize, "Yacht Size");
            // 
            // listBoxYachtTypes
            // 
            this.listBoxYachtTypes.ContextMenuStrip = this.contextMenuStrip1;
            this.listBoxYachtTypes.FormattingEnabled = true;
            this.listBoxYachtTypes.ItemHeight = 20;
            this.listBoxYachtTypes.Items.AddRange(new object[] {
            "Express Cruiser",
            "Flybridge",
            "Sedan Bridge",
            "Motor Yacht",
            "Tri-Deck",
            "Sportfish",
            "Skylounge",
            "Mega Yacht"});
            this.listBoxYachtTypes.Location = new System.Drawing.Point(126, 118);
            this.listBoxYachtTypes.Name = "listBoxYachtTypes";
            this.listBoxYachtTypes.Size = new System.Drawing.Size(137, 84);
            this.listBoxYachtTypes.TabIndex = 4;
            this.toolTips.SetToolTip(this.listBoxYachtTypes, "Yacht Type");
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(178, 48);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 22);
            this.toolStripMenuItem1.Text = "Add Yacht Type";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 22);
            this.toolStripMenuItem2.Text = "Remove Yacht Type";
            // 
            // nudCharterHours
            // 
            this.nudCharterHours.Location = new System.Drawing.Point(12, 233);
            this.nudCharterHours.Name = "nudCharterHours";
            this.nudCharterHours.Size = new System.Drawing.Size(79, 27);
            this.nudCharterHours.TabIndex = 5;
            this.nudCharterHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTips.SetToolTip(this.nudCharterHours, "Charter Hours");
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(188, 298);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 31);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(276, 25);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // displayToolStripMenuItem
            // 
            this.displayToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allChartersToolStripMenuItem,
            this.numberOfChartersByYachtSizeToolStripMenuItem,
            this.summaryOfChartersToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.displayToolStripMenuItem.Name = "displayToolStripMenuItem";
            this.displayToolStripMenuItem.Size = new System.Drawing.Size(62, 21);
            this.displayToolStripMenuItem.Text = "Display";
            // 
            // allChartersToolStripMenuItem
            // 
            this.allChartersToolStripMenuItem.Enabled = false;
            this.allChartersToolStripMenuItem.Name = "allChartersToolStripMenuItem";
            this.allChartersToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.allChartersToolStripMenuItem.Text = "All Charters";
            this.allChartersToolStripMenuItem.Click += new System.EventHandler(this.allChartersToolStripMenuItem_Click);
            // 
            // numberOfChartersByYachtSizeToolStripMenuItem
            // 
            this.numberOfChartersByYachtSizeToolStripMenuItem.Enabled = false;
            this.numberOfChartersByYachtSizeToolStripMenuItem.Name = "numberOfChartersByYachtSizeToolStripMenuItem";
            this.numberOfChartersByYachtSizeToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.numberOfChartersByYachtSizeToolStripMenuItem.Text = "Number of Charters by Yacht Size";
            // 
            // summaryOfChartersToolStripMenuItem
            // 
            this.summaryOfChartersToolStripMenuItem.Enabled = false;
            this.summaryOfChartersToolStripMenuItem.Name = "summaryOfChartersToolStripMenuItem";
            this.summaryOfChartersToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.summaryOfChartersToolStripMenuItem.Text = "Summary of Charters";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(269, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripSeparator2,
            this.addYachtTypeToolStripMenuItem,
            this.removeYachtTypeToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(42, 21);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // addYachtTypeToolStripMenuItem
            // 
            this.addYachtTypeToolStripMenuItem.Name = "addYachtTypeToolStripMenuItem";
            this.addYachtTypeToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.addYachtTypeToolStripMenuItem.Text = "Add Yacht Type";
            // 
            // removeYachtTypeToolStripMenuItem
            // 
            this.removeYachtTypeToolStripMenuItem.Name = "removeYachtTypeToolStripMenuItem";
            this.removeYachtTypeToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.removeYachtTypeToolStripMenuItem.Text = "Remove Yacht Type";
            // 
            // btnAddCharter
            // 
            this.btnAddCharter.Location = new System.Drawing.Point(12, 298);
            this.btnAddCharter.Name = "btnAddCharter";
            this.btnAddCharter.Size = new System.Drawing.Size(109, 31);
            this.btnAddCharter.TabIndex = 8;
            this.btnAddCharter.Text = "Add Charter";
            this.btnAddCharter.UseVisualStyleBackColor = true;
            this.btnAddCharter.Click += new System.EventHandler(this.btnAddCharter_Click);
            // 
            // charterManagerBindingSource
            // 
            this.charterManagerBindingSource.DataSource = typeof(DataGridViewTest1.Charter);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(207, 22);
            this.toolStripMenuItem3.Text = "Reset for Next Charter";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(204, 6);
            // 
            // lblCustomerNamePrompt
            // 
            this.lblCustomerNamePrompt.AutoSize = true;
            this.lblCustomerNamePrompt.Location = new System.Drawing.Point(13, 38);
            this.lblCustomerNamePrompt.Name = "lblCustomerNamePrompt";
            this.lblCustomerNamePrompt.Size = new System.Drawing.Size(116, 20);
            this.lblCustomerNamePrompt.TabIndex = 9;
            this.lblCustomerNamePrompt.Text = "Customer Name";
            // 
            // lblDev
            // 
            this.lblDev.AutoSize = true;
            this.lblDev.Location = new System.Drawing.Point(13, 372);
            this.lblDev.Name = "lblDev";
            this.lblDev.Size = new System.Drawing.Size(176, 20);
            this.lblDev.TabIndex = 10;
            this.lblDev.Text = "Developed by Mary Clark";
            // 
            // MainCharterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 397);
            this.Controls.Add(this.lblDev);
            this.Controls.Add(this.lblCustomerNamePrompt);
            this.Controls.Add(this.btnAddCharter);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.nudCharterHours);
            this.Controls.Add(this.listBoxYachtTypes);
            this.Controls.Add(this.listBoxYachtSize);
            this.Controls.Add(this.tBoxCustomerName);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainCharterForm";
            this.Text = "Charter Manager";
            this.Load += new System.EventHandler(this.CharterListForm_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudCharterHours)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.charterManagerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource charterManagerBindingSource;
        private System.Windows.Forms.TextBox tBoxCustomerName;
        private System.Windows.Forms.ToolTip toolTips;
        private System.Windows.Forms.ListBox listBoxYachtSize;
        private System.Windows.Forms.ListBox listBoxYachtTypes;
        private System.Windows.Forms.NumericUpDown nudCharterHours;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem displayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allChartersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem numberOfChartersByYachtSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem summaryOfChartersToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addYachtTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeYachtTypeToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Button btnAddCharter;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Label lblCustomerNamePrompt;
        private System.Windows.Forms.Label lblDev;
    }
}

