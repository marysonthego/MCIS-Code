/*
 * Class Name: MClarkAS4.MClarkProgram9.CateringEventForm
 * Class Description: CateringEventForm specifies the actions performed when a button on the Form is clicked.
 * CollectData() instantiates an object of type CateringEvent if it was called by the Create Button.
 * If CollectData() was called by the Modify button, properties of CateringEvent are updated.
 * There is no default Constructor for CateringEvent.
 * Developer Name: Mary Clark
 * Date Created: 10/14/2018
 * Date Last Modified: 10/14/2018
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

namespace MClarkProgram9
{
    /*
     * Define the event handlers for button events on the Catering Event Form class
     */

    partial class CateringEventForm : Form
    {
        /*
         * Create a reference to a Catering Event object
         */

        private CateringEvent anEvent;

    /*
     * Create the Catering Event Form and disable the Modify Button
     */

     public CateringEventForm()
        {
            InitializeComponent();
            btnModify.Enabled = false;
        }

        /*
         * Event handler for the Click action on the Create button
         */

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (tBoxEventName.TextLength == 0)
            {
                /*
                 * Missing Event Name, Dialog to ask user to Retry or Cancel?
                 */
            
                DialogResult d = MessageBox.Show("Event Name Required", "Required Field Missing", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

                if (d == DialogResult.Retry)
                {
                    /*
                     * If Retry is selected, set focus on the Event Name TextBox and return
                     */
                    tBoxEventName.Focus();
                    return;
                }
                else
                {
                    /*
                     * If Cancel is selected, reset all values on the Form and return
                     */

                    tBoxEventName.Text = "";
                    tBoxEventName.Focus();
                    nudNumberOfGuests.Value = nudNumberOfGuests.Minimum;
                    rBtnPrimeRib.Checked = true;
                    chkBoxOpenBar.Checked = true;
                    chkBoxWine.Checked = true;
                    btnCreate.Enabled = true;
                    btnModify.Enabled = false;
                    return;
                }
            }
            else
                /*
                 * We have an Event Name. Collect all the data on the Form and use it to instantiate a CateringEvent object.
                */
            {
                CollectData();
            }
            /*
             * Disable the Event Name textbox, disable the Create button, and enable the Modify button in case the user wishes to change any properties of their new Catering Event.
             */

            tBoxEventName.Enabled = false;
            btnModify.Enabled = true;
            btnCreate.Enabled = false;
            return;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            /*
             * Call CollectData to update properties Modified on the CateringEvent
             */

            CollectData();
            return;
        }
        /*
         * CollectData is used by Create Catering Event button and Modify Catering Event button to validate and create a new Catering Event object, or update the properties of the current Catering Event object, depending on which button initiated the call.
         */

        private void CollectData()
        {
            string name = tBoxEventName.Text;
            int guests = (int)nudNumberOfGuests.Value;
            EntreType entre;
            bool bar = false;
            bool wine = false;

            if (rBtnPrimeRib.Checked == true)
                entre = EntreType.PrimeRib;
            else if (rBtnChickenM.Checked == true)
                entre = EntreType.ChickenMarsala;
            else
                entre = EntreType.GardenLasagna;

            if (chkBoxOpenBar.Checked)
                bar = true;
            if (chkBoxWine.Checked)
                wine = true;

            if (btnCreate.Enabled)
            {
                anEvent = new CateringEvent(name, guests, entre, bar, wine);
                lblEventToString.Text = anEvent.ToString();
            }
            else
            {
                anEvent.NumberOfGuests = guests;
                anEvent.EntreChoice = entre;
                anEvent.OpenBar = bar;
                anEvent.WineWithDinner = wine;
                lblEventToString.Text = anEvent.ToString();
            }
            /*
             * Totals for the Entre, Drinks, Surcharge, and total event charge are reported on the Catering Event Form based on the create or modify properties entered by the user
             */
            lblEntreCost.Text = anEvent.EntreCharge.ToString("C");
            lblDrinkCost.Text = anEvent.DrinksCharge.ToString("C");
            lblSurchargeCost.Text = anEvent.Surcharge.ToString("C");
            lblTotalCost.Text = anEvent.TotalCharge.ToString("C"); ;
          
            return;
        }
        /*
         * Reset all values to their defaults when the Clear button is clicked
         */
        private void btnClear_Click(object sender, EventArgs e)
        {
            tBoxEventName.Text = "";
            tBoxEventName.Enabled = true;
            tBoxEventName.Focus();
            nudNumberOfGuests.Value = nudNumberOfGuests.Minimum;
            rBtnPrimeRib.Checked = true;
            chkBoxOpenBar.Checked = true;
            chkBoxWine.Checked = true;
            btnCreate.Enabled = true;
            btnModify.Enabled = false;
            lblEventToString.Text = anEvent.ToString();
        }
        /* Prompt for verification in a MessageBox if the user clicks the Exit button
         */
        private void btnExit_Click(Object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Do you want to Quit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (d == DialogResult.Yes)
                this.Close();
        }

        /*
         * The Methods below were auto-generated by Visual Studio and are not used.
         */
        private void rBtnChickenM_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tBoxEventName_TextChanged(object sender, EventArgs e)
        {

        }

        private void nudNumberOfGuests_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void lblSurchargeCost_Click(object sender, EventArgs e)
        {

        }
    }
}
