/*
 * Project:         Module 8; Example 2
 * Date:            November 2018
 * Developed By:    LV
 * Class Name:      Module8Ex2 - Presentation Layer
 * Purpose:         Demonstrates Tab Control, DataGridView
 * Uses:            Food and FoodManager class
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

namespace Module8
{
    public partial class Module8Ex2 : Form
    {
        public Module8Ex2()
        {
            InitializeComponent();
        }

        // declare a class/module level variable of type FoodManager

        private FoodManager aFoodManager;

        private void Module8Ex2_Load(object sender, EventArgs e)
        {
            //set the comboboxes to display the elements in the FoodGroup enumeration

            cboFoodGroup.DataSource = Enum.GetValues(typeof(FoodGroup));
            cboFoodType.DataSource = Enum.GetValues(typeof(FoodGroup));
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // declare local (i.e., method-level) variables

            string foodName;
            FoodGroup aGroup;
            int fatGrams, carbGrams, proteinGrams, foodCalories;

            Food aFood;

            // assign input data to variables

            foodName = txtFoodName.Text;

            //cast the SelectedValue to a FoodGroup enumeration and assign it to aGroup

            aGroup = (FoodGroup)cboFoodGroup.SelectedValue;
            
            fatGrams = Convert.ToInt32(nudFat.Value);
            carbGrams = Convert.ToInt32(nudCarbs.Value);
            proteinGrams = Convert.ToInt32(nudProtein.Value);

            // instantiate a food object

            aFood = new Food(foodName, aGroup, fatGrams, carbGrams, proteinGrams);

            // access the calories property

            foodCalories = aFood.Calories;

            // display calories

            lblCalories.Text = foodCalories.ToString("n0");

            // if it is not already instantiated, instantiate aFoodManager 

            if (aFoodManager is null)
            {
                aFoodManager = new FoodManager();

                // set the DataGridView to display the food objects in the list collection

                foodListBindingSource.DataSource = aFoodManager;
                foodListBindingSource.DataMember = "FoodList";
            }
 
            // add food object to the FoodObjects collection

            aFoodManager.AddFood(aFood);

            // disable controls

            grpFoodInfo.Enabled = false;
            grpFoodStats.Enabled = true;
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            // get and display the number of food objects in the list collection

            lblCount.Text = aFoodManager.GetFoodCount().ToString();
        }

        private void btnCountOfType_Click(object sender, EventArgs e)
        {
            // get and display the number of food objects of a specific FoodGroup in the list collection

            FoodGroup aGroup = (FoodGroup)cboFoodType.SelectedValue;

            lblCountOf.Text = aFoodManager.GetFoodCount(aGroup).ToString();
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            // get and display the total calories of the food objects in the list collection

            lblTotalCalories.Text = aFoodManager.GetTotalCalories().ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // reset the form for fresh inputs

            txtFoodName.Clear();
            cboFoodGroup.SelectedIndex = 0;
            cboFoodType.SelectedIndex = 0;
            nudFat.Value = 0;
            nudCarbs.Value = 0;
            nudProtein.Value = 0;
            lblCount.Text = null;
            lblCountOf.Text = null;
            lblTotalCalories.Text = null;
            lblCalories.Text = null;
            
            // enable controls

            grpFoodInfo.Enabled = true;
            
            //set focus

            txtFoodName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // close the form

            Application.Exit();
        }
    }
}
