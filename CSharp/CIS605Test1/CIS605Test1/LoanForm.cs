/*
 * Project:         Test 1
 * Date:            September 2018
 * Developed By:    LV
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS605Test1
{
    public partial class LoanForm : Form
    {
        private Loan aLoan;

        public LoanForm()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            /* ***** Requirement 4 ***** (18 Points)
             * Write code to 
             * a) instantiate a loan object
             * b) display the monthly payment for the loan (formatted to display with a dollar symbol and two decimal places
             * c) display the total interest for the loan (formatted to display with a dollar symbol and two decimal places)
            */
            int loanAmount = (int)nudLoanAmount.Value;
            double rate = (double)nudAnnualInterestRate.Value;
            int duration = (int)nudLoanDuration.Value;

            aLoan = new Loan(loanAmount, rate, duration);

            lblMonthlyPayment.Text = aLoan.MonthlyPayment.ToString("C");

            lblTotalInterest.Text = aLoan.CalculateTotalInterest().ToString("C");


            // disable controls

            grpLoanInfo.Enabled = false;
            btnCreate.Enabled = false;
        }

        private void btnTotalLoans_Click(object sender, EventArgs e)
        {
            /* ***** Requirement 5 ***** (10 Points)
             * Write code to display the total number of loans in a MessageBox with an appropriate title, icon and button.
            */
 
            MessageBox.Show(Loan.TotalNumberOfLoans.ToString(), "Total Number of Loans", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // reset the form for fresh inputs

            nudLoanAmount.Value = nudLoanAmount.Minimum;
            nudAnnualInterestRate.Value = nudAnnualInterestRate.Minimum;
            nudLoanDuration.Value = nudLoanDuration.Minimum;
            lblMonthlyPayment.Text = null;
            lblTotalInterest.Text = null;
            
            // enable controls

            grpLoanInfo.Enabled = true;
            btnCreate.Enabled = true;

            //set focus

            nudLoanAmount.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // close the form

            this.Close();
        }
    }
}
