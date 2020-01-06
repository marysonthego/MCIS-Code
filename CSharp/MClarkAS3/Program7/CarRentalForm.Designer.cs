namespace Program7
{
    partial class CarRentalForm
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
            this.tBoxCustomerName = new System.Windows.Forms.TextBox();
            this.nudBeginningOdometerReading = new System.Windows.Forms.NumericUpDown();
            this.lblBeginningOdometerReading = new System.Windows.Forms.Label();
            this.lblEndingOdometerReading = new System.Windows.Forms.Label();
            this.nudEndingOdometerReading = new System.Windows.Forms.NumericUpDown();
            this.lblNumberOfDaysRented = new System.Windows.Forms.Label();
            this.nudNumberOfDaysRented = new System.Windows.Forms.NumericUpDown();
            this.btnCarRental = new System.Windows.Forms.Button();
            this.lblRentalCharge = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblDev = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudBeginningOdometerReading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEndingOdometerReading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfDaysRented)).BeginInit();
            this.SuspendLayout();
            // 
            // tBoxCustomerName
            // 
            this.tBoxCustomerName.Location = new System.Drawing.Point(13, 13);
            this.tBoxCustomerName.Name = "tBoxCustomerName";
            this.tBoxCustomerName.Size = new System.Drawing.Size(194, 22);
            this.tBoxCustomerName.TabIndex = 0;
            this.tBoxCustomerName.Text = "Enter Customer Name";
            // 
            // nudBeginningOdometerReading
            // 
            this.nudBeginningOdometerReading.Location = new System.Drawing.Point(260, 48);
            this.nudBeginningOdometerReading.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudBeginningOdometerReading.Name = "nudBeginningOdometerReading";
            this.nudBeginningOdometerReading.Size = new System.Drawing.Size(120, 22);
            this.nudBeginningOdometerReading.TabIndex = 1;
            this.nudBeginningOdometerReading.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudBeginningOdometerReading.ThousandsSeparator = true;
            // 
            // lblBeginningOdometerReading
            // 
            this.lblBeginningOdometerReading.AutoSize = true;
            this.lblBeginningOdometerReading.Location = new System.Drawing.Point(12, 50);
            this.lblBeginningOdometerReading.Name = "lblBeginningOdometerReading";
            this.lblBeginningOdometerReading.Size = new System.Drawing.Size(227, 16);
            this.lblBeginningOdometerReading.TabIndex = 2;
            this.lblBeginningOdometerReading.Text = "Select Beginning Odometer Reading";
            // 
            // lblEndingOdometerReading
            // 
            this.lblEndingOdometerReading.AutoSize = true;
            this.lblEndingOdometerReading.Location = new System.Drawing.Point(12, 99);
            this.lblEndingOdometerReading.Name = "lblEndingOdometerReading";
            this.lblEndingOdometerReading.Size = new System.Drawing.Size(209, 16);
            this.lblEndingOdometerReading.TabIndex = 3;
            this.lblEndingOdometerReading.Text = "Select Ending Odometer Reading";
            // 
            // nudEndingOdometerReading
            // 
            this.nudEndingOdometerReading.Location = new System.Drawing.Point(260, 97);
            this.nudEndingOdometerReading.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudEndingOdometerReading.Name = "nudEndingOdometerReading";
            this.nudEndingOdometerReading.Size = new System.Drawing.Size(120, 22);
            this.nudEndingOdometerReading.TabIndex = 4;
            this.nudEndingOdometerReading.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudEndingOdometerReading.ThousandsSeparator = true;
            // 
            // lblNumberOfDaysRented
            // 
            this.lblNumberOfDaysRented.AutoSize = true;
            this.lblNumberOfDaysRented.Location = new System.Drawing.Point(12, 150);
            this.lblNumberOfDaysRented.Name = "lblNumberOfDaysRented";
            this.lblNumberOfDaysRented.Size = new System.Drawing.Size(193, 16);
            this.lblNumberOfDaysRented.TabIndex = 5;
            this.lblNumberOfDaysRented.Text = "Select Number of Days Rented";
            // 
            // nudNumberOfDaysRented
            // 
            this.nudNumberOfDaysRented.Location = new System.Drawing.Point(260, 148);
            this.nudNumberOfDaysRented.Maximum = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.nudNumberOfDaysRented.Name = "nudNumberOfDaysRented";
            this.nudNumberOfDaysRented.Size = new System.Drawing.Size(120, 22);
            this.nudNumberOfDaysRented.TabIndex = 6;
            this.nudNumberOfDaysRented.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudNumberOfDaysRented.ThousandsSeparator = true;
            // 
            // btnCarRental
            // 
            this.btnCarRental.Location = new System.Drawing.Point(15, 199);
            this.btnCarRental.Name = "btnCarRental";
            this.btnCarRental.Size = new System.Drawing.Size(106, 23);
            this.btnCarRental.TabIndex = 7;
            this.btnCarRental.Text = "Car Rental";
            this.btnCarRental.UseVisualStyleBackColor = true;
            this.btnCarRental.Click += new System.EventHandler(this.btnCarRental_Click);
            // 
            // lblRentalCharge
            // 
            this.lblRentalCharge.AutoSize = true;
            this.lblRentalCharge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRentalCharge.Location = new System.Drawing.Point(346, 201);
            this.lblRentalCharge.Name = "lblRentalCharge";
            this.lblRentalCharge.Size = new System.Drawing.Size(34, 18);
            this.lblRentalCharge.TabIndex = 8;
            this.lblRentalCharge.Text = "0.00";
            this.lblRentalCharge.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(13, 266);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(305, 266);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblDev
            // 
            this.lblDev.AutoSize = true;
            this.lblDev.Location = new System.Drawing.Point(13, 326);
            this.lblDev.Name = "lblDev";
            this.lblDev.Size = new System.Drawing.Size(161, 16);
            this.lblDev.TabIndex = 11;
            this.lblDev.Text = "Developed by Mary Clark";
            // 
            // CarRentalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(401, 351);
            this.Controls.Add(this.lblDev);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblRentalCharge);
            this.Controls.Add(this.btnCarRental);
            this.Controls.Add(this.nudNumberOfDaysRented);
            this.Controls.Add(this.lblNumberOfDaysRented);
            this.Controls.Add(this.nudEndingOdometerReading);
            this.Controls.Add(this.lblEndingOdometerReading);
            this.Controls.Add(this.lblBeginningOdometerReading);
            this.Controls.Add(this.nudBeginningOdometerReading);
            this.Controls.Add(this.tBoxCustomerName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CarRentalForm";
            this.Text = "Car Rental";
            this.Load += new System.EventHandler(this.CarRentalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudBeginningOdometerReading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEndingOdometerReading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfDaysRented)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBoxCustomerName;
        private System.Windows.Forms.NumericUpDown nudBeginningOdometerReading;
        private System.Windows.Forms.Label lblBeginningOdometerReading;
        private System.Windows.Forms.Label lblEndingOdometerReading;
        private System.Windows.Forms.NumericUpDown nudEndingOdometerReading;
        private System.Windows.Forms.Label lblNumberOfDaysRented;
        private System.Windows.Forms.NumericUpDown nudNumberOfDaysRented;
        private System.Windows.Forms.Button btnCarRental;
        private System.Windows.Forms.Label lblRentalCharge;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblDev;
    }
}

