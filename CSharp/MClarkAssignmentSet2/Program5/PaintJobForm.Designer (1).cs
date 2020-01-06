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
            this.lblFootagePrompt = new System.Windows.Forms.Label();
            this.lblPaintCostPrompt = new System.Windows.Forms.Label();
            this.lblEstimate = new System.Windows.Forms.Label();
            this.maskedTextBoxSqFeet = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxCost = new System.Windows.Forms.MaskedTextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblDev = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFootagePrompt
            // 
            this.lblFootagePrompt.AutoSize = true;
            this.lblFootagePrompt.Location = new System.Drawing.Point(24, 47);
            this.lblFootagePrompt.Name = "lblFootagePrompt";
            this.lblFootagePrompt.Size = new System.Drawing.Size(257, 17);
            this.lblFootagePrompt.TabIndex = 0;
            this.lblFootagePrompt.Text = "Enter the approximate square footage to be painted:";
            // 
            // lblPaintCostPrompt
            // 
            this.lblPaintCostPrompt.AutoSize = true;
            this.lblPaintCostPrompt.Location = new System.Drawing.Point(24, 82);
            this.lblPaintCostPrompt.Name = "lblPaintCostPrompt";
            this.lblPaintCostPrompt.Size = new System.Drawing.Size(178, 17);
            this.lblPaintCostPrompt.TabIndex = 1;
            this.lblPaintCostPrompt.Text = "Enter the cost of one gallon of paint:";
            // 
            // lblEstimate
            // 
            this.lblEstimate.AutoSize = true;
            this.lblEstimate.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstimate.Location = new System.Drawing.Point(24, 112);
            this.lblEstimate.Name = "lblEstimate";
            this.lblEstimate.Size = new System.Drawing.Size(196, 21);
            this.lblEstimate.TabIndex = 2;
            this.lblEstimate.Text = "Estimated cost for this paint job:";
            // 
            // maskedTextBoxSqFeet
            // 
            this.maskedTextBoxSqFeet.AllowPromptAsInput = false;
            this.maskedTextBoxSqFeet.AsciiOnly = true;
            this.maskedTextBoxSqFeet.BackColor = System.Drawing.SystemColors.HighlightText;
            this.maskedTextBoxSqFeet.BeepOnError = true;
            this.maskedTextBoxSqFeet.HidePromptOnLeave = true;
            this.maskedTextBoxSqFeet.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.maskedTextBoxSqFeet.Location = new System.Drawing.Point(288, 47);
            this.maskedTextBoxSqFeet.Mask = "00000";
            this.maskedTextBoxSqFeet.Name = "maskedTextBoxSqFeet";
            this.maskedTextBoxSqFeet.PromptChar = '0';
            this.maskedTextBoxSqFeet.ResetOnPrompt = false;
            this.maskedTextBoxSqFeet.Size = new System.Drawing.Size(43, 22);
            this.maskedTextBoxSqFeet.TabIndex = 3;
            this.maskedTextBoxSqFeet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBoxSqFeet.ValidatingType = typeof(int);
            this.maskedTextBoxSqFeet.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxSqFeet_MaskInputRejected);
            // 
            // maskedTextBoxCost
            // 
            this.maskedTextBoxCost.AsciiOnly = true;
            this.maskedTextBoxCost.BackColor = System.Drawing.SystemColors.HighlightText;
            this.maskedTextBoxCost.BeepOnError = true;
            this.maskedTextBoxCost.Location = new System.Drawing.Point(288, 76);
            this.maskedTextBoxCost.Mask = "00.00";
            this.maskedTextBoxCost.Name = "maskedTextBoxCost";
            this.maskedTextBoxCost.PromptChar = '0';
            this.maskedTextBoxCost.Size = new System.Drawing.Size(43, 22);
            this.maskedTextBoxCost.TabIndex = 4;
            this.maskedTextBoxCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.maskedTextBoxCost.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxCost_MaskInputRejected);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(267, 112);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(64, 23);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "0000.00";
            this.lblResult.Click += new System.EventHandler(this.lblResult_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(28, 162);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(256, 210);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // lblDev
            // 
            this.lblDev.AutoSize = true;
            this.lblDev.Location = new System.Drawing.Point(28, 216);
            this.lblDev.Name = "lblDev";
            this.lblDev.Size = new System.Drawing.Size(126, 17);
            this.lblDev.TabIndex = 8;
            this.lblDev.Text = "Developed by Mary Clark";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(97, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(163, 26);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Paint Job Estimator";
            // 
            // PaintJobForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 247);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblDev);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.maskedTextBoxCost);
            this.Controls.Add(this.maskedTextBoxSqFeet);
            this.Controls.Add(this.lblEstimate);
            this.Controls.Add(this.lblPaintCostPrompt);
            this.Controls.Add(this.lblFootagePrompt);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PaintJobForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Paint Job Estimator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFootagePrompt;
        private System.Windows.Forms.Label lblPaintCostPrompt;
        private System.Windows.Forms.Label lblEstimate;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxSqFeet;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCost;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblDev;
        private System.Windows.Forms.Label lblTitle;
    }
}

