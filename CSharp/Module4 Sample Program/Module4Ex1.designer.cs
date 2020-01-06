namespace Module4
{
    partial class Module4Ex1
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
            this.grpLoanApplicationInfo = new System.Windows.Forms.GroupBox();
            this.lblRating = new System.Windows.Forms.Label();
            this.radHome = new System.Windows.Forms.RadioButton();
            this.radAuto = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nudDebt = new System.Windows.Forms.NumericUpDown();
            this.nudIncome = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpTriggers = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.grpDisplayInfo = new System.Windows.Forms.GroupBox();
            this.btnPreApproved = new System.Windows.Forms.Button();
            this.btnInterestRate = new System.Windows.Forms.Button();
            this.btnPreQualified = new System.Windows.Forms.Button();
            this.grpLoanApplicationInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDebt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIncome)).BeginInit();
            this.grpTriggers.SuspendLayout();
            this.grpDisplayInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpLoanApplicationInfo
            // 
            this.grpLoanApplicationInfo.Controls.Add(this.lblRating);
            this.grpLoanApplicationInfo.Controls.Add(this.radHome);
            this.grpLoanApplicationInfo.Controls.Add(this.radAuto);
            this.grpLoanApplicationInfo.Controls.Add(this.label7);
            this.grpLoanApplicationInfo.Controls.Add(this.lblScore);
            this.grpLoanApplicationInfo.Controls.Add(this.label6);
            this.grpLoanApplicationInfo.Controls.Add(this.txtName);
            this.grpLoanApplicationInfo.Controls.Add(this.label4);
            this.grpLoanApplicationInfo.Controls.Add(this.nudDebt);
            this.grpLoanApplicationInfo.Controls.Add(this.nudIncome);
            this.grpLoanApplicationInfo.Controls.Add(this.label3);
            this.grpLoanApplicationInfo.Controls.Add(this.label2);
            this.grpLoanApplicationInfo.Controls.Add(this.label1);
            this.grpLoanApplicationInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpLoanApplicationInfo.Location = new System.Drawing.Point(15, 72);
            this.grpLoanApplicationInfo.Name = "grpLoanApplicationInfo";
            this.grpLoanApplicationInfo.Size = new System.Drawing.Size(458, 430);
            this.grpLoanApplicationInfo.TabIndex = 0;
            this.grpLoanApplicationInfo.TabStop = false;
            this.grpLoanApplicationInfo.Text = "Loan Application Info:";
            // 
            // lblRating
            // 
            this.lblRating.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRating.Location = new System.Drawing.Point(167, 301);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(137, 42);
            this.lblRating.TabIndex = 16;
            this.lblRating.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // radHome
            // 
            this.radHome.AutoSize = true;
            this.radHome.Location = new System.Drawing.Point(267, 117);
            this.radHome.Name = "radHome";
            this.radHome.Size = new System.Drawing.Size(111, 36);
            this.radHome.TabIndex = 15;
            this.radHome.Text = "Home";
            this.radHome.UseVisualStyleBackColor = true;
            // 
            // radAuto
            // 
            this.radAuto.AutoSize = true;
            this.radAuto.Checked = true;
            this.radAuto.Location = new System.Drawing.Point(168, 117);
            this.radAuto.Name = "radAuto";
            this.radAuto.Size = new System.Drawing.Size(95, 36);
            this.radAuto.TabIndex = 14;
            this.radAuto.TabStop = true;
            this.radAuto.Text = "Auto";
            this.radAuto.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(6, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 37);
            this.label7.TabIndex = 13;
            this.label7.Text = "Loan Type";
            // 
            // lblScore
            // 
            this.lblScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblScore.Location = new System.Drawing.Point(168, 370);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(137, 42);
            this.lblScore.TabIndex = 12;
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(11, 370);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 42);
            this.label6.TabIndex = 11;
            this.label6.Text = "Credit Score";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(168, 60);
            this.txtName.MaxLength = 20;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(284, 38);
            this.txtName.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(10, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 42);
            this.label4.TabIndex = 9;
            this.label4.Text = "Name";
            // 
            // nudDebt
            // 
            this.nudDebt.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudDebt.Location = new System.Drawing.Point(168, 231);
            this.nudDebt.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudDebt.Name = "nudDebt";
            this.nudDebt.Size = new System.Drawing.Size(137, 38);
            this.nudDebt.TabIndex = 7;
            this.nudDebt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudIncome
            // 
            this.nudIncome.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudIncome.Location = new System.Drawing.Point(168, 167);
            this.nudIncome.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudIncome.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudIncome.Name = "nudIncome";
            this.nudIncome.Size = new System.Drawing.Size(137, 38);
            this.nudIncome.TabIndex = 6;
            this.nudIncome.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudIncome.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(11, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "Credit Rating";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(10, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Debt";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Income";
            // 
            // grpTriggers
            // 
            this.grpTriggers.Controls.Add(this.btnExit);
            this.grpTriggers.Controls.Add(this.btnReset);
            this.grpTriggers.Controls.Add(this.btnCreate);
            this.grpTriggers.Location = new System.Drawing.Point(498, 85);
            this.grpTriggers.Name = "grpTriggers";
            this.grpTriggers.Size = new System.Drawing.Size(318, 139);
            this.grpTriggers.TabIndex = 1;
            this.grpTriggers.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(157, 81);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(148, 45);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReset.Location = new System.Drawing.Point(6, 81);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(148, 45);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(6, 30);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(299, 45);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "&Create Loan Application";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(277, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(289, 42);
            this.label5.TabIndex = 5;
            this.label5.Text = "Test LoanApplication Class";
            // 
            // grpDisplayInfo
            // 
            this.grpDisplayInfo.Controls.Add(this.btnPreApproved);
            this.grpDisplayInfo.Controls.Add(this.btnInterestRate);
            this.grpDisplayInfo.Controls.Add(this.btnPreQualified);
            this.grpDisplayInfo.Enabled = false;
            this.grpDisplayInfo.Location = new System.Drawing.Point(504, 239);
            this.grpDisplayInfo.Name = "grpDisplayInfo";
            this.grpDisplayInfo.Size = new System.Drawing.Size(318, 200);
            this.grpDisplayInfo.TabIndex = 6;
            this.grpDisplayInfo.TabStop = false;
            // 
            // btnPreApproved
            // 
            this.btnPreApproved.Location = new System.Drawing.Point(6, 84);
            this.btnPreApproved.Name = "btnPreApproved";
            this.btnPreApproved.Size = new System.Drawing.Size(299, 45);
            this.btnPreApproved.TabIndex = 6;
            this.btnPreApproved.Text = "Pre-Approved?";
            this.btnPreApproved.UseVisualStyleBackColor = true;
            this.btnPreApproved.Click += new System.EventHandler(this.btnPreApproved_Click);
            // 
            // btnInterestRate
            // 
            this.btnInterestRate.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnInterestRate.Location = new System.Drawing.Point(6, 140);
            this.btnInterestRate.Name = "btnInterestRate";
            this.btnInterestRate.Size = new System.Drawing.Size(299, 45);
            this.btnInterestRate.TabIndex = 1;
            this.btnInterestRate.Text = "Interest Rate?";
            this.btnInterestRate.UseVisualStyleBackColor = true;
            this.btnInterestRate.Click += new System.EventHandler(this.btnInterestRate_Click);
            // 
            // btnPreQualified
            // 
            this.btnPreQualified.Location = new System.Drawing.Point(6, 30);
            this.btnPreQualified.Name = "btnPreQualified";
            this.btnPreQualified.Size = new System.Drawing.Size(299, 45);
            this.btnPreQualified.TabIndex = 0;
            this.btnPreQualified.Text = "Pre-Qualified?";
            this.btnPreQualified.UseVisualStyleBackColor = true;
            this.btnPreQualified.Click += new System.EventHandler(this.btnPreQualified_Click);
            // 
            // Module4Ex1
            // 
            this.AcceptButton = this.btnCreate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(825, 513);
            this.Controls.Add(this.grpDisplayInfo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.grpTriggers);
            this.Controls.Add(this.grpLoanApplicationInfo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Module4Ex1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Module 4 - Example 1";
            this.grpLoanApplicationInfo.ResumeLayout(false);
            this.grpLoanApplicationInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDebt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIncome)).EndInit();
            this.grpTriggers.ResumeLayout(false);
            this.grpDisplayInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpLoanApplicationInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpTriggers;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudDebt;
        private System.Windows.Forms.NumericUpDown nudIncome;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radHome;
        private System.Windows.Forms.RadioButton radAuto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.GroupBox grpDisplayInfo;
        private System.Windows.Forms.Button btnPreApproved;
        private System.Windows.Forms.Button btnInterestRate;
        private System.Windows.Forms.Button btnPreQualified;
    }
}

