/*
 * Class Name: MClarkAssignmentSet2.Program3.PromoForm
 * Class Description: PromoForm is a Windows Form object which contains the following major components: 
 *   lblCoName - a label for displaying the company name.
 *   lblTagLine - a label for displaying the company's tag line.
 *   grpBoxColors - a mutually exclusive set of radio buttons (f/ex: radioBtnRed) users 
 *   select from to change the color of lblTagLine.
 *   picBoxLogo - a picture box for displaying the company's logo image
 *   A ToolTip is implemented for picBoxLogo which displays 'Our Logo'.
 *   grpBoxShowHide - contains checkboxes (f/ex: chkBoxLogo) allowing users to show
 *   or hide different components on the form. 
 *   lblDeveloper - a label for displaying the name of the developer.
 *   btnExit - a button implemented as the cancel button for the form. The instance of PromoForm is closed 
 *   when btnExit is clicked, or the ESC key on the keyboard is pressed.
 *   
 * The response to control events is defined in control event handlers.
 * 
 * Access keys, indicated by an underlined letter, are defined for each user control on the form. 
 * Users can enter ALT-<access key> to invoke the corresponding control.
 * 
 * If the access keys are not underlined on the form in Windows 10, open Windows Settings, select
 * 'Ease of Access', select Keyboard, and enable 'Underline access keys when available'.
 * 
 * The TAB key moves the focus through each available user control. Note that only the currently
 * selected radio button in grpBoxColors is able to receive focus.
 * 
 * Initial state: the form is centered on the screen. radioBtnRed is selected, 
 * and lblTagLine is displayed in red. All checkboxes are selected, and all controls are displayed.
 * 
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

namespace Program3
{
    /*
     * Declare the public class PromoForm as type Form. 'partial' 
     * indicates that the class definition is continued in 
     * another file (PromoForm.Designer.cs).
     */
    public partial class PromoForm : Form
    {
        public PromoForm()
        {
            /*
             * Call InitializeComponent() to create an instance of PromoForm 
             */
            InitializeComponent();
        }
        /*
         * Load method
         */
        private void PromoForm_Load(object sender, EventArgs e)
        {

        }
        /*
         * When the exit button receives a click event, 
         * close the current instance of PromoForm 
         */
        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /* 
        * When the Red radio button receives a 'CheckedChanged' event,
        * set the foreground color of the tagline label to Red
        */
        private void RadioBtnRed_CheckedChanged(object sender, EventArgs e)
        {
            lblTagLine.ForeColor = Color.Red;
        }
        /* 
         * When the green radio button receives a 'CheckedChanged' event,
         * set the foreground color of the tagline label to green
         */
        private void RadioBtnGreen_CheckedChanged(object sender, EventArgs e)
        {
            lblTagLine.ForeColor = Color.Green;
        }
        /* 
         * When the blue radio button receives a 'CheckedChanged' event,
         * set the foreground color of the tagline label to blue
         */
        private void RadioBtnBlue_CheckedChanged(object sender, EventArgs e)
        {
            lblTagLine.ForeColor = Color.Blue;
        }
        /* 
         * When the orange radio button receives a 'CheckedChanged' event,
         * set the foreground color of the tagline label to orange
         */
        private void RadioBtnOrange_CheckedChanged(object sender, EventArgs e)
        {
            lblTagLine.ForeColor = Color.Orange;
        }
        /* 
         * When the name checkbox receives a 'CheckedChanged' event,
         * set the name label 'Visible' property equal to
         * the name checkbox 'Checked' property
         */
        private void ChkBoxName_CheckedChanged(object sender, EventArgs e)
        {
            lblCoName.Visible = chkBoxName.Checked;
        }
        /* 
         * When the tagline checkbox receives a 'CheckedChanged' event,
         * set the tagline label 'Visible' property equal to
         * the tagline checkbox 'Checked' property
         */
        private void ChkBoxTagline_CheckedChanged(object sender, EventArgs e)
        {
            lblTagLine.Visible = chkBoxTagline.Checked;
        }
        /* 
         * When the logo checkbox receives a 'CheckedChanged' event,
         * set the logo pictureBox 'Visible' property equal to
         * the logo checkbox 'Checked' property
         */
        private void ChkBoxLogo_CheckedChanged(object sender, EventArgs e)
        {
            picBoxLogo.Visible = chkBoxLogo.Checked;
        }
        /*
         * When the developer checkbox receives a 'CheckedChanged' event,
         * set the developer label 'Visible' property equal to the 
         * developer checkbox 'Checked' property.
         */
        private void ChkBoxDeveloper_CheckedChanged(object sender, EventArgs e)
        {
            lblDeveloper.Visible = chkBoxDeveloper.Checked;
        }
    }
}
