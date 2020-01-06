namespace Module9
{
    partial class Module9Ex2Summary
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
            this.grpFoodStats = new System.Windows.Forms.GroupBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalCalories = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.grpFoodStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpFoodStats
            // 
            this.grpFoodStats.Controls.Add(this.btnOK);
            this.grpFoodStats.Controls.Add(this.label2);
            this.grpFoodStats.Controls.Add(this.label1);
            this.grpFoodStats.Controls.Add(this.lblTotalCalories);
            this.grpFoodStats.Controls.Add(this.lblCount);
            this.grpFoodStats.Location = new System.Drawing.Point(12, 12);
            this.grpFoodStats.Name = "grpFoodStats";
            this.grpFoodStats.Size = new System.Drawing.Size(415, 197);
            this.grpFoodStats.TabIndex = 9;
            this.grpFoodStats.TabStop = false;
            this.grpFoodStats.Text = "Food Summary";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(313, 154);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(84, 33);
            this.btnOK.TabIndex = 21;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 29);
            this.label2.TabIndex = 20;
            this.label2.Text = "Total # of Calories";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 29);
            this.label1.TabIndex = 19;
            this.label1.Text = "Total # of Food Items";
            // 
            // lblTotalCalories
            // 
            this.lblTotalCalories.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalCalories.Location = new System.Drawing.Point(281, 100);
            this.lblTotalCalories.Name = "lblTotalCalories";
            this.lblTotalCalories.Size = new System.Drawing.Size(116, 39);
            this.lblTotalCalories.TabIndex = 18;
            this.lblTotalCalories.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCount
            // 
            this.lblCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCount.Location = new System.Drawing.Point(281, 46);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(116, 39);
            this.lblCount.TabIndex = 13;
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Module9Ex2Summary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 220);
            this.Controls.Add(this.grpFoodStats);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "Module9Ex2Summary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Module 9 - Example 2 (Summary Form)";
            this.grpFoodStats.ResumeLayout(false);
            this.grpFoodStats.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFoodStats;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label lblTotalCalories;
        internal System.Windows.Forms.Label lblCount;
    }
}