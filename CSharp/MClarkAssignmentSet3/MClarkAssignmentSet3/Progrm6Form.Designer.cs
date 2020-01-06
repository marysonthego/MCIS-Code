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
            this.SuspendLayout();
            // 
            // Program6Form
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "Program6Form";
            this.Load += new System.EventHandler(this.Program6Form_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.NumericUpDown nudSteps;
        private System.Windows.Forms.Label lblNudSteps;
        private System.Windows.Forms.NumericUpDown nudStepLength;
        private System.Windows.Forms.Label lblNudStepLength;
    }
}

