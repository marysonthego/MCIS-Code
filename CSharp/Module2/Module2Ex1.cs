/*
 * Project:         Module 2; Example 1
 * Date:            August 2018
 * Developed By:    LV
 * Class Name:      Module2Ex1
 * Description:     Presentation Layer class for calculating the caloric valve of a food item
 * Purpose:         Demonstrates variables; Parse and ToString methods
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
    public partial class Module2Ex1 : Form
    {
        public Module2Ex1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // declare variables

            int intFatGrams, intCarbsGrams, intProteinGrams, intFoodCalories;

            Food aFood;

            // parse the input data and assign to variables

            intFatGrams = int.Parse(txtFat.Text);
            intCarbsGrams = int.Parse(txtCarbs.Text);
            intProteinGrams = int.Parse(txtProtein.Text);

            // instantiate a food object

            aFood = new Food();

            // call the CalculateCalories method

            intFoodCalories = aFood.CalculateCalories(intFatGrams, intCarbsGrams, intProteinGrams);

            //display the result

            LblCalories.Text = intFoodCalories.ToString("n0");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // reset the form for fresh inputs

            txtFat.Clear();
            txtCarbs.Clear();
            txtProtein.Clear();

            LblCalories.Text = string.Empty;

            txtFat.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // close the form

            this.Close();
        }
    }
}
