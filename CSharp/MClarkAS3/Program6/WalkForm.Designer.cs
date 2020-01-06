using System;

namespace Program6
{
    partial class WalkForm
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.lblSteps = new System.Windows.Forms.Label();
            this.lblStepLength = new System.Windows.Forms.Label();
            this.lblDev = new System.Windows.Forms.Label();
            this.nudSteps = new System.Windows.Forms.NumericUpDown();
            this.nudLength = new System.Windows.Forms.NumericUpDown();
            this.btnWalk = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudSteps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLength)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(13, 13);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(256, 22);
            this.textBoxName.TabIndex = 0;
            this.textBoxName.Text = "Enter your name here";
            // 
            // lblSteps
            // 
            this.lblSteps.AutoSize = true;
            this.lblSteps.Location = new System.Drawing.Point(13, 52);
            this.lblSteps.Name = "lblSteps";
            this.lblSteps.Size = new System.Drawing.Size(144, 16);
            this.lblSteps.TabIndex = 1;
            this.lblSteps.Text = "Select number of steps";
            // 
            // lblStepLength
            // 
            this.lblStepLength.AutoSize = true;
            this.lblStepLength.Location = new System.Drawing.Point(13, 85);
            this.lblStepLength.Name = "lblStepLength";
            this.lblStepLength.Size = new System.Drawing.Size(198, 16);
            this.lblStepLength.TabIndex = 2;
            this.lblStepLength.Text = "Select your step length in inches";
            // 
            // lblDev
            // 
            this.lblDev.AutoSize = true;
            this.lblDev.Location = new System.Drawing.Point(13, 223);
            this.lblDev.Name = "lblDev";
            this.lblDev.Size = new System.Drawing.Size(161, 16);
            this.lblDev.TabIndex = 3;
            this.lblDev.Text = "Developed by Mary Clark";
            // 
            // nudSteps
            // 
            this.nudSteps.Location = new System.Drawing.Point(177, 47);
            this.nudSteps.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudSteps.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSteps.Name = "nudSteps";
            this.nudSteps.Size = new System.Drawing.Size(120, 22);
            this.nudSteps.TabIndex = 4;
            this.nudSteps.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudSteps.ThousandsSeparator = true;
            this.nudSteps.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // nudLength
            // 
            this.nudLength.Location = new System.Drawing.Point(230, 80);
            this.nudLength.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.nudLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLength.Name = "nudLength";
            this.nudLength.Size = new System.Drawing.Size(67, 22);
            this.nudLength.TabIndex = 5;
            this.nudLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudLength.Value = new decimal(new int[] {
            36,
            0,
            0,
            0});
            // 
            // btnWalk
            // 
            this.btnWalk.Location = new System.Drawing.Point(51, 141);
            this.btnWalk.Name = "btnWalk";
            this.btnWalk.Size = new System.Drawing.Size(75, 23);
            this.btnWalk.TabIndex = 6;
            this.btnWalk.Text = "Walk!";
            this.btnWalk.UseVisualStyleBackColor = true;
            this.btnWalk.Click += new System.EventHandler(this.btnWalk_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(189, 141);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(327, 140);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResult.Location = new System.Drawing.Point(182, 185);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(88, 18);
            this.lblResult.TabIndex = 9;
            this.lblResult.Text = "Miles walked";
            // 
            // WalkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 256);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnWalk);
            this.Controls.Add(this.nudLength);
            this.Controls.Add(this.nudSteps);
            this.Controls.Add(this.lblDev);
            this.Controls.Add(this.lblStepLength);
            this.Controls.Add(this.lblSteps);
            this.Controls.Add(this.textBoxName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WalkForm";
            this.Text = "Program 6 - Walk";
            ((System.ComponentModel.ISupportInitialize)(this.nudSteps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label lblSteps;
        private System.Windows.Forms.Label lblStepLength;
        private System.Windows.Forms.Label lblDev;
        private System.Windows.Forms.NumericUpDown nudSteps;
        private System.Windows.Forms.NumericUpDown nudLength;
        private System.Windows.Forms.Button btnWalk;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblResult;
    }
}

