/*
 * Class Name: MClarkAssignmentSet2.Program4.InvestmentForm
 * Class Description: InvestmentForm is a Windows Form object which contains the following major components: 
 * lblTitle displays "Calculate Future Value"
 * numUDPresentVal is a NumericUpDown control. The user selects a value between 1000 and 100,000 incremented by 1000.
 * numUDDuration is a Numeric UpDown control. The user selects a value for the number of years between 1 and 20 incremented by 1.
 * numUDRate is a Numeric UpDown control. The user selects an interest rate between 0.50 and 10.0 incremented by 0.25.
 * When BtnFutureValue receives a click event, it calculates the future value of the investment by instantiating an instance 
 * of the Investment class and passing the decimal arguments numUDPresentVal.Value, numUDDuration.Value, and numUDRate.Value. 
 * The result is stored in lblFutureValResult.Text as a formatted string.
 * BtnReset_Click resets numUDPresentVal.Value, numUDDuration.Value, and numUDRate back to their original values, 
 * and resets lblFutureValResult.Text to null.
 * This class owns the decimal constants for initialPresentValue, initialDurationValue, and initialRate.
 * When BtnExit is clicked, the program is closed.
 * Developer Name: Mary Clark
 * Date Created: 9/9/2018
 * Date Last Modified: 9/14/2018
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

namespace Program4
{
    /*
     * Declare the InvestmentForm class
     */
    public partial class InvestmentForm : Form
    {
        /*
         * Create constants for the numeric up/down initial values
         */
        const decimal initialPresentValue = 1000;
        const decimal initialDurationValue = 1;
        const decimal initialRate = .5m;
        
        public InvestmentForm()
        {
            /*
             * Initialize the InvestmentForm and its components
             */
            InitializeComponent();
        }

        private void InvestmentForm_Load(object sender, EventArgs e)
        {

        }
        /*
         * When BtnFutureVal receives a Click event, instantiate a new object of type Investment,
         * and call the Investment class' CalculateFutureValue method to calculate the future value from the 
         * present value, duration in years, and interest rate provided.
         */
        private void BtnFutureVal_Click(object sender, EventArgs e)
        {
            Investment MyInvestment = new Investment();
            lblFutureValResult.Text = MyInvestment.CalculateFutureValue(numUDPresentVal.Value, numUDDuration.Value, numUDRate.Value).ToString("C");

        }
        /* 
         * When BtnReset receives a Click event, reset all form values to their defaults and clear out the future value result.
         */
        private void BtnReset_Click(object sender, EventArgs e)
        {
            numUDPresentVal.Value = initialPresentValue;
            numUDDuration.Value = initialDurationValue;
            numUDRate.Value = initialRate;
            lblFutureValResult.Text = null;
        }
        /*
         * When BtnExit receives a click event, terminate the program.
         */
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
