using System;

namespace Program5
{
    partial class PaintJobForm
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
            this.nudSqFeet = new System.Windows.Forms.NumericUpDown();
            this.nudPaintCost = new System.Windows.Forms.NumericUpDown();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnGetEstimate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblSqFeetPrompt = new System.Windows.Forms.Label();
            this.lblCostPrompt = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblDev = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudSqFeet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPaintCost)).BeginInit();
            this.SuspendLayout();
            // 
            // nudSqFeet
            // 
            this.nudSqFeet.Location = new System.Drawing.Point(225, 20);
            this.nudSqFeet.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudSqFeet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSqFeet.Name = "nudSqFeet";
            this.nudSqFeet.Size = new System.Drawing.Size(94, 29);
            this.nudSqFeet.TabIndex = 0;
            this.nudSqFeet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudSqFeet.ThousandsSeparator = true;
            this.nudSqFeet.Value = new decimal(new int[] {
            nudSqFeetDefault,
            0,
            0,
            0});
            // 
            // nudPaintCost
            // 
            this.nudPaintCost.DecimalPlaces = 2;
            this.nudPaintCost.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudPaintCost.Location = new System.Drawing.Point(225, 75);
            this.nudPaintCost.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPaintCost.Name = "nudPaintCost";
            this.nudPaintCost.Size = new System.Drawing.Size(94, 29);
            this.nudPaintCost.TabIndex = 1;
            this.nudPaintCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudPaintCost.ThousandsSeparator = true;
            this.nudPaintCost.Value = new decimal(new int[] {
            nudPaintCostDefault,
            0,
            0,
            0});
            // 
            // btnReset
            // 
            this.btnReset.AutoSize = true;
            this.btnReset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Location = new System.Drawing.Point(225, 125);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(58, 31);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnGetEstimate
            // 
            this.btnGetEstimate.AutoSize = true;
            this.btnGetEstimate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGetEstimate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGetEstimate.FlatAppearance.BorderSize = 3;
            this.btnGetEstimate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnGetEstimate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGetEstimate.Location = new System.Drawing.Point(340, 18);
            this.btnGetEstimate.Name = "btnGetEstimate";
            this.btnGetEstimate.Size = new System.Drawing.Size(107, 31);
            this.btnGetEstimate.TabIndex = 3;
            this.btnGetEstimate.Text = "Get Estimate";
            this.btnGetEstimate.UseVisualStyleBackColor = true;
            this.btnGetEstimate.Click += new System.EventHandler(this.btnGetEstimate_Click);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Location = new System.Drawing.Point(403, 125);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(44, 31);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblSqFeetPrompt
            // 
            this.lblSqFeetPrompt.AutoSize = true;
            this.lblSqFeetPrompt.Location = new System.Drawing.Point(0, 22);
            this.lblSqFeetPrompt.Name = "lblSqFeetPrompt";
            this.lblSqFeetPrompt.Size = new System.Drawing.Size(193, 21);
            this.lblSqFeetPrompt.TabIndex = 5;
            this.lblSqFeetPrompt.Text = "Select Square Feet to Paint";
            // 
            // lblCostPrompt
            // 
            this.lblCostPrompt.AutoSize = true;
            this.lblCostPrompt.Location = new System.Drawing.Point(0, 77);
            this.lblCostPrompt.Name = "lblCostPrompt";
            this.lblCostPrompt.Size = new System.Drawing.Size(200, 21);
            this.lblCostPrompt.TabIndex = 6;
            this.lblCostPrompt.Text = "Select Paint Cost per Gallon";
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblResult.Location = new System.Drawing.Point(349, 72);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(98, 31);
            this.lblResult.TabIndex = 7;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDev
            // 
            this.lblDev.AutoSize = true;
            this.lblDev.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDev.Location = new System.Drawing.Point(1, 133);
            this.lblDev.Name = "lblDev";
            this.lblDev.Size = new System.Drawing.Size(156, 17);
            this.lblDev.TabIndex = 8;
            this.lblDev.Text = "Developed by Mary Clark";
            this.lblDev.UseMnemonic = false;
            // 
            // PaintJobForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1200, 727);
            this.Controls.Add(this.lblDev);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblCostPrompt);
            this.Controls.Add(this.lblSqFeetPrompt);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGetEstimate);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.nudPaintCost);
            this.Controls.Add(this.nudSqFeet);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PaintJobForm";
            this.ShowInTaskbar = false;
            this.Text = "Paint Job Estimator";
            ((System.ComponentModel.ISupportInitialize)(this.nudSqFeet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPaintCost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudSqFeet;
        private System.Windows.Forms.NumericUpDown nudPaintCost;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnGetEstimate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblSqFeetPrompt;
        private System.Windows.Forms.Label lblCostPrompt;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblDev;
    }
}

