namespace Program8
{
    partial class PayStubForm
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
            this.tBoxName = new System.Windows.Forms.TextBox();
            this.lblHoursWorked = new System.Windows.Forms.Label();
            this.lblPayRate = new System.Windows.Forms.Label();
            this.nudHoursWorked = new System.Windows.Forms.NumericUpDown();
            this.nudPayRate = new System.Windows.Forms.NumericUpDown();
            this.btnPayStub = new System.Windows.Forms.Button();
            this.lblNetPay = new System.Windows.Forms.Label();
            this.btnSummary = new System.Windows.Forms.Button();
            this.lblTotalNumberOfPayStubs = new System.Windows.Forms.Label();
            this.lblTotalNetPay = new System.Windows.Forms.Label();
            this.lblAverageNetPay = new System.Windows.Forms.Label();
            this.lblPayRateError = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoursWorked)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPayRate)).BeginInit();
            this.SuspendLayout();
            // 
            // tBoxName
            // 
            this.tBoxName.Location = new System.Drawing.Point(31, 20);
            this.tBoxName.Name = "tBoxName";
            this.tBoxName.Size = new System.Drawing.Size(243, 22);
            this.tBoxName.TabIndex = 0;
            this.tBoxName.Text = "Enter Employee Name";
            // 
            // lblHoursWorked
            // 
            this.lblHoursWorked.AutoSize = true;
            this.lblHoursWorked.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHoursWorked.Location = new System.Drawing.Point(31, 56);
            this.lblHoursWorked.Name = "lblHoursWorked";
            this.lblHoursWorked.Size = new System.Drawing.Size(100, 18);
            this.lblHoursWorked.TabIndex = 1;
            this.lblHoursWorked.Text = "Hours Worked:";
            // 
            // lblPayRate
            // 
            this.lblPayRate.AutoSize = true;
            this.lblPayRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPayRate.Location = new System.Drawing.Point(31, 93);
            this.lblPayRate.Name = "lblPayRate";
            this.lblPayRate.Size = new System.Drawing.Size(69, 18);
            this.lblPayRate.TabIndex = 2;
            this.lblPayRate.Text = "Pay Rate:";
            // 
            // nudHoursWorked
            // 
            this.nudHoursWorked.Location = new System.Drawing.Point(218, 54);
            this.nudHoursWorked.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.nudHoursWorked.Name = "nudHoursWorked";
            this.nudHoursWorked.Size = new System.Drawing.Size(56, 22);
            this.nudHoursWorked.TabIndex = 3;
            this.nudHoursWorked.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudPayRate
            // 
            this.nudPayRate.DecimalPlaces = 2;
            this.nudPayRate.Location = new System.Drawing.Point(198, 91);
            this.nudPayRate.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudPayRate.Name = "nudPayRate";
            this.nudPayRate.Size = new System.Drawing.Size(76, 22);
            this.nudPayRate.TabIndex = 4;
            this.nudPayRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnPayStub
            // 
            this.btnPayStub.Location = new System.Drawing.Point(31, 146);
            this.btnPayStub.Name = "btnPayStub";
            this.btnPayStub.Size = new System.Drawing.Size(75, 23);
            this.btnPayStub.TabIndex = 5;
            this.btnPayStub.Text = "PayStub";
            this.btnPayStub.UseVisualStyleBackColor = true;
            this.btnPayStub.Click += new System.EventHandler(this.btnPayStub_Click);
            // 
            // lblNetPay
            // 
            this.lblNetPay.AutoSize = true;
            this.lblNetPay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNetPay.Location = new System.Drawing.Point(218, 149);
            this.lblNetPay.Name = "lblNetPay";
            this.lblNetPay.Size = new System.Drawing.Size(58, 18);
            this.lblNetPay.TabIndex = 6;
            this.lblNetPay.Text = "Net Pay";
            this.lblNetPay.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // btnSummary
            // 
            this.btnSummary.Location = new System.Drawing.Point(449, 20);
            this.btnSummary.Name = "btnSummary";
            this.btnSummary.Size = new System.Drawing.Size(75, 23);
            this.btnSummary.TabIndex = 7;
            this.btnSummary.Text = "Summary";
            this.btnSummary.UseVisualStyleBackColor = true;
            this.btnSummary.Click += new System.EventHandler(this.btnSummary_Click);
            // 
            // lblTotalNumberOfPayStubs
            // 
            this.lblTotalNumberOfPayStubs.AutoSize = true;
            this.lblTotalNumberOfPayStubs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalNumberOfPayStubs.Location = new System.Drawing.Point(449, 62);
            this.lblTotalNumberOfPayStubs.Name = "lblTotalNumberOfPayStubs";
            this.lblTotalNumberOfPayStubs.Size = new System.Drawing.Size(176, 18);
            this.lblTotalNumberOfPayStubs.TabIndex = 8;
            this.lblTotalNumberOfPayStubs.Text = "Total Number of Pay Stubs: ";
            // 
            // lblTotalNetPay
            // 
            this.lblTotalNetPay.AutoSize = true;
            this.lblTotalNetPay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalNetPay.Location = new System.Drawing.Point(449, 95);
            this.lblTotalNetPay.Name = "lblTotalNetPay";
            this.lblTotalNetPay.Size = new System.Drawing.Size(98, 18);
            this.lblTotalNetPay.TabIndex = 9;
            this.lblTotalNetPay.Text = "Total Net Pay: ";
            // 
            // lblAverageNetPay
            // 
            this.lblAverageNetPay.AutoSize = true;
            this.lblAverageNetPay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAverageNetPay.Location = new System.Drawing.Point(449, 131);
            this.lblAverageNetPay.Name = "lblAverageNetPay";
            this.lblAverageNetPay.Size = new System.Drawing.Size(119, 18);
            this.lblAverageNetPay.TabIndex = 10;
            this.lblAverageNetPay.Text = "Average Net Pay: ";
            // 
            // lblPayRateError
            // 
            this.lblPayRateError.AutoSize = true;
            this.lblPayRateError.ForeColor = System.Drawing.Color.Red;
            this.lblPayRateError.Location = new System.Drawing.Point(149, 120);
            this.lblPayRateError.Name = "lblPayRateError";
            this.lblPayRateError.Size = new System.Drawing.Size(155, 16);
            this.lblPayRateError.TabIndex = 11;
            this.lblPayRateError.Text = "Pay Rate cannot be zero";
            this.lblPayRateError.Visible = false;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(152, 218);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(449, 218);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // PayStubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblPayRateError);
            this.Controls.Add(this.lblAverageNetPay);
            this.Controls.Add(this.lblTotalNetPay);
            this.Controls.Add(this.lblTotalNumberOfPayStubs);
            this.Controls.Add(this.btnSummary);
            this.Controls.Add(this.lblNetPay);
            this.Controls.Add(this.btnPayStub);
            this.Controls.Add(this.nudPayRate);
            this.Controls.Add(this.nudHoursWorked);
            this.Controls.Add(this.lblPayRate);
            this.Controls.Add(this.lblHoursWorked);
            this.Controls.Add(this.tBoxName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PayStubForm";
            this.Text = "Pay Stub Form";
            ((System.ComponentModel.ISupportInitialize)(this.nudHoursWorked)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPayRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBoxName;
        private System.Windows.Forms.Label lblHoursWorked;
        private System.Windows.Forms.Label lblPayRate;
        private System.Windows.Forms.NumericUpDown nudHoursWorked;
        private System.Windows.Forms.NumericUpDown nudPayRate;
        private System.Windows.Forms.Button btnPayStub;
        private System.Windows.Forms.Label lblNetPay;
        private System.Windows.Forms.Button btnSummary;
        private System.Windows.Forms.Label lblTotalNumberOfPayStubs;
        private System.Windows.Forms.Label lblTotalNetPay;
        private System.Windows.Forms.Label lblAverageNetPay;
        private System.Windows.Forms.Label lblPayRateError;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
    }
}

