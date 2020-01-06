using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program7
{
    public partial class CarRentalForm : Form
    {
        // declare object variable

        private CarRental aCarRental;

        public CarRentalForm()
        {
            InitializeComponent();
        }

        private void CarRentalForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCarRental_Click(object sender, EventArgs e)
        {
            //Create new CarRental with values from form controls

            aCarRental = new CarRental(tBoxCustomerName.Text, (int)nudEndingOdometerReading.Value, (int)nudBeginningOdometerReading.Value, (int)nudNumberOfDaysRented.Value);

            lblRentalCharge.Text = aCarRental.RentalCharge.ToString("C");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tBoxCustomerName.Text = "Enter Customer Name";
            tBoxCustomerName.Focus();
            nudBeginningOdometerReading.Value = 0;
            nudEndingOdometerReading.Value = 0;
            nudNumberOfDaysRented.Value = 0;
            lblRentalCharge.Text = "0.00";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}