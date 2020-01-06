/*
 * Project:         Module 9; Example 1
 * Date:            November 2018
 * Developed By:    LV
 * Class Name:      Module9Ex1 - Presentation Layer
 * Purpose:         Demonstrates Tab Control, DataGridView; Exception Handling
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
using System.IO;

namespace Module9
{
    public partial class Module9Ex1 : Form
    {
        public Module9Ex1()
        {
            InitializeComponent();
        }

        // declare a class/module level variable of type FoodManager

        private FoodManager aFoodManager;

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // declare local (i.e., method-level) variables

            string foodName;
            int fatGrams, carbGrams, proteinGrams, foodCalories;

            Food aFood;

            // assign input data to variables

            foodName = txtFoodName.Text;

            fatGrams = Convert.ToInt32(nudFat.Value);
            carbGrams = Convert.ToInt32(nudCarbs.Value);
            proteinGrams = Convert.ToInt32(nudProtein.Value);

            // instantiate a food object

            aFood = new Food(foodName, fatGrams, carbGrams, proteinGrams);

            // access the calories property

            foodCalories = aFood.Calories;

            // display calories

            lblCalories.Text = foodCalories.ToString("n0");

            // if it is not already instantiated, instantiate aFoodManager 

            if (aFoodManager is null)
            {
                aFoodManager = new FoodManager();

                // set the DataGridView to display the food objects in the list collection

                foodManagerBindingSource.DataSource = aFoodManager;
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

        private void btnTotal_Click(object sender, EventArgs e)
        {
            // get and display the total calories of the food objects in the list collection

            lblTotalCalories.Text = aFoodManager.GetTotalCalories().ToString("n0");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // reset the form for fresh inputs

            txtFoodName.Clear();
            nudFat.Value = 0;
            nudCarbs.Value = 0;
            nudProtein.Value = 0;
            lblCount.Text = null;
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

        private void Module9Ex1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // a try block encloses statements that may or may not cause an exception

            try
            {
                // check if user wishes to save the data

                DialogResult aResult = MessageBox.Show("Save food data?", "Save?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // if yes, save the food data

                if (aResult == DialogResult.Yes)
                    aFoodManager.SaveFoodObjects();
            }

            // a try block should be immediately followed by at least one catch block OR finally block 
            // if a try block is followed by at least one catch block, the finally block is optional
            // a try block can be followed by more than one catch block
            // a catch block "catches" one type of exception - either an Exception object or an object of one of its child classes
            // a catch block contains code to address the "caught" exception

            // if an IO exception occurs

            catch (IOException error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // if any type of exception occurs

            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                        
            finally
            {
                // code that should execute, irrespective of whether an exception occurred or not
            }
        }
    }
}
