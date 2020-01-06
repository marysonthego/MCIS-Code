/*
 * Project:         Module 6; Example 2
 * Date:            October 2018
 * Developed By:    LV
 * Class Name:      Module6Ex2 - Presentation Layer
 * Purpose:         Test StockAnalyzer class (arrays)
 * Uses:            StockAnalyzer class
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

namespace Module6
{
    public partial class Module6Ex2 : Form
    {
        
        //declare class level object variable

        private StockAnalyzer aAnalyzer;

        public Module6Ex2()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // assign ticker symbol to symbol

            string symbol = txtSymbol.Text;

            //remove empty lines

            txtPrices.Text = txtPrices.Text.Trim();
            
            // assign number of lines in prices textbox
            
            int numLines = txtPrices.Lines.Length;

            // set array size to number of lines in price textbox

            decimal[] prices = new decimal[numLines];

            // loop to assign data from prices textbox to prices array

            for (int x = 0; x < numLines; ++x)
            {
                prices[x] = decimal.Parse(txtPrices.Lines[x]);
            }

            // alternatively, the data in the textbox can be split by line and assigned to a string array
            // the string array can then be converted to a decimal array
            
            // string[] stringPrices = txtPrices.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            // decimal[] prices = Array.ConvertAll(stringPrices, decimal.Parse);
            
            // instantiate StockAnalyzer object

            aAnalyzer = new StockAnalyzer(symbol, prices);

           // disable/enable controls

            grpStockInfo.Enabled = false;
            grpAnalysis.Enabled = true;
        }

        private void btnMinimum_Click(object sender, EventArgs e)
        {
            lblMinimum.Text = aAnalyzer.FindMinimumPrice().ToString("c");
        }

        private void btnMaximum_Click(object sender, EventArgs e)
        {
            lblMaximum.Text = aAnalyzer.FindMaximumPrice().ToString("c");
        }

        private void btnAverage_Click(object sender, EventArgs e)
        {
            lblAverage.Text = aAnalyzer.CalcAveragePrice().ToString("c");
        }

        private void btnMedian_Click(object sender, EventArgs e)
        {
            lblMedian.Text = aAnalyzer.CalcMedianPrice().ToString("c");
        }

        private void btnStdDeviation_Click(object sender, EventArgs e)
        {
            lblStdDeviation.Text = aAnalyzer.CalcStandardDeviationOfPrices().ToString("c");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // reset the form for fresh inputs

            txtSymbol.Clear();
            txtPrices.Clear();

            // set text property of each label in Analysis groupbox to null

            foreach (Control aControl in grpAnalysis.Controls)
            {
                if (aControl is Label)
                aControl.Text = null;
            }

            // enable/disable controls

            grpStockInfo.Enabled = true;
            grpAnalysis.Enabled = false;

            // set focus

            txtSymbol.Focus();
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
                txtSymbol.Focus();
            }
        }
    }
}
