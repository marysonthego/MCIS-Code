namespace Module3
{
    partial class Module3Ex2
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
            this.grpFoodInfo = new System.Windows.Forms.GroupBox();
            this.lblCalories = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nudProtein = new System.Windows.Forms.NumericUpDown();
            this.nudCarbs = new System.Windows.Forms.NumericUpDown();
            this.nudFat = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpTriggers = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.grpFoodInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudProtein)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCarbs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFat)).BeginInit();
            this.grpTriggers.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpFoodInfo
            // 
            this.grpFoodInfo.Controls.Add(this.lblCalories);
            this.grpFoodInfo.Controls.Add(this.label6);
            this.grpFoodInfo.Controls.Add(this.txtFoodName);
            this.grpFoodInfo.Controls.Add(this.label4);
            this.grpFoodInfo.Controls.Add(this.nudProtein);
            this.grpFoodInfo.Controls.Add(this.nudCarbs);
            this.grpFoodInfo.Controls.Add(this.nudFat);
            this.grpFoodInfo.Controls.Add(this.label3);
            this.grpFoodInfo.Controls.Add(this.label2);
            this.grpFoodInfo.Controls.Add(this.label1);
            this.grpFoodInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpFoodInfo.Location = new System.Drawing.Point(15, 72);
            this.grpFoodInfo.Name = "grpFoodInfo";
            this.grpFoodInfo.Size = new System.Drawing.Size(458, 359);
            this.grpFoodInfo.TabIndex = 0;
            this.grpFoodInfo.TabStop = false;
            this.grpFoodInfo.Text = "Food Info:";
            // 
            // lblCalories
            // 
            this.lblCalories.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCalories.Location = new System.Drawing.Point(168, 294);
            this.lblCalories.Name = "lblCalories";
            this.lblCalories.Size = new System.Drawing.Size(137, 42);
            this.lblCalories.TabIndex = 12;
            this.lblCalories.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(10, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 42);
            this.label6.TabIndex = 11;
            this.label6.Text = "Calories";
            // 
            // txtFoodName
            // 
            this.txtFoodName.Location = new System.Drawing.Point(168, 60);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(284, 38);
            this.txtFoodName.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(10, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 42);
            this.label4.TabIndex = 9;
            this.label4.Text = "Name";
            // 
            // nudProtein
            // 
            this.nudProtein.Location = new System.Drawing.Point(168, 228);
            this.nudProtein.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudProtein.Name = "nudProtein";
            this.nudProtein.Size = new System.Drawing.Size(137, 38);
            this.nudProtein.TabIndex = 8;
            this.nudProtein.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudCarbs
            // 
            this.nudCarbs.Location = new System.Drawing.Point(168, 171);
            this.nudCarbs.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudCarbs.Name = "nudCarbs";
            this.nudCarbs.Size = new System.Drawing.Size(137, 38);
            this.nudCarbs.TabIndex = 7;
            this.nudCarbs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudFat
            // 
            this.nudFat.Location = new System.Drawing.Point(168, 119);
            this.nudFat.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudFat.Name = "nudFat";
            this.nudFat.Size = new System.Drawing.Size(137, 38);
            this.nudFat.TabIndex = 6;
            this.nudFat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(10, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 42);
            this.label3.TabIndex = 2;
            this.label3.Text = "Protein";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(10, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "Carbs";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(10, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fat";
            // 
            // grpTriggers
            // 
            this.grpTriggers.Controls.Add(this.btnExit);
            this.grpTriggers.Controls.Add(this.btnReset);
            this.grpTriggers.Controls.Add(this.btnCreate);
            this.grpTriggers.Location = new System.Drawing.Point(496, 132);
            this.grpTriggers.Name = "grpTriggers";
            this.grpTriggers.Size = new System.Drawing.Size(318, 160);
            this.grpTriggers.TabIndex = 1;
            this.grpTriggers.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(160, 91);
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
            this.btnReset.Location = new System.Drawing.Point(6, 91);
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
            this.btnCreate.Text = "&Create Food Object";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(281, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(256, 42);
            this.label5.TabIndex = 5;
            this.label5.Text = "Test Food2 Class";
            // 
            // Module3Ex2
            // 
            this.AcceptButton = this.btnCreate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(818, 439);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.grpTriggers);
            this.Controls.Add(this.grpFoodInfo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Module3Ex2";
            this.Text = "Module 3 - Example 2";
            this.grpFoodInfo.ResumeLayout(false);
            this.grpFoodInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudProtein)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCarbs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFat)).EndInit();
            this.grpTriggers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFoodInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpTriggers;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudProtein;
        private System.Windows.Forms.NumericUpDown nudCarbs;
        private System.Windows.Forms.NumericUpDown nudFat;
        private System.Windows.Forms.Label lblCalories;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.Label label4;
    }
}

