/*
 * Project:         Module 3; Example 2
 * Date:            September 2018
 * Developed By:    LV
 * Class Name:      Module3Ex2 - Presentation Layer
 * Purpose:         Demonstrates how to instantiate and use an object
 * Uses:            Food2 class
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

namespace Module3
{
    public partial class Module3Ex2 : Form
    {
        
        public Module3Ex2()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // declare local (i.e., method-level) variables

            string foodName;
            int fatGrams, carbGrams, proteinGrams, foodCalories;

            Food2 aFood;

            // assign input data to variables

            foodName = txtFoodName.Text;
            
            fatGrams = Convert.ToInt32(nudFat.Value);
            carbGrams = Convert.ToInt32(nudCarbs.Value);
            proteinGrams = Convert.ToInt32(nudProtein.Value);

            // instantiate a food object

            aFood = new Food2(foodName, fatGrams, carbGrams, proteinGrams);

            //another way to instantiate and initialize its properties

            // aFood = new Food2() { FoodName = foodName, FatGrams = fatGrams, CarbGrams = carbGrams, ProteinGrams = proteinGrams };

            // call the calories method

            foodCalories = aFood.CalculateCalories();

            // display calories

            lblCalories.Text = foodCalories.ToString("n0");

            // disable controls

            grpFoodInfo.Enabled = false;
            btnCreate.Enabled = false;
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
