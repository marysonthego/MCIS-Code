using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program8
{
    public partial class PayStubForm : Form
    {
        private PayStub aPayStub;

        static string defaultName = "Enter Employee Name";
        static decimal defaultHoursWorked = 0;
        static decimal defaultPayRate = 0;
        static string defaultNetPay = "Net Pay";
        static string defaultlblTotalNumberOfPayStubs = "Total Number of Pay Stubs:";
        static string defaultlblTotalNetPay = "Total Net Pay:";
        static string defaultlblAverageNetPay = "Average Net Pay:";

        public PayStubForm()
        {
            InitializeComponent();
        }

        private void btnPayStub_Click(object sender, EventArgs e)
        {
           /* if (nudPayRate.Value == 0)
            {
                lblPayRateError.Visible = true;
                return;
            } */
            lblPayRateError.Visible = false;
            string name = tBoxName.Text;
            int hoursWorked = (int)nudHoursWorked.Value;
            double payRate = (double)nudPayRate.Value;

            aPayStub = new PayStub(name, hoursWorked, payRate);

            lblNetPay.Text = aPayStub.NetPay.ToString("n");

        }

        private void btnSummary_Click(object sender, EventArgs e)
        {
            lblTotalNumberOfPayStubs.Text = PayStubForm.defaultlblTotalNumberOfPayStubs + PayStub.TotalNumberOfPayStubs.ToString();
            lblTotalNetPay.Text = PayStubForm.defaultlblTotalNetPay + PayStub.TotalNetPay.ToString();
            lblAverageNetPay.Text = PayStubForm.defaultlblAverageNetPay + PayStub.AverageNetPay().ToString();
        }
        
        private void btnReset_Click(object sender, EventArgs e)
        {
            tBoxName.Text = PayStubForm.defaultName;
            tBoxName.Focus();
            nudHoursWorked.Value = PayStubForm.defaultHoursWorked;
            nudPayRate.Value = PayStubForm.defaultPayRate;
            lblPayRateError.Visible = false;
            lblNetPay.Text = PayStubForm.defaultNetPay;
            lblTotalNumberOfPayStubs.Text = PayStubForm.defaultlblTotalNumberOfPayStubs;
            lblTotalNetPay.Text = PayStubForm.defaultlblTotalNetPay;
            lblAverageNetPay.Text = PayStubForm.defaultlblAverageNetPay;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
