/*
 * Class Name: MClarkAS4.Program10.PropertyTaxForm
 * Class Description: Form for Property Taxes. 
 * There is no default Constructor.
 * Developer Name: Mary Clark
 * Date Created: 10/14/2018
 * Date Last Modified: 10/14/2018
 */

namespace MClarkProgram10
{
    partial class PropertyTaxForm
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
            this.lblOwnerPrompt = new System.Windows.Forms.Label();
            this.lblOwnerName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudBldgFeet = new System.Windows.Forms.NumericUpDown();
            this.nudLandFeet = new System.Windows.Forms.NumericUpDown();
            this.lblYearPrompt = new System.Windows.Forms.Label();
            this.nudYearBuilt = new System.Windows.Forms.NumericUpDown();
            this.lblLocationPrompt = new System.Windows.Forms.Label();
            this.lBoxLocationValue = new System.Windows.Forms.ListBox();
            this.lblBldgTax = new System.Windows.Forms.Label();
            this.lblBldgTaxValue = new System.Windows.Forms.Label();
            this.lblLandTaxPrompt = new System.Windows.Forms.Label();
            this.lblLandTaxValue = new System.Windows.Forms.Label();
            this.lblDev = new System.Windows.Forms.Label();
            this.btnCreateTax = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudBldgFeet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLandFeet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYearBuilt)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOwnerPrompt
            // 
            this.lblOwnerPrompt.AutoSize = true;
            this.lblOwnerPrompt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOwnerPrompt.Location = new System.Drawing.Point(12, 10);
            this.lblOwnerPrompt.Name = "lblOwnerPrompt";
            this.lblOwnerPrompt.Size = new System.Drawing.Size(82, 15);
            this.lblOwnerPrompt.TabIndex = 0;
            this.lblOwnerPrompt.Text = "Property Owner";
            // 
            // lblOwnerName
            // 
            this.lblOwnerName.AutoSize = true;
            this.lblOwnerName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOwnerName.Location = new System.Drawing.Point(146, 10);
            this.lblOwnerName.MinimumSize = new System.Drawing.Size(150, 20);
            this.lblOwnerName.Name = "lblOwnerName";
            this.lblOwnerName.Size = new System.Drawing.Size(150, 20);
            this.lblOwnerName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Building Sq Feet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Land Sq Feet";
            // 
            // nudBldgFeet
            // 
            this.nudBldgFeet.Location = new System.Drawing.Point(146, 40);
            this.nudBldgFeet.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudBldgFeet.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudBldgFeet.Name = "nudBldgFeet";
            this.nudBldgFeet.Size = new System.Drawing.Size(120, 20);
            this.nudBldgFeet.TabIndex = 5;
            this.nudBldgFeet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudBldgFeet.ThousandsSeparator = true;
            this.nudBldgFeet.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // nudLandFeet
            // 
            this.nudLandFeet.Location = new System.Drawing.Point(146, 81);
            this.nudLandFeet.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudLandFeet.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudLandFeet.Name = "nudLandFeet";
            this.nudLandFeet.Size = new System.Drawing.Size(120, 20);
            this.nudLandFeet.TabIndex = 6;
            this.nudLandFeet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudLandFeet.ThousandsSeparator = true;
            this.nudLandFeet.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // lblYearPrompt
            // 
            this.lblYearPrompt.AutoSize = true;
            this.lblYearPrompt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblYearPrompt.Location = new System.Drawing.Point(12, 119);
            this.lblYearPrompt.Name = "lblYearPrompt";
            this.lblYearPrompt.Size = new System.Drawing.Size(54, 15);
            this.lblYearPrompt.TabIndex = 7;
            this.lblYearPrompt.Text = "Year Built";
            // 
            // nudYearBuilt
            // 
            this.nudYearBuilt.Location = new System.Drawing.Point(146, 113);
            this.nudYearBuilt.Maximum = new decimal(new int[] {
            2018,
            0,
            0,
            0});
            this.nudYearBuilt.Minimum = new decimal(new int[] {
            1800,
            0,
            0,
            0});
            this.nudYearBuilt.Name = "nudYearBuilt";
            this.nudYearBuilt.Size = new System.Drawing.Size(120, 20);
            this.nudYearBuilt.TabIndex = 8;
            this.nudYearBuilt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudYearBuilt.Value = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            // 
            // lblLocationPrompt
            // 
            this.lblLocationPrompt.AutoSize = true;
            this.lblLocationPrompt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLocationPrompt.Location = new System.Drawing.Point(12, 165);
            this.lblLocationPrompt.Name = "lblLocationPrompt";
            this.lblLocationPrompt.Size = new System.Drawing.Size(50, 15);
            this.lblLocationPrompt.TabIndex = 9;
            this.lblLocationPrompt.Text = "Location";
            // 
            // lBoxLocationValue
            // 
            this.lBoxLocationValue.Items.AddRange(new object[] {
            "Urban",
            "Suburban",
            "Rural"});
            this.lBoxLocationValue.Location = new System.Drawing.Point(146, 154);
            this.lBoxLocationValue.Name = "lBoxLocationValue";
            this.lBoxLocationValue.Size = new System.Drawing.Size(120, 43);
            this.lBoxLocationValue.TabIndex = 10;
            // 
            // lblBldgTax
            // 
            this.lblBldgTax.AutoSize = true;
            this.lblBldgTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBldgTax.Location = new System.Drawing.Point(424, 13);
            this.lblBldgTax.Name = "lblBldgTax";
            this.lblBldgTax.Size = new System.Drawing.Size(70, 15);
            this.lblBldgTax.TabIndex = 11;
            this.lblBldgTax.Text = "Building Tax:";
            // 
            // lblBldgTaxValue
            // 
            this.lblBldgTaxValue.AutoSize = true;
            this.lblBldgTaxValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBldgTaxValue.Location = new System.Drawing.Point(534, 13);
            this.lblBldgTaxValue.Name = "lblBldgTaxValue";
            this.lblBldgTaxValue.Size = new System.Drawing.Size(63, 15);
            this.lblBldgTaxValue.TabIndex = 12;
            this.lblBldgTaxValue.Text = "$00,000.00";
            // 
            // lblLandTaxPrompt
            // 
            this.lblLandTaxPrompt.AutoSize = true;
            this.lblLandTaxPrompt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLandTaxPrompt.Location = new System.Drawing.Point(424, 46);
            this.lblLandTaxPrompt.Name = "lblLandTaxPrompt";
            this.lblLandTaxPrompt.Size = new System.Drawing.Size(57, 15);
            this.lblLandTaxPrompt.TabIndex = 13;
            this.lblLandTaxPrompt.Text = "Land Tax:";
            // 
            // lblLandTaxValue
            // 
            this.lblLandTaxValue.AutoSize = true;
            this.lblLandTaxValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLandTaxValue.Location = new System.Drawing.Point(534, 46);
            this.lblLandTaxValue.Name = "lblLandTaxValue";
            this.lblLandTaxValue.Size = new System.Drawing.Size(63, 15);
            this.lblLandTaxValue.TabIndex = 14;
            this.lblLandTaxValue.Text = "$00,000.00";
            // 
            // lblDev
            // 
            this.lblDev.AutoSize = true;
            this.lblDev.Location = new System.Drawing.Point(12, 425);
            this.lblDev.Name = "lblDev";
            this.lblDev.Size = new System.Drawing.Size(126, 13);
            this.lblDev.TabIndex = 15;
            this.lblDev.Text = "Developed by Mary Clark";
            // 
            // btnCreateTax
            // 
            this.btnCreateTax.Location = new System.Drawing.Point(424, 77);
            this.btnCreateTax.Name = "btnCreateTax";
            this.btnCreateTax.Size = new System.Drawing.Size(75, 23);
            this.btnCreateTax.TabIndex = 16;
            this.btnCreateTax.Text = "Create Tax";
            this.btnCreateTax.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(424, 415);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(534, 415);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // PropertyTaxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCreateTax);
            this.Controls.Add(this.lblDev);
            this.Controls.Add(this.lblLandTaxValue);
            this.Controls.Add(this.lblLandTaxPrompt);
            this.Controls.Add(this.lblBldgTaxValue);
            this.Controls.Add(this.lblBldgTax);
            this.Controls.Add(this.lBoxLocationValue);
            this.Controls.Add(this.lblLocationPrompt);
            this.Controls.Add(this.nudYearBuilt);
            this.Controls.Add(this.lblYearPrompt);
            this.Controls.Add(this.nudLandFeet);
            this.Controls.Add(this.nudBldgFeet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblOwnerName);
            this.Controls.Add(this.lblOwnerPrompt);
            this.Name = "PropertyTaxForm";
            this.Text = "Property Tax";
            this.Load += new System.EventHandler(this.PropertyTaxForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudBldgFeet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLandFeet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYearBuilt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOwnerPrompt;
        private System.Windows.Forms.Label lblOwnerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudBldgFeet;
        private System.Windows.Forms.NumericUpDown nudLandFeet;
        private System.Windows.Forms.Label lblYearPrompt;
        private System.Windows.Forms.NumericUpDown nudYearBuilt;
        private System.Windows.Forms.Label lblLocationPrompt;
        private System.Windows.Forms.ListBox lBoxLocationValue;
        private System.Windows.Forms.Label lblBldgTax;
        private System.Windows.Forms.Label lblBldgTaxValue;
        private System.Windows.Forms.Label lblLandTaxPrompt;
        private System.Windows.Forms.Label lblLandTaxValue;
        private System.Windows.Forms.Label lblDev;
        private System.Windows.Forms.Button btnCreateTax;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

