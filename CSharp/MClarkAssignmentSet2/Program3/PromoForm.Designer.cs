/*
 * Class Name: MClarkAssignmentSet2.Program3.PromoForm
 * Class Description: PromoForm is a Windows Form object which contains the following major components: 
 *   lblCoName - a label for displaying the company name.
 *   lblTagLine - a label for displaying the company's tag line.
 *   grpBoxColors - a mutually exclusive set of radio buttons (f/ex: radioBtnRed) users 
 *   select from to change the color of lblTagLine.
 *   picBoxLogo - a picture box for displaying the company's logo image
 *   A ToolTip is implemented for picBoxLogo which displays 'Our Logo'.
 *   grpBoxShowHide - contains checkboxes (f/ex: chkBoxLogo) allowing users to show
 *   or hide different components on the form. 
 *   lblDeveloper - a label for displaying the name of the developer.
 *   btnExit - a button implemented as the cancel button for the form. The instance of PromoForm is closed 
 *   when btnExit is clicked, or the ESC key on the keyboard is pressed.
 * Developer Name: Mary Clark
 * Date Created: 9/9/2018
 * Date Last Modified: 9/14/2018
 */
namespace Program3
{
 /*
  * The continuation of the PromoForm class declaration from the file
  * PromoForm.cs. 
  */
    partial class PromoForm
    {
        /*
         * Required designer variable.
         */
        private System.ComponentModel.IContainer components = null;

        /*
         * Clean up any resources being used.
         * <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
         */
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /* 
         * Instantiate an instance of the form and each of the
         * controls on it. Set all the properties that are not
         * the default value.
         */
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblCoName = new System.Windows.Forms.Label();
            this.picBoxLogo = new System.Windows.Forms.PictureBox();
            this.lblTagLine = new System.Windows.Forms.Label();
            this.grpBoxColors = new System.Windows.Forms.GroupBox();
            this.radioBtnOrange = new System.Windows.Forms.RadioButton();
            this.radioBtnBlue = new System.Windows.Forms.RadioButton();
            this.radioBtnGreen = new System.Windows.Forms.RadioButton();
            this.radioBtnRed = new System.Windows.Forms.RadioButton();
            this.lblDeveloper = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpBoxShowHide = new System.Windows.Forms.GroupBox();
            this.chkBoxDeveloper = new System.Windows.Forms.CheckBox();
            this.chkBoxLogo = new System.Windows.Forms.CheckBox();
            this.chkBoxTagline = new System.Windows.Forms.CheckBox();
            this.chkBoxName = new System.Windows.Forms.CheckBox();
            this.toolTip01 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
            this.grpBoxColors.SuspendLayout();
            this.grpBoxShowHide.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCoName
            // 
            this.lblCoName.AutoSize = true;
            this.lblCoName.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoName.Location = new System.Drawing.Point(162, 15);
            this.lblCoName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCoName.Name = "lblCoName";
            this.lblCoName.Size = new System.Drawing.Size(223, 34);
            this.lblCoName.TabIndex = 0;
            this.lblCoName.Text = "National Park Service";
            // 
            // picBoxLogo
            // 
            this.picBoxLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBoxLogo.Image = global::Program3.Properties.Resources.FindYourPark___Copy;
            this.picBoxLogo.Location = new System.Drawing.Point(168, 71);
            this.picBoxLogo.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.picBoxLogo.Name = "picBoxLogo";
            this.picBoxLogo.Size = new System.Drawing.Size(449, 299);
            this.picBoxLogo.TabIndex = 1;
            this.picBoxLogo.TabStop = false;
            this.toolTip01.SetToolTip(this.picBoxLogo, "Our logo");
            // 
            // lblTagLine
            // 
            this.lblTagLine.AutoSize = true;
            this.lblTagLine.Font = new System.Drawing.Font("Freestyle Script", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTagLine.ForeColor = System.Drawing.Color.Red;
            this.lblTagLine.Location = new System.Drawing.Point(433, 9);
            this.lblTagLine.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTagLine.Name = "lblTagLine";
            this.lblTagLine.Size = new System.Drawing.Size(187, 44);
            this.lblTagLine.TabIndex = 0;
            this.lblTagLine.Text = "Find Your Park";
            // 
            // grpBoxColors
            // 
            this.grpBoxColors.Controls.Add(this.radioBtnOrange);
            this.grpBoxColors.Controls.Add(this.radioBtnBlue);
            this.grpBoxColors.Controls.Add(this.radioBtnGreen);
            this.grpBoxColors.Controls.Add(this.radioBtnRed);
            this.grpBoxColors.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxColors.Location = new System.Drawing.Point(12, 71);
            this.grpBoxColors.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.grpBoxColors.Name = "grpBoxColors";
            this.grpBoxColors.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.grpBoxColors.Size = new System.Drawing.Size(97, 208);
            this.grpBoxColors.TabIndex = 0;
            this.grpBoxColors.TabStop = false;
            this.grpBoxColors.Text = "Pick Color";
            // 
            // radioBtnOrange
            // 
            this.radioBtnOrange.AutoSize = true;
            this.radioBtnOrange.Location = new System.Drawing.Point(6, 118);
            this.radioBtnOrange.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.radioBtnOrange.Name = "radioBtnOrange";
            this.radioBtnOrange.Size = new System.Drawing.Size(69, 25);
            this.radioBtnOrange.TabIndex = 3;
            this.radioBtnOrange.Text = "&Orange";
            this.radioBtnOrange.UseVisualStyleBackColor = true;
            this.radioBtnOrange.CheckedChanged += new System.EventHandler(this.RadioBtnOrange_CheckedChanged);
            // 
            // radioBtnBlue
            // 
            this.radioBtnBlue.AutoSize = true;
            this.radioBtnBlue.Location = new System.Drawing.Point(6, 87);
            this.radioBtnBlue.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.radioBtnBlue.Name = "radioBtnBlue";
            this.radioBtnBlue.Size = new System.Drawing.Size(55, 25);
            this.radioBtnBlue.TabIndex = 2;
            this.radioBtnBlue.Text = "&Blue";
            this.radioBtnBlue.UseVisualStyleBackColor = true;
            this.radioBtnBlue.CheckedChanged += new System.EventHandler(this.RadioBtnBlue_CheckedChanged);
            // 
            // radioBtnGreen
            // 
            this.radioBtnGreen.AutoSize = true;
            this.radioBtnGreen.Location = new System.Drawing.Point(6, 56);
            this.radioBtnGreen.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.radioBtnGreen.Name = "radioBtnGreen";
            this.radioBtnGreen.Size = new System.Drawing.Size(62, 25);
            this.radioBtnGreen.TabIndex = 1;
            this.radioBtnGreen.Text = "&Green";
            this.radioBtnGreen.UseVisualStyleBackColor = true;
            this.radioBtnGreen.CheckedChanged += new System.EventHandler(this.RadioBtnGreen_CheckedChanged);
            // 
            // radioBtnRed
            // 
            this.radioBtnRed.AutoSize = true;
            this.radioBtnRed.Checked = true;
            this.radioBtnRed.Location = new System.Drawing.Point(6, 25);
            this.radioBtnRed.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.radioBtnRed.Name = "radioBtnRed";
            this.radioBtnRed.Size = new System.Drawing.Size(51, 25);
            this.radioBtnRed.TabIndex = 0;
            this.radioBtnRed.TabStop = true;
            this.radioBtnRed.Text = "&Red";
            this.radioBtnRed.UseVisualStyleBackColor = true;
            this.radioBtnRed.CheckedChanged += new System.EventHandler(this.RadioBtnRed_CheckedChanged);
            // 
            // lblDeveloper
            // 
            this.lblDeveloper.AutoSize = true;
            this.lblDeveloper.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeveloper.Location = new System.Drawing.Point(32, 424);
            this.lblDeveloper.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDeveloper.Name = "lblDeveloper";
            this.lblDeveloper.Size = new System.Drawing.Size(154, 21);
            this.lblDeveloper.TabIndex = 4;
            this.lblDeveloper.Text = "&Developed by Mary Clark";
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(673, 409);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(74, 35);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // grpBoxShowHide
            // 
            this.grpBoxShowHide.Controls.Add(this.chkBoxDeveloper);
            this.grpBoxShowHide.Controls.Add(this.chkBoxLogo);
            this.grpBoxShowHide.Controls.Add(this.chkBoxTagline);
            this.grpBoxShowHide.Controls.Add(this.chkBoxName);
            this.grpBoxShowHide.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxShowHide.Location = new System.Drawing.Point(665, 71);
            this.grpBoxShowHide.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.grpBoxShowHide.Name = "grpBoxShowHide";
            this.grpBoxShowHide.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.grpBoxShowHide.Size = new System.Drawing.Size(107, 208);
            this.grpBoxShowHide.TabIndex = 1;
            this.grpBoxShowHide.TabStop = false;
            this.grpBoxShowHide.Text = "Show/Hide";
            // 
            // chkBoxDeveloper
            // 
            this.chkBoxDeveloper.AutoSize = true;
            this.chkBoxDeveloper.Checked = true;
            this.chkBoxDeveloper.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBoxDeveloper.Location = new System.Drawing.Point(8, 118);
            this.chkBoxDeveloper.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.chkBoxDeveloper.Name = "chkBoxDeveloper";
            this.chkBoxDeveloper.Size = new System.Drawing.Size(88, 25);
            this.chkBoxDeveloper.TabIndex = 3;
            this.chkBoxDeveloper.Text = "&Developer";
            this.chkBoxDeveloper.UseVisualStyleBackColor = true;
            this.chkBoxDeveloper.CheckedChanged += new System.EventHandler(this.ChkBoxDeveloper_CheckedChanged);
            // 
            // chkBoxLogo
            // 
            this.chkBoxLogo.AutoSize = true;
            this.chkBoxLogo.Checked = true;
            this.chkBoxLogo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBoxLogo.Location = new System.Drawing.Point(8, 87);
            this.chkBoxLogo.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.chkBoxLogo.Name = "chkBoxLogo";
            this.chkBoxLogo.Size = new System.Drawing.Size(57, 25);
            this.chkBoxLogo.TabIndex = 2;
            this.chkBoxLogo.Text = "&Logo";
            this.chkBoxLogo.UseVisualStyleBackColor = true;
            this.chkBoxLogo.CheckedChanged += new System.EventHandler(this.ChkBoxLogo_CheckedChanged);
            // 
            // chkBoxTagline
            // 
            this.chkBoxTagline.AutoSize = true;
            this.chkBoxTagline.Checked = true;
            this.chkBoxTagline.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBoxTagline.Location = new System.Drawing.Point(8, 56);
            this.chkBoxTagline.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.chkBoxTagline.Name = "chkBoxTagline";
            this.chkBoxTagline.Size = new System.Drawing.Size(71, 25);
            this.chkBoxTagline.TabIndex = 1;
            this.chkBoxTagline.Text = "&Tagline";
            this.chkBoxTagline.UseVisualStyleBackColor = true;
            this.chkBoxTagline.CheckedChanged += new System.EventHandler(this.ChkBoxTagline_CheckedChanged);
            // 
            // chkBoxName
            // 
            this.chkBoxName.AutoSize = true;
            this.chkBoxName.Checked = true;
            this.chkBoxName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBoxName.Location = new System.Drawing.Point(8, 25);
            this.chkBoxName.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.chkBoxName.Name = "chkBoxName";
            this.chkBoxName.Size = new System.Drawing.Size(63, 25);
            this.chkBoxName.TabIndex = 0;
            this.chkBoxName.Text = "&Name";
            this.chkBoxName.UseVisualStyleBackColor = true;
            this.chkBoxName.CheckedChanged += new System.EventHandler(this.ChkBoxName_CheckedChanged);
            this.chkBoxName.Click += new System.EventHandler(this.ChkBoxName_CheckedChanged);
            // 
            // toolTip01
            // 
            this.toolTip01.AutoPopDelay = 10000;
            this.toolTip01.InitialDelay = 500;
            this.toolTip01.IsBalloon = true;
            this.toolTip01.ReshowDelay = 100;
            // 
            // PromoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.grpBoxShowHide);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblDeveloper);
            this.Controls.Add(this.grpBoxColors);
            this.Controls.Add(this.lblTagLine);
            this.Controls.Add(this.picBoxLogo);
            this.Controls.Add(this.lblCoName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "PromoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "National Park Service - Find Your Park";
            this.Load += new System.EventHandler(this.PromoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
            this.grpBoxColors.ResumeLayout(false);
            this.grpBoxColors.PerformLayout();
            this.grpBoxShowHide.ResumeLayout(false);
            this.grpBoxShowHide.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCoName;
        private System.Windows.Forms.PictureBox picBoxLogo;
        private System.Windows.Forms.Label lblTagLine;
        private System.Windows.Forms.GroupBox grpBoxColors;
        private System.Windows.Forms.RadioButton radioBtnOrange;
        private System.Windows.Forms.RadioButton radioBtnBlue;
        private System.Windows.Forms.RadioButton radioBtnGreen;
        private System.Windows.Forms.RadioButton radioBtnRed;
        private System.Windows.Forms.Label lblDeveloper;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grpBoxShowHide;
        private System.Windows.Forms.CheckBox chkBoxDeveloper;
        private System.Windows.Forms.CheckBox chkBoxLogo;
        private System.Windows.Forms.CheckBox chkBoxTagline;
        private System.Windows.Forms.CheckBox chkBoxName;
        private System.Windows.Forms.ToolTip toolTip01;
    }
}

