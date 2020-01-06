/*
 * Class Name: MClarkAssignmentSet2.Program5.PaintJobForm
 * Class Description: PaintJobForm is a Windows Form that accepts the number of square feet to be painted and the cost of a gallon of paint in NumericUpDown controls. When the user clicks the "Get Estimate" button, the cost of the paint job is calculated from PaintJob.CalculateEstimate. The estimate is displayed in labelResult formatted as currency. The Reset button resets the NumericUpDown controls back to their default values and resets the result label to 0.00. The Exit button closes the form and is also designated as the cancel action on the form. 
 *
 * Initial defaults for nudSqFeet, nudPaintCost, and lblResult are stored as class constants. To ensure that the program is maintainable, I modified PaintJobForm.Designer.cs so that it instantiates these 3 fields with the constant defaults rather than specifying literal numbers for these properties. Interestingly, even though the Value property for nudSqFeet and nudPaintCost Up/Down controls are returned as type decimal, they are actually stored as an array of 4 integers concatenated to produce the Value property. That's why I set the constant defaults to type int. One int can be written into the first bucket in the array. Making the default values int has no effect on calculations since ints are cast upward to decimal in calculations with decimals.  
 * Developer Name: Mary Clark
 * Date Created: 9/9/2018
 * Date Last Modified: 9/15/2018
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

namespace Program5
{
    public partial class PaintJobForm : Form
    {
        /*
         * Declare constants for default values. As discussed above, below is an example pulled from PaintJobForm.Designer.cs showing how the constant is used to set the initial Value in the NumericUpDown at initialization time.
         *  From PaintJobForm.Designer.cs:
         * this.nudPaintCost.Value = new decimal(new int[] {
            nudPaintCostDefault,
            0,
            0,
            0});
         */
        const int nudSqFeetDefault = 500;
        const int nudPaintCostDefault = 20;
        const string lblResultDefault = "0.00";

        public PaintJobForm()
        {
            InitializeComponent();
        }
        /*
         * When the Reset button is clicked, reset the fields on the form back to their default values.
         */
        private void btnReset_Click(object sender, EventArgs e)
        {
            nudSqFeet.Value = nudSqFeetDefault;
            nudPaintCost.Value = nudPaintCostDefault;
            lblResult.Text = lblResultDefault;
        }
        /*
         * When the Get Estimate button is clicked, instantiate a new PaintJob instance and call CalculateEstimate to get the result. Format the decimal result as as a currency string ($000.00) for display.
         */
        private void btnGetEstimate_Click(object sender, EventArgs e)
        {
            PaintJob MyPaintJob = new PaintJob();
            decimal result = MyPaintJob.CalculateEstimate(nudSqFeet.Value, nudPaintCost.Value);
            lblResult.Text = result.ToString("C2");

        }
        /*
         * Close the program when the Exit button is clicked.
         */
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
