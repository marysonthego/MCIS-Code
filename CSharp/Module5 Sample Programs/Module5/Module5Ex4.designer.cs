namespace Module5
{
    partial class Module5Ex4
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
            this.grpInvestmentInfo = new System.Windows.Forms.GroupBox();
            this.nudRate = new System.Windows.Forms.NumericUpDown();
            this.nudAmount = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.grpTriggers = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudPeriod = new System.Windows.Forms.NumericUpDown();
            this.grpInvestmentInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            this.grpTriggers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPeriod)).BeginInit();
            this.SuspendLayout();
            // 
            // grpInvestmentInfo
            // 
            this.grpInvestmentInfo.Controls.Add(this.lblInfo);
            this.grpInvestmentInfo.Controls.Add(this.nudPeriod);
            this.grpInvestmentInfo.Controls.Add(this.label3);
            this.grpInvestmentInfo.Controls.Add(this.nudRate);
            this.grpInvestmentInfo.Controls.Add(this.nudAmount);
            this.grpInvestmentInfo.Controls.Add(this.label2);
            this.grpInvestmentInfo.Controls.Add(this.label1);
            this.grpInvestmentInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpInvestmentInfo.Location = new System.Drawing.Point(15, 72);
            this.grpInvestmentInfo.Name = "grpInvestmentInfo";
            this.grpInvestmentInfo.Size = new System.Drawing.Size(402, 360);
            this.grpInvestmentInfo.TabIndex = 0;
            this.grpInvestmentInfo.TabStop = false;
            this.grpInvestmentInfo.Text = "Investment Info:";
            // 
            // nudRate
            // 
            this.nudRate.DecimalPlaces = 1;
            this.nudRate.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudRate.Location = new System.Drawing.Point(244, 100);
            this.nudRate.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudRate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRate.Name = "nudRate";
            this.nudRate.Size = new System.Drawing.Size(137, 32);
            this.nudRate.TabIndex = 7;
            this.nudRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudRate.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudAmount
            // 
            this.nudAmount.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudAmount.Location = new System.Drawing.Point(244, 45);
            this.nudAmount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudAmount.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(137, 32);
            this.nudAmount.TabIndex = 6;
            this.nudAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudAmount.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(10, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Investment Rate:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(10, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Investment Amount:";
            // 
            // lblInfo
            // 
            this.lblInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblInfo.Location = new System.Drawing.Point(15, 206);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(366, 136);
            this.lblInfo.TabIndex = 16;
            // 
            // grpTriggers
            // 
            this.grpTriggers.Controls.Add(this.btnExit);
            this.grpTriggers.Controls.Add(this.btnReset);
            this.grpTriggers.Controls.Add(this.btnCreate);
            this.grpTriggers.Location = new System.Drawing.Point(61, 438);
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
            this.btnCreate.Text = "&Create Investment";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(125, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 33);
            this.label5.TabIndex = 5;
            this.label5.Text = "Test Investment Class";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(10, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Investment Duration:";
            // 
            // nudPeriod
            // 
            this.nudPeriod.Increment = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudPeriod.Location = new System.Drawing.Point(244, 160);
            this.nudPeriod.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.nudPeriod.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudPeriod.Name = "nudPeriod";
            this.nudPeriod.Size = new System.Drawing.Size(137, 32);
            this.nudPeriod.TabIndex = 9;
            this.nudPeriod.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudPeriod.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // Module5Ex4
            // 
            this.AcceptButton = this.btnCreate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(436, 581);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.grpTriggers);
            this.Controls.Add(this.grpInvestmentInfo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Module5Ex4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Module 5 - Example 4";
            this.grpInvestmentInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            this.grpTriggers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudPeriod)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInvestmentInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpTriggers;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudRate;
        private System.Windows.Forms.NumericUpDown nudAmount;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.NumericUpDown nudPeriod;
        private System.Windows.Forms.Label label3;
    }
}

