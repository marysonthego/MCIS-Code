namespace Module1
{
    partial class Module1Ex1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnWelcome = new System.Windows.Forms.Button();
            this.btnBye = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblGreeting = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(197, 29);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(337, 32);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // btnWelcome
            // 
            this.btnWelcome.Location = new System.Drawing.Point(197, 109);
            this.btnWelcome.Name = "btnWelcome";
            this.btnWelcome.Size = new System.Drawing.Size(154, 50);
            this.btnWelcome.TabIndex = 2;
            this.btnWelcome.Text = "Welcome";
            this.btnWelcome.UseVisualStyleBackColor = true;
            this.btnWelcome.Click += new System.EventHandler(this.btnWelcome_Click);
            // 
            // btnBye
            // 
            this.btnBye.Location = new System.Drawing.Point(380, 109);
            this.btnBye.Name = "btnBye";
            this.btnBye.Size = new System.Drawing.Size(154, 50);
            this.btnBye.TabIndex = 3;
            this.btnBye.Text = "Goodbye";
            this.btnBye.UseVisualStyleBackColor = true;
            this.btnBye.Click += new System.EventHandler(this.btnBye_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(284, 272);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(154, 50);
            this.button3.TabIndex = 4;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblGreeting
            // 
            this.lblGreeting.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGreeting.Location = new System.Drawing.Point(191, 198);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(343, 42);
            this.lblGreeting.TabIndex = 5;
            // 
            // Module1Ex1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 340);
            this.Controls.Add(this.lblGreeting);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnBye);
            this.Controls.Add(this.btnWelcome);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Module1Ex1";
            this.Text = "Module 1 - Example 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnWelcome;
        private System.Windows.Forms.Button btnBye;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblGreeting;
    }
}

