/*
 * Project:         Module 5; Example 4
 * Date:            October 2018
 * Developed By:    LV
 * Class Name:      Module5Ex4 - Presentation Layer
 * Purpose:         Test Investment class (loops)
 * Uses:            Investment class
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

namespace Module5
{
    public partial class Module5Ex4 : Form
    {
        public Module5Ex4()

        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // declare local (i.e., method-level) variables

            Investment myInvestment;

            int investAmount, investTime;
            decimal investRate;
                        
            // assign input data to variables

            investAmount = Convert.ToInt32(nudAmount.Value);
            investTime = Convert.ToInt32(nudPeriod.Value);
            investRate = nudRate.Value;

            // instantiate a Investment object

            myInvestment = new Investment(investAmount, investTime, investRate);

            // display object properties

            lblInfo.Text = myInvestment.ToString();

            // disable/enable controls

            grpInvestmentInfo.Enabled = false;
            btnCreate.Enabled = false;
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            // reset the form for fresh inputs

            nudAmount.Value = nudAmount.Minimum;
            nudPeriod.Value = nudPeriod.Minimum;
            nudRate.Value = nudRate.Minimum;

            lblInfo.Text = null;
                        
            // enable/disable controls

            grpInvestmentInfo.Enabled = true;
            btnCreate.Enabled = true;

            // set focus

            nudAmount.Focus();
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
                nudAmount.Focus();
            }
        }
    }
}
