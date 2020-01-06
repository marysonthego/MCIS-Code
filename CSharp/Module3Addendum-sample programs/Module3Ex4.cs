/*
 * Project:         Module 3; Example 4
 * Date:            September 2018
 * Developed By:    LV
 * Class Name:      Module3Ex4
 * Purpose:         Demonstrates the use of a static class
 * Uses:            Food4 class
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

namespace Module3Addendum
{
    public partial class Module3Ex4 : Form
    {
        public Module3Ex4()
        {
            InitializeComponent();
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
            

            // call the static CalculateCalories method

            intFoodCalories = Food4.CalculateCalories(intFatGrams, intCarbsGrams, intProteinGrams);

            // prepare message to display

            strMessage = $"Food Calories: {intFoodCalories.ToString("n0")}";

            // display the result in a message box

            MessageBox.Show(strMessage, "Caloric Value", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            // prepare message to display

            string strMessage = $" Fat: {Food4.FatCaloriesPerGram.ToString("n0")} \n Carbs: {Food4.CarbCaloriesPerGram.ToString("n0")} \n Protein: {Food4.ProteinCaloriesPerGram.ToString("n0")}";

            // display the result in a message box

            MessageBox.Show(strMessage, "Calories Per Gram", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
                       
            // reset the form for fresh inputs

            nudFat.Value = 0;
            nudCarbs.Value = 0;
            nudProtein.Value = 0;

            nudFat.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // close the form

            this.Close();
        }

    }
}
