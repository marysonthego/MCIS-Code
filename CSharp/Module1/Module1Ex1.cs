/*
 * Project:         Module 1; Example 1
 * Date:            August 2018
 * Developed By:    LV
 * Class Name:      Module1Ex1
 * Description:     Presentation Layer class for displaying greetings
 * Purpose:         Demonstrate how to create an object and use its methods
*/

using System;
using System.Windows.Forms;

namespace Module1
{
    public partial class Module1Ex1 : Form
    {
        public Module1Ex1()
        {
            InitializeComponent();
        }

        private void btnWelcome_Click(object sender, EventArgs e)
        {
            // create a Greeter object

            Greeter aGreeter = new Greeter();

            // call the SayHello method

            lblGreeting.Text = aGreeter.SayHello();
        }

        private void btnBye_Click(object sender, EventArgs e)
        {
            // create a Greeter object

            Greeter aGreeter = new Greeter();

            // call the SayGoodBye method

            lblGreeting.Text = aGreeter.SayGoodBye(txtName.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // close the form

            this.Close();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
