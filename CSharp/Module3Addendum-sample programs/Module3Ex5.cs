/*
 * Project:         Module 3; Example 5
 * Date:            September 2018
 * Developed By:    LV
 * Class Name:      Module3Ex5 - Presentation Layer
 * Purpose:         Demonstrates using a class with instance and static members
 * Uses:            Food5 class
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
    public partial class Module3Ex5 : Form
    {
        
        public Module3Ex5()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // declare local (i.e., method-level) variables

            string foodName;
            int fatGrams, carbGrams, proteinGrams, foodCalories;

            Food5 aFood;

            // assign input data to variables

            foodName = txtFoodName.Text;
            
            fatGrams = Convert.ToInt32(nudFat.Value);
            carbGrams = Convert.ToInt32(nudCarbs.Value);
            proteinGrams = Convert.ToInt32(nudProtein.Value);

            // instantiate a food object

            aFood = new Food5(foodName, fatGrams, carbGrams, proteinGrams);

            // access the calories property

            foodCalories = aFood.Calories;

            // display calories

            lblCalories.Text = foodCalories.ToString("n0");

            // disable controls

            grpFoodInfo.Enabled = false;
            btnCreate.Enabled = false;
        }

        private void btnSummary_Click(object sender, EventArgs e)
        {
            // prepare message to display

            string strMessage = $" Number of Food Items: {Food5.NumFoodItems.ToString("n0")} \n Total Calories: {Food5.TotalCalories.ToString("n0")} \n Average Calories: {Food5.CalculateAverageCalories().ToString("n2")}";

            // display the result in a message box

            MessageBox.Show(strMessage, "Summary", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // reset the form for fresh inputs

            txtFoodName.Clear();
            nudFat.Value = 0;
            nudCarbs.Value = 0;
            nudProtein.Value = 0;
            lblCalories.Text = null;
            
            // enable controls

            grpFoodInfo.Enabled = true;
            btnCreate.Enabled = true;

            //set focus

            txtFoodName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // close the form

            this.Close();
        }
  
    }
}
