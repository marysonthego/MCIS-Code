/*
 * Project:         Module 9; Example 2
 * Date:            November 2018
 * Developed By:    LV
 * Class Name:      Module9Ex2 - Main Form
 * Purpose:         Demonstrates DataGridView; Multiple Forms
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

namespace Module9
{
    public partial class Module9Ex2Main : Form
    {
        public Module9Ex2Main()
        {
            InitializeComponent();
        }

        // declare a class/module level variable of type FoodManager

        private FoodManager aManager;

        private void Module9Ex2_Load(object sender, EventArgs e)
        {
            // instantiate the FoodManager object

            aManager = new FoodManager();

            // set the DataGridView to display the food objects in the list collection

            foodManagerBindingSource.DataSource = aManager;
        }

        private void btnSummary_Click(object sender, EventArgs e)
        {
            // create an instance of the Summary Form

            Module9Ex2Summary aForm = new Module9Ex2Summary();

            // set the labels in the form to display summary information

            aForm.lblCount.Text = aManager.GetFoodCount().ToString("n0");

            aForm.lblTotalCalories.Text = aManager.GetTotalCalories().ToString("n0");

            // show the form

            aForm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // close the form

            Application.Exit();
        }

        private void Module9Ex2_FormClosing(object sender, FormClosingEventArgs e)
        {
            // check if user wishes to save the data

            DialogResult aResult = MessageBox.Show("Save food data?", "Save?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // if yes, save the food data

                if (aResult == DialogResult.Yes)
                    aManager.SaveFoodObjects();
        }
    }
}
