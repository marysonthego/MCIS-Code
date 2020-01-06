
namespace MClarkProgram9
{
    partial class CateringEventForm
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
            this.lblEventName = new System.Windows.Forms.Label();
            this.tBoxEventName = new System.Windows.Forms.TextBox();
            this.lblGuests = new System.Windows.Forms.Label();
            this.nudNumberOfGuests = new System.Windows.Forms.NumericUpDown();
            this.gBoxEntre = new System.Windows.Forms.GroupBox();
            this.rBtnGardenL = new System.Windows.Forms.RadioButton();
            this.rBtnChickenM = new System.Windows.Forms.RadioButton();
            this.rBtnPrimeRib = new System.Windows.Forms.RadioButton();
            this.gBoxDrinks = new System.Windows.Forms.GroupBox();
            this.chkBoxWine = new System.Windows.Forms.CheckBox();
            this.chkBoxOpenBar = new System.Windows.Forms.CheckBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblEntreTotal = new System.Windows.Forms.Label();
            this.lblDrinksTotal = new System.Windows.Forms.Label();
            this.lblSurcharges = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblDev = new System.Windows.Forms.Label();
            this.lblDivider = new System.Windows.Forms.Label();
            this.lblEntreCost = new System.Windows.Forms.Label();
            this.lblDrinkCost = new System.Windows.Forms.Label();
            this.lblSurchargeCost = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.lblEventToString = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfGuests)).BeginInit();
            this.gBoxEntre.SuspendLayout();
            this.gBoxDrinks.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEventName
            // 
            this.lblEventName.AutoSize = true;
            this.lblEventName.Location = new System.Drawing.Point(17, 15);
            this.lblEventName.Name = "lblEventName";
            this.lblEventName.Size = new System.Drawing.Size(96, 20);
            this.lblEventName.TabIndex = 0;
            this.lblEventName.Text = "Event Name";
            // 
            // tBoxEventName
            // 
            this.tBoxEventName.Location = new System.Drawing.Point(120, 14);
            this.tBoxEventName.MaxLength = 255;
            this.tBoxEventName.Name = "tBoxEventName";
            this.tBoxEventName.Size = new System.Drawing.Size(376, 26);
            this.tBoxEventName.TabIndex = 1;
            this.tBoxEventName.TextChanged += new System.EventHandler(this.tBoxEventName_TextChanged);
            // 
            // lblGuests
            // 
            this.lblGuests.AutoSize = true;
            this.lblGuests.Location = new System.Drawing.Point(17, 59);
            this.lblGuests.Name = "lblGuests";
            this.lblGuests.Size = new System.Drawing.Size(61, 20);
            this.lblGuests.TabIndex = 2;
            this.lblGuests.Text = "Guests";
            this.lblGuests.Click += new System.EventHandler(this.label1_Click);
            // 
            // nudNumberOfGuests
            // 
            this.nudNumberOfGuests.Location = new System.Drawing.Point(120, 54);
            this.nudNumberOfGuests.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudNumberOfGuests.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudNumberOfGuests.Name = "nudNumberOfGuests";
            this.nudNumberOfGuests.Size = new System.Drawing.Size(54, 26);
            this.nudNumberOfGuests.TabIndex = 3;
            this.nudNumberOfGuests.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudNumberOfGuests.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudNumberOfGuests.ValueChanged += new System.EventHandler(this.nudNumberOfGuests_ValueChanged);
            // 
            // gBoxEntre
            // 
            this.gBoxEntre.Controls.Add(this.rBtnGardenL);
            this.gBoxEntre.Controls.Add(this.rBtnChickenM);
            this.gBoxEntre.Controls.Add(this.rBtnPrimeRib);
            this.gBoxEntre.Location = new System.Drawing.Point(17, 103);
            this.gBoxEntre.Name = "gBoxEntre";
            this.gBoxEntre.Size = new System.Drawing.Size(471, 77);
            this.gBoxEntre.TabIndex = 4;
            this.gBoxEntre.TabStop = false;
            this.gBoxEntre.Text = "Select One Entre";
            // 
            // rBtnGardenL
            // 
            this.rBtnGardenL.AutoSize = true;
            this.rBtnGardenL.Location = new System.Drawing.Point(307, 25);
            this.rBtnGardenL.Name = "rBtnGardenL";
            this.rBtnGardenL.Size = new System.Drawing.Size(147, 24);
            this.rBtnGardenL.TabIndex = 2;
            this.rBtnGardenL.Text = "Garden Lasagna";
            this.rBtnGardenL.UseVisualStyleBackColor = true;
            // 
            // rBtnChickenM
            // 
            this.rBtnChickenM.AutoSize = true;
            this.rBtnChickenM.Location = new System.Drawing.Point(137, 26);
            this.rBtnChickenM.Name = "rBtnChickenM";
            this.rBtnChickenM.Size = new System.Drawing.Size(144, 24);
            this.rBtnChickenM.TabIndex = 1;
            this.rBtnChickenM.Text = "Chicken Marsala";
            this.rBtnChickenM.UseVisualStyleBackColor = true;
            this.rBtnChickenM.CheckedChanged += new System.EventHandler(this.rBtnChickenM_CheckedChanged);
            // 
            // rBtnPrimeRib
            // 
            this.rBtnPrimeRib.AutoSize = true;
            this.rBtnPrimeRib.Checked = true;
            this.rBtnPrimeRib.Location = new System.Drawing.Point(16, 26);
            this.rBtnPrimeRib.Name = "rBtnPrimeRib";
            this.rBtnPrimeRib.Size = new System.Drawing.Size(95, 24);
            this.rBtnPrimeRib.TabIndex = 0;
            this.rBtnPrimeRib.TabStop = true;
            this.rBtnPrimeRib.Text = "Prime Rib";
            this.rBtnPrimeRib.UseVisualStyleBackColor = true;
            this.rBtnPrimeRib.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // gBoxDrinks
            // 
            this.gBoxDrinks.Controls.Add(this.chkBoxWine);
            this.gBoxDrinks.Controls.Add(this.chkBoxOpenBar);
            this.gBoxDrinks.Location = new System.Drawing.Point(17, 204);
            this.gBoxDrinks.Name = "gBoxDrinks";
            this.gBoxDrinks.Size = new System.Drawing.Size(471, 61);
            this.gBoxDrinks.TabIndex = 5;
            this.gBoxDrinks.TabStop = false;
            this.gBoxDrinks.Text = "Choose All Drink Options";
            // 
            // chkBoxWine
            // 
            this.chkBoxWine.AutoSize = true;
            this.chkBoxWine.Checked = true;
            this.chkBoxWine.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBoxWine.Location = new System.Drawing.Point(250, 26);
            this.chkBoxWine.Name = "chkBoxWine";
            this.chkBoxWine.Size = new System.Drawing.Size(151, 24);
            this.chkBoxWine.TabIndex = 1;
            this.chkBoxWine.Text = "Wine With Dinner";
            this.chkBoxWine.UseVisualStyleBackColor = true;
            // 
            // chkBoxOpenBar
            // 
            this.chkBoxOpenBar.AutoSize = true;
            this.chkBoxOpenBar.Checked = true;
            this.chkBoxOpenBar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBoxOpenBar.Location = new System.Drawing.Point(70, 26);
            this.chkBoxOpenBar.Name = "chkBoxOpenBar";
            this.chkBoxOpenBar.Size = new System.Drawing.Size(96, 24);
            this.chkBoxOpenBar.TabIndex = 0;
            this.chkBoxOpenBar.Text = "Open Bar";
            this.chkBoxOpenBar.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(17, 289);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 36);
            this.btnCreate.TabIndex = 6;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(146, 289);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 36);
            this.btnModify.TabIndex = 7;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Location = new System.Drawing.Point(275, 289);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 36);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(404, 289);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 36);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblEntreTotal
            // 
            this.lblEntreTotal.AutoSize = true;
            this.lblEntreTotal.Location = new System.Drawing.Point(13, 345);
            this.lblEntreTotal.Name = "lblEntreTotal";
            this.lblEntreTotal.Size = new System.Drawing.Size(87, 20);
            this.lblEntreTotal.TabIndex = 10;
            this.lblEntreTotal.Text = "Entre Total";
            // 
            // lblDrinksTotal
            // 
            this.lblDrinksTotal.AutoSize = true;
            this.lblDrinksTotal.Location = new System.Drawing.Point(13, 374);
            this.lblDrinksTotal.Name = "lblDrinksTotal";
            this.lblDrinksTotal.Size = new System.Drawing.Size(93, 20);
            this.lblDrinksTotal.TabIndex = 11;
            this.lblDrinksTotal.Text = "Drinks Total";
            // 
            // lblSurcharges
            // 
            this.lblSurcharges.AutoSize = true;
            this.lblSurcharges.Location = new System.Drawing.Point(13, 401);
            this.lblSurcharges.Name = "lblSurcharges";
            this.lblSurcharges.Size = new System.Drawing.Size(91, 20);
            this.lblSurcharges.TabIndex = 12;
            this.lblSurcharges.Text = "Surcharges";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.ForeColor = System.Drawing.Color.Red;
            this.lblTotal.Location = new System.Drawing.Point(13, 447);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(89, 20);
            this.lblTotal.TabIndex = 13;
            this.lblTotal.Text = "Event Total";
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // lblDev
            // 
            this.lblDev.AutoSize = true;
            this.lblDev.CausesValidation = false;
            this.lblDev.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDev.Location = new System.Drawing.Point(345, 466);
            this.lblDev.Name = "lblDev";
            this.lblDev.Size = new System.Drawing.Size(161, 16);
            this.lblDev.TabIndex = 14;
            this.lblDev.Text = "Developed by Mary Clark";
            this.lblDev.UseMnemonic = false;
            // 
            // lblDivider
            // 
            this.lblDivider.Enabled = false;
            this.lblDivider.Location = new System.Drawing.Point(13, 421);
            this.lblDivider.Name = "lblDivider";
            this.lblDivider.Size = new System.Drawing.Size(234, 26);
            this.lblDivider.TabIndex = 15;
            this.lblDivider.Text = "_________________________";
            this.lblDivider.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblDivider.UseMnemonic = false;
            // 
            // lblEntreCost
            // 
            this.lblEntreCost.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblEntreCost.AutoSize = true;
            this.lblEntreCost.Enabled = false;
            this.lblEntreCost.Location = new System.Drawing.Point(146, 345);
            this.lblEntreCost.Name = "lblEntreCost";
            this.lblEntreCost.Size = new System.Drawing.Size(58, 20);
            this.lblEntreCost.TabIndex = 16;
            this.lblEntreCost.Text = "$00.00";
            this.lblEntreCost.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDrinkCost
            // 
            this.lblDrinkCost.AutoSize = true;
            this.lblDrinkCost.Enabled = false;
            this.lblDrinkCost.Location = new System.Drawing.Point(146, 374);
            this.lblDrinkCost.Name = "lblDrinkCost";
            this.lblDrinkCost.Size = new System.Drawing.Size(58, 20);
            this.lblDrinkCost.TabIndex = 17;
            this.lblDrinkCost.Text = "$00.00";
            this.lblDrinkCost.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblDrinkCost.UseMnemonic = false;
            // 
            // lblSurchargeCost
            // 
            this.lblSurchargeCost.AutoSize = true;
            this.lblSurchargeCost.Enabled = false;
            this.lblSurchargeCost.Location = new System.Drawing.Point(146, 401);
            this.lblSurchargeCost.Name = "lblSurchargeCost";
            this.lblSurchargeCost.Size = new System.Drawing.Size(58, 20);
            this.lblSurchargeCost.TabIndex = 18;
            this.lblSurchargeCost.Text = "$00.00";
            this.lblSurchargeCost.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblSurchargeCost.UseMnemonic = false;
            this.lblSurchargeCost.Click += new System.EventHandler(this.lblSurchargeCost_Click);
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Enabled = false;
            this.lblTotalCost.Location = new System.Drawing.Point(146, 447);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(58, 20);
            this.lblTotalCost.TabIndex = 19;
            this.lblTotalCost.Text = "$00.00";
            this.lblTotalCost.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblEventToString
            // 
            this.lblEventToString.AutoSize = true;
            this.lblEventToString.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEventToString.Location = new System.Drawing.Point(518, 15);
            this.lblEventToString.MinimumSize = new System.Drawing.Size(350, 450);
            this.lblEventToString.Name = "lblEventToString";
            this.lblEventToString.Size = new System.Drawing.Size(350, 450);
            this.lblEventToString.TabIndex = 20;
            // 
            // CateringEventForm
            // 
            this.AcceptButton = this.btnCreate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(879, 491);
            this.Controls.Add(this.lblEventToString);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.lblSurchargeCost);
            this.Controls.Add(this.lblDrinkCost);
            this.Controls.Add(this.lblEntreCost);
            this.Controls.Add(this.lblDivider);
            this.Controls.Add(this.lblDev);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblSurcharges);
            this.Controls.Add(this.lblDrinksTotal);
            this.Controls.Add(this.lblEntreTotal);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.gBoxDrinks);
            this.Controls.Add(this.gBoxEntre);
            this.Controls.Add(this.nudNumberOfGuests);
            this.Controls.Add(this.lblGuests);
            this.Controls.Add(this.tBoxEventName);
            this.Controls.Add(this.lblEventName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CateringEventForm";
            this.Text = "Aggie Catering - Events";
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfGuests)).EndInit();
            this.gBoxEntre.ResumeLayout(false);
            this.gBoxEntre.PerformLayout();
            this.gBoxDrinks.ResumeLayout(false);
            this.gBoxDrinks.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEventName;
        private System.Windows.Forms.TextBox tBoxEventName;
        private System.Windows.Forms.Label lblGuests;
        private System.Windows.Forms.NumericUpDown nudNumberOfGuests;
        private System.Windows.Forms.GroupBox gBoxEntre;
        private System.Windows.Forms.RadioButton rBtnPrimeRib;
        private System.Windows.Forms.RadioButton rBtnChickenM;
        private System.Windows.Forms.RadioButton rBtnGardenL;
        private System.Windows.Forms.GroupBox gBoxDrinks;
        private System.Windows.Forms.CheckBox chkBoxWine;
        private System.Windows.Forms.CheckBox chkBoxOpenBar;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblEntreTotal;
        private System.Windows.Forms.Label lblDrinksTotal;
        private System.Windows.Forms.Label lblSurcharges;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblDev;
        private System.Windows.Forms.Label lblDivider;
        private System.Windows.Forms.Label lblEntreCost;
        private System.Windows.Forms.Label lblDrinkCost;
        private System.Windows.Forms.Label lblSurchargeCost;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label lblEventToString;
    }
}