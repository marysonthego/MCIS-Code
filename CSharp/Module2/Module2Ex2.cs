/*
 * Project:         Module 2; Example 1
 * Date:            August 2018
 * Developed By:    LV
 * Class Name:      Module2Ex2
 * Description:     Presentation Layer class for calculating the caloric valve of a food item
 * Purpose:         Demonstrates Numeric Up Down control; MessageBox class; class-level variables
 * Uses:            Food class
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

namespace Module2
{
    public partial class Module2Ex2 : Form
    {
        // declare class-level variable

        Food aFood;

        public Module2Ex2()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // instantiate a food object

            aFood = new Food();

            // display message

            MessageBox.Show("Food object created", "Object Announcement", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // enable/disable buttons

            btnCreate.Enabled = false;
            btnDisplay.Enabled = true;
                   
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            // declare local (i.e., method-level) variables

            int intFatGrams, intCarbsGrams, intProteinGrams, intFoodCalories;

            string strMessage;

            // convert data in numeric up down controls and assign to variables

            intFatGrams = Convert.ToInt32(nudFat.Value);
            intCarbsGrams = Convert.ToInt32(nudCarbs.Value);
            intProteinGrams = Convert.ToInt32(nudProtein.Value);
            

            // call the CalculateCalories method

            intFoodCalories = aFood.CalculateCalories(intFatGrams, intCarbsGrams, intProteinGrams);

            // prepare message to display

            strMessage = $"Food Calories: {intFoodCalories.ToString("n0")}";

            // display the result in a message box

            MessageBox.Show(strMessage, "Caloric Value", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
                       
            // reset the form for fresh inputs

            nudFat.Value = 0;
            nudCarbs.Value = 0;
            nudProtein.Value = 0;

            // enable/disable buttons

            btnCreate.Enabled = true;
            btnDisplay.Enabled = false;

            nudFat.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // close the form

            this.Close();
        }

        
    }
}
