namespace Module2
{
    partial class Module2Ex1
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
            this.grpInputs = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFat = new System.Windows.Forms.TextBox();
            this.txtCarbs = new System.Windows.Forms.TextBox();
            this.txtProtein = new System.Windows.Forms.TextBox();
            this.grpTriggers = new System.Windows.Forms.GroupBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.LblCalories = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grpInputs.SuspendLayout();
            this.grpTriggers.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInputs
            // 
            this.grpInputs.Controls.Add(this.txtProtein);
            this.grpInputs.Controls.Add(this.txtCarbs);
            this.grpInputs.Controls.Add(this.txtFat);
            this.grpInputs.Controls.Add(this.label3);
            this.grpInputs.Controls.Add(this.label2);
            this.grpInputs.Controls.Add(this.label1);
            this.grpInputs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpInputs.Location = new System.Drawing.Point(15, 72);
            this.grpInputs.Name = "grpInputs";
            this.grpInputs.Size = new System.Drawing.Size(333, 235);
            this.grpInputs.TabIndex = 0;
            this.grpInputs.TabStop = false;
            this.grpInputs.Text = "Nutrients (in grams):";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fat";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "Carbs";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 42);
            this.label3.TabIndex = 2;
            this.label3.Text = "Protein";
            // 
            // txtFat
            // 
            this.txtFat.Location = new System.Drawing.Point(163, 57);
            this.txtFat.Name = "txtFat";
            this.txtFat.Size = new System.Drawing.Size(138, 38);
            this.txtFat.TabIndex = 3;
            this.txtFat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCarbs
            // 
            this.txtCarbs.Location = new System.Drawing.Point(163, 114);
            this.txtCarbs.Name = "txtCarbs";
            this.txtCarbs.Size = new System.Drawing.Size(138, 38);
            this.txtCarbs.TabIndex = 4;
            this.txtCarbs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtProtein
            // 
            this.txtProtein.Location = new System.Drawing.Point(163, 171);
            this.txtProtein.Name = "txtProtein";
            this.txtProtein.Size = new System.Drawing.Size(138, 38);
            this.txtProtein.TabIndex = 5;
            this.txtProtein.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // grpTriggers
            // 
            this.grpTriggers.Controls.Add(this.btnExit);
            this.grpTriggers.Controls.Add(this.btnReset);
            this.grpTriggers.Controls.Add(this.btnCalculate);
            this.grpTriggers.Location = new System.Drawing.Point(385, 99);
            this.grpTriggers.Name = "grpTriggers";
            this.grpTriggers.Size = new System.Drawing.Size(175, 189);
            this.grpTriggers.TabIndex = 1;
            this.grpTriggers.TabStop = false;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(6, 30);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(148, 45);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(6, 85);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(148, 45);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(6, 137);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(148, 45);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(165, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 42);
            this.label4.TabIndex = 3;
            this.label4.Text = "Calories";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblCalories
            // 
            this.LblCalories.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblCalories.Location = new System.Drawing.Point(385, 321);
            this.LblCalories.Name = "LblCalories";
            this.LblCalories.Size = new System.Drawing.Size(151, 42);
            this.LblCalories.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(191, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(282, 42);
            this.label5.TabIndex = 5;
            this.label5.Text = "Calories Calculator";
            // 
            // Module2Ex1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 379);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LblCalories);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grpTriggers);
            this.Controls.Add(this.grpInputs);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Module2Ex1";
            this.Text = "Module 2 - Example 1";
            this.grpInputs.ResumeLayout(false);
            this.grpInputs.PerformLayout();
            this.grpTriggers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInputs;
        private System.Windows.Forms.TextBox txtProtein;
        private System.Windows.Forms.TextBox txtCarbs;
        private System.Windows.Forms.TextBox txtFat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpTriggers;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblCalories;
        private System.Windows.Forms.Label label5;
    }
}

