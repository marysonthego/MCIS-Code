/*
 * Project:         Module 1; Example 2
 * Date:            August 2018
 * Developed By:    LV
 * Class Name:      Module1Ex2
 * Description:     Presentation Layer class for a simple calculator
 * Purpose:         Demonstrate how to create an object and use its methods; how to convert between data types
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

namespace Module1
{
    public partial class Module1Ex2 : Form
    {
        public Module1Ex2()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //create an Abacus object

            Abacus aAbacus = new Abacus();

            //call the Add method; convert the two "numbers" in the textboxes to integers and provide them as arguments to the method

            lblResult.Text = aAbacus.Add(Convert.ToInt32(txtOne.Text), Convert.ToInt32(txtTwo.Text)).ToString();
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            //create an Abacus object

            Abacus aAbacus = new Abacus();

            //call the Subtract method; convert the two "numbers" in the textboxes to integers and provide them as arguments to the method

            lblResult.Text = aAbacus.Subtract(Convert.ToInt32(txtOne.Text), Convert.ToInt32(txtTwo.Text)).ToString();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            //create an Abacus object

            Abacus aAbacus = new Abacus();

            //call the Multiply method; convert the two "numbers" in the textboxes to integers and provide them as arguments to the method

            lblResult.Text = aAbacus.Multiply(Convert.ToInt32(txtOne.Text), Convert.ToInt32(txtTwo.Text)).ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
