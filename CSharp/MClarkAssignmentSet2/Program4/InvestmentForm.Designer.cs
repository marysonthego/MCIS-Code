/*
 * Class Name: MClarkAssignmentSet2.Program4.InvestmentForm
 * Class Description: InvestmentForm is a Windows Form object.
 * This file is a continuation of the class definition of InvestmentForm started in InvestmentForm.cs.
 * The InvestmentForm InitializeComponent method creates an instance of InvestmentForm and the controls on the form.
 * Developer Name: Mary Clark
 * Date Created: 9/9/2018
 * Date Last Modified: 9/14/2018
 */
namespace Program4
{
    partial class InvestmentForm
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
            this.numUDPresentVal = new System.Windows.Forms.NumericUpDown();
            this.lblPresentValPrompt = new System.Windows.Forms.Label();
            this.numUDDuration = new System.Windows.Forms.NumericUpDown();
            this.lblDurationPrompt = new System.Windows.Forms.Label();
            this.numUDRate = new System.Windows.Forms.NumericUpDown();
            this.lblInterestRatePrompt = new System.Windows.Forms.Label();
            this.BtnFutureVal = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.lblDeveloper = new System.Windows.Forms.Label();
            this.lblFutureValResult = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numUDPresentVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDRate)).BeginInit();
            this.SuspendLayout();
            // 
            // numUDPresentVal
            // 
            this.numUDPresentVal.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUDPresentVal.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numUDPresentVal.Location = new System.Drawing.Point(198, 59);
            this.numUDPresentVal.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numUDPresentVal.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numUDPresentVal.Name = "numUDPresentVal";
            this.numUDPresentVal.Size = new System.Drawing.Size(120, 23);
            this.numUDPresentVal.TabIndex = 0;
            this.numUDPresentVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numUDPresentVal.ThousandsSeparator = true;
            this.numUDPresentVal.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // lblPresentValPrompt
            // 
            this.lblPresentValPrompt.AutoSize = true;
            this.lblPresentValPrompt.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresentValPrompt.Location = new System.Drawing.Point(37, 67);
            this.lblPresentValPrompt.Name = "lblPresentValPrompt";
            this.lblPresentValPrompt.Size = new System.Drawing.Size(137, 15);
            this.lblPresentValPrompt.TabIndex = 1;
            this.lblPresentValPrompt.Text = "Select Present Value";
            // 
            // numUDDuration
            // 
            this.numUDDuration.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUDDuration.Location = new System.Drawing.Point(198, 97);
            this.numUDDuration.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numUDDuration.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUDDuration.Name = "numUDDuration";
            this.numUDDuration.Size = new System.Drawing.Size(120, 23);
            this.numUDDuration.TabIndex = 2;
            this.numUDDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numUDDuration.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblDurationPrompt
            // 
            this.lblDurationPrompt.AutoSize = true;
            this.lblDurationPrompt.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDurationPrompt.Location = new System.Drawing.Point(37, 105);
            this.lblDurationPrompt.Name = "lblDurationPrompt";
            this.lblDurationPrompt.Size = new System.Drawing.Size(153, 15);
            this.lblDurationPrompt.TabIndex = 3;
            this.lblDurationPrompt.Text = "Select number of years\r\n";
            // 
            // numUDRate
            // 
            this.numUDRate.DecimalPlaces = 2;
            this.numUDRate.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUDRate.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.numUDRate.Location = new System.Drawing.Point(198, 135);
            this.numUDRate.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUDRate.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numUDRate.Name = "numUDRate";
            this.numUDRate.Size = new System.Drawing.Size(120, 23);
            this.numUDRate.TabIndex = 4;
            this.numUDRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numUDRate.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // lblInterestRatePrompt
            // 
            this.lblInterestRatePrompt.AutoSize = true;
            this.lblInterestRatePrompt.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterestRatePrompt.Location = new System.Drawing.Point(37, 143);
            this.lblInterestRatePrompt.Name = "lblInterestRatePrompt";
            this.lblInterestRatePrompt.Size = new System.Drawing.Size(132, 15);
            this.lblInterestRatePrompt.TabIndex = 5;
            this.lblInterestRatePrompt.Text = "Select Interest Rate";
            // 
            // BtnFutureVal
            // 
            this.BtnFutureVal.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnFutureVal.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFutureVal.Location = new System.Drawing.Point(243, 171);
            this.BtnFutureVal.Name = "BtnFutureVal";
            this.BtnFutureVal.Size = new System.Drawing.Size(75, 39);
            this.BtnFutureVal.TabIndex = 6;
            this.BtnFutureVal.Text = "Future Value";
            this.BtnFutureVal.UseVisualStyleBackColor = true;
            this.BtnFutureVal.Click += new System.EventHandler(this.BtnFutureVal_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReset.Location = new System.Drawing.Point(40, 236);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(75, 23);
            this.BtnReset.TabIndex = 7;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Location = new System.Drawing.Point(243, 236);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(75, 23);
            this.BtnExit.TabIndex = 8;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // lblDeveloper
            // 
            this.lblDeveloper.AutoSize = true;
            this.lblDeveloper.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeveloper.Location = new System.Drawing.Point(37, 285);
            this.lblDeveloper.Name = "lblDeveloper";
            this.lblDeveloper.Size = new System.Drawing.Size(143, 14);
            this.lblDeveloper.TabIndex = 9;
            this.lblDeveloper.Text = "Developed by Mary Clark";
            // 
            // lblFutureValResult
            // 
            this.lblFutureValResult.AutoSize = true;
            this.lblFutureValResult.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFutureValResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFutureValResult.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFutureValResult.Location = new System.Drawing.Point(105, 180);
            this.lblFutureValResult.MinimumSize = new System.Drawing.Size(120, 23);
            this.lblFutureValResult.Name = "lblFutureValResult";
            this.lblFutureValResult.Size = new System.Drawing.Size(120, 23);
            this.lblFutureValResult.TabIndex = 10;
            this.lblFutureValResult.Text = "             ";
            this.lblFutureValResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(64, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(219, 22);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "Calculate Future Value";
            // 
            // InvestmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 325);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblFutureValResult);
            this.Controls.Add(this.lblDeveloper);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnFutureVal);
            this.Controls.Add(this.lblInterestRatePrompt);
            this.Controls.Add(this.numUDRate);
            this.Controls.Add(this.lblDurationPrompt);
            this.Controls.Add(this.numUDDuration);
            this.Controls.Add(this.lblPresentValPrompt);
            this.Controls.Add(this.numUDPresentVal);
            this.Name = "InvestmentForm";
            this.Text = "Calculate the Future Value of an Investment";
            this.Load += new System.EventHandler(this.InvestmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUDPresentVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numUDPresentVal;
        private System.Windows.Forms.Label lblPresentValPrompt;
        private System.Windows.Forms.NumericUpDown numUDDuration;
        private System.Windows.Forms.Label lblDurationPrompt;
        private System.Windows.Forms.NumericUpDown numUDRate;
        private System.Windows.Forms.Label lblInterestRatePrompt;
        private System.Windows.Forms.Button BtnFutureVal;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label lblDeveloper;
        private System.Windows.Forms.Label lblFutureValResult;
        private System.Windows.Forms.Label lblTitle;
    }
}

