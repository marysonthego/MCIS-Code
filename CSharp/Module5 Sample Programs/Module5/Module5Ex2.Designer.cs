namespace Module5
{
    partial class Module5Ex2
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
            this.cboMWC = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.txtRemove = new System.Windows.Forms.TextBox();
            this.btnRemoveAlt = new System.Windows.Forms.Button();
            this.btnCount = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboMWC
            // 
            this.cboMWC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboMWC.FormattingEnabled = true;
            this.cboMWC.Items.AddRange(new object[] {
            "Air Force",
            "Boise State",
            "Colorado State",
            "Fresno State",
            "Hawaii",
            "Nevada",
            "New Mexico",
            "San Diego State",
            "San Jose State",
            "Unlv",
            "Utah State",
            "Wyoming"});
            this.cboMWC.Location = new System.Drawing.Point(12, 33);
            this.cboMWC.Name = "cboMWC";
            this.cboMWC.Size = new System.Drawing.Size(216, 383);
            this.cboMWC.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(252, 30);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(235, 36);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add New Member";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(252, 375);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(235, 36);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(252, 81);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(235, 36);
            this.btnInsert.TabIndex = 12;
            this.btnInsert.Text = "Insert New Member";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(252, 131);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(235, 36);
            this.btnRemove.TabIndex = 13;
            this.btnRemove.Text = "Remove Member";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // txtRemove
            // 
            this.txtRemove.Location = new System.Drawing.Point(252, 186);
            this.txtRemove.Name = "txtRemove";
            this.txtRemove.Size = new System.Drawing.Size(235, 31);
            this.txtRemove.TabIndex = 14;
            // 
            // btnRemoveAlt
            // 
            this.btnRemoveAlt.Location = new System.Drawing.Point(252, 235);
            this.btnRemoveAlt.Name = "btnRemoveAlt";
            this.btnRemoveAlt.Size = new System.Drawing.Size(235, 36);
            this.btnRemoveAlt.TabIndex = 15;
            this.btnRemoveAlt.Text = "Remove Member (alt)";
            this.btnRemoveAlt.UseVisualStyleBackColor = true;
            this.btnRemoveAlt.Click += new System.EventHandler(this.btnRemoveAlt_Click);
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(252, 287);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(235, 36);
            this.btnCount.TabIndex = 16;
            this.btnCount.Text = "How Many?";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(252, 333);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(235, 36);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Clear List";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Module5Ex2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 423);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.btnRemoveAlt);
            this.Controls.Add(this.txtRemove);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cboMWC);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Module5Ex2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Module 5 - Example 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboMWC;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox txtRemove;
        private System.Windows.Forms.Button btnRemoveAlt;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Button btnClear;
    }
}

