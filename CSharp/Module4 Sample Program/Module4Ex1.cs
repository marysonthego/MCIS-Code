/*
 * Project:         Module 4; Example 1
 * Date:            September 2018
 * Developed By:    LV
 * Class Name:      Module4Ex1 - Presentation Layer
 * Purpose:         Test Loan Application (if and switch statements)
 * Uses:            LoanApplication class
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

namespace Module4
{
    public partial class Module4Ex1 : Form
    {
        // declare object variable

        private LoanApplication aApplication;

        public Module4Ex1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //check Name TexBox

            if (txtName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Applicant name is required", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return;
            }
            
            // declare local (i.e., method-level) variables

            string applicantName;
            int applicantIncome, applicantDebt;
            LoanType loanType;
            
            // assign input data to variables

            applicantName = txtName.Text;
            
            applicantIncome = Convert.ToInt32(nudIncome.Value);
            applicantDebt = Convert.ToInt32(nudDebt.Value);

            loanType = (radAuto.Checked) ? LoanType.Auto : LoanType.Home;

            // instantiate a LoanApplication object

            aApplication = new LoanApplication(applicantName, applicantIncome, applicantDebt,loanType);

            // access and display properties

            lblRating.Text = aApplication.CreditRating.ToString();

            lblScore.Text = aApplication.CreditScore.ToString("n0");

            // disable/enable controls

            grpLoanApplicationInfo.Enabled = false;
            btnCreate.Enabled = false;
            grpDisplayInfo.Enabled = true;
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            // reset the form for fresh inputs

            txtName.Clear();
            radAuto.Checked = true;
            nudIncome.Value = nudIncome.Minimum;
            nudDebt.Value = nudDebt.Minimum;

            lblRating.Text = null;
            lblScore.Text = null;
            
            // enable/disable controls

            grpLoanApplicationInfo.Enabled = true;
            btnCreate.Enabled = true;
            grpDisplayInfo.Enabled = false;

            // set focus

            txtName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // declare variable of type DialogResult

            DialogResult aResult;

            // assign the return value to the variable

            aResult = MessageBox.Show("Do you wish to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            // take action based on the value of aResult

            if (aResult == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                txtName.Focus();
            }
        }

        private void btnPreQualified_Click(object sender, EventArgs e)
        {
            // prepare message to display

            string message = aApplication.CheckPreQualification();

            // display the result in a message box

            MessageBox.Show(message, "Pre-Qualified?", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnPreApproved_Click(object sender, EventArgs e)
        {
            // prepare message to display

            string message = (aApplication.IsPreApproved()) ? "Yes" : "No" ;

            // display the result in a message box

            MessageBox.Show(message, "Pre-Approved?", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnInterestRate_Click(object sender, EventArgs e)
        {
            // prepare message to display

            string message = $" The interest rate on your {aApplication.LoanFor} loan would be: {aApplication.DetermineInterestRate().ToString("p2")}" ;

            // display the result in a message box

            MessageBox.Show(message, "Interest Rate", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
