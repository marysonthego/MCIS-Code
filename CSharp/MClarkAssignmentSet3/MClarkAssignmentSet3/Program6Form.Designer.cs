namespace MClarkAssignmentSet3
{
    partial class Program6Form
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
            this.lblSteps = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.nudSteps = new System.Windows.Forms.NumericUpDown();
            this.nudStepLength = new System.Windows.Forms.NumericUpDown();
            this.lblStepLength = new System.Windows.Forms.Label();
            this.btnWalk = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblDev = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudSteps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStepLength)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSteps
            // 
            this.lblSteps.AutoSize = true;
            this.lblSteps.Location = new System.Drawing.Point(12, 50);
            this.lblSteps.Name = "lblSteps";
            this.lblSteps.Size = new System.Drawing.Size(190, 16);
            this.lblSteps.TabIndex = 0;
            this.lblSteps.Text = "How many steps did you take?";
            this.lblSteps.Click += new System.EventHandler(this.label1__Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(13, 13);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(189, 22);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.Text = "Enter your name";
            // 
            // nudSteps
            // 
            this.nudSteps.Location = new System.Drawing.Point(255, 48);
            this.nudSteps.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudSteps.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSteps.Name = "nudSteps";
            this.nudSteps.Size = new System.Drawing.Size(100, 22);
            this.nudSteps.TabIndex = 2;
            this.nudSteps.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudSteps.ThousandsSeparator = true;
            this.nudSteps.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // nudStepLength
            // 
            this.nudStepLength.Location = new System.Drawing.Point(288, 89);
            this.nudStepLength.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.nudStepLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudStepLength.Name = "nudStepLength";
            this.nudStepLength.Size = new System.Drawing.Size(64, 22);
            this.nudStepLength.TabIndex = 3;
            this.nudStepLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudStepLength.Value = new decimal(new int[] {
            36,
            0,
            0,
            0});
            // 
            // lblStepLength
            // 
            this.lblStepLength.AutoSize = true;
            this.lblStepLength.Location = new System.Drawing.Point(12, 91);
            this.lblStepLength.Name = "lblStepLength";
            this.lblStepLength.Size = new System.Drawing.Size(265, 16);
            this.lblStepLength.TabIndex = 4;
            this.lblStepLength.Text = "What is your average step length in inches?";
            this.lblStepLength.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btnWalk
            // 
            this.btnWalk.Location = new System.Drawing.Point(37, 157);
            this.btnWalk.Name = "btnWalk";
            this.btnWalk.Size = new System.Drawing.Size(75, 23);
            this.btnWalk.TabIndex = 5;
            this.btnWalk.Text = "Walk!";
            this.btnWalk.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(169, 157);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(301, 157);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(186, 221);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(43, 16);
            this.lblResult.TabIndex = 8;
            this.lblResult.Text = " Miles";
            // 
            // lblDev
            // 
            this.lblDev.AutoSize = true;
            this.lblDev.Location = new System.Drawing.Point(12, 252);
            this.lblDev.Name = "lblDev";
            this.lblDev.Size = new System.Drawing.Size(161, 16);
            this.lblDev.TabIndex = 9;
            this.lblDev.Text = "Developed by Mary Clark";
            // 
            // Program6Form
            // 
            this.AcceptButton = this.btnWalk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(415, 277);
            this.Controls.Add(this.lblDev);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnWalk);
            this.Controls.Add(this.lblStepLength);
            this.Controls.Add(this.nudStepLength);
            this.Controls.Add(this.nudSteps);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.lblSteps);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WalkForm";
            this.Text = "How far did you walk?";
            ((System.ComponentModel.ISupportInitialize)(this.nudSteps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStepLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSteps;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.NumericUpDown nudSteps;
        private System.Windows.Forms.NumericUpDown nudStepLength;
        private System.Windows.Forms.Label lblStepLength;
        private System.Windows.Forms.Button btnWalk;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblDev;
    }
}