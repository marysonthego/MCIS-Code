namespace Module3Addendum
{
    partial class Module3Ex4
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
            this.nudProtein = new System.Windows.Forms.NumericUpDown();
            this.nudCarbs = new System.Windows.Forms.NumericUpDown();
            this.nudFat = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpTriggers = new System.Windows.Forms.GroupBox();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnInfo = new System.Windows.Forms.Button();
            this.grpInputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudProtein)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCarbs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFat)).BeginInit();
            this.grpTriggers.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInputs
            // 
            this.grpInputs.Controls.Add(this.nudProtein);
            this.grpInputs.Controls.Add(this.nudCarbs);
            this.grpInputs.Controls.Add(this.nudFat);
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
            // nudProtein
            // 
            this.nudProtein.Location = new System.Drawing.Point(164, 169);
            this.nudProtein.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudProtein.Name = "nudProtein";
            this.nudProtein.Size = new System.Drawing.Size(137, 32);
            this.nudProtein.TabIndex = 8;
            this.nudProtein.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudCarbs
            // 
            this.nudCarbs.Location = new System.Drawing.Point(164, 112);
            this.nudCarbs.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudCarbs.Name = "nudCarbs";
            this.nudCarbs.Size = new System.Drawing.Size(137, 32);
            this.nudCarbs.TabIndex = 7;
            this.nudCarbs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudFat
            // 
            this.nudFat.Location = new System.Drawing.Point(164, 60);
            this.nudFat.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudFat.Name = "nudFat";
            this.nudFat.Size = new System.Drawing.Size(137, 32);
            this.nudFat.TabIndex = 6;
            this.nudFat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 42);
            this.label3.TabIndex = 2;
            this.label3.Text = "Protein";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "Carbs";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fat";
            // 
            // grpTriggers
            // 
            this.grpTriggers.Controls.Add(this.btnInfo);
            this.grpTriggers.Controls.Add(this.btnDisplay);
            this.grpTriggers.Controls.Add(this.btnExit);
            this.grpTriggers.Controls.Add(this.btnReset);
            this.grpTriggers.Location = new System.Drawing.Point(385, 99);
            this.grpTriggers.Name = "grpTriggers";
            this.grpTriggers.Size = new System.Drawing.Size(318, 189);
            this.grpTriggers.TabIndex = 1;
            this.grpTriggers.TabStop = false;
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(6, 33);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(299, 45);
            this.btnDisplay.TabIndex = 3;
            this.btnDisplay.Text = "&Display Total Calories";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(157, 144);
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
            this.btnReset.Location = new System.Drawing.Point(3, 144);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(148, 45);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(254, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(282, 42);
            this.label5.TabIndex = 5;
            this.label5.Text = "Test Food4 Class";
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(6, 88);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(299, 45);
            this.btnInfo.TabIndex = 4;
            this.btnInfo.Text = "&Show Calories Per Gram";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // Module3Ex4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(724, 322);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.grpTriggers);
            this.Controls.Add(this.grpInputs);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Module3Ex4";
            this.Text = "Module 3 - Example 4";
            this.grpInputs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudProtein)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCarbs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFat)).EndInit();
            this.grpTriggers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInputs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpTriggers;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudProtein;
        private System.Windows.Forms.NumericUpDown nudCarbs;
        private System.Windows.Forms.NumericUpDown nudFat;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnInfo;
    }
}

