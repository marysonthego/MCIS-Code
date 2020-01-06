/*
 * Project:         Module 5; Example 3
 * Date:            October 2018
 * Developed By:    LV
 * Class Name:      Module5Ex3 - Presentation Layer
 * Purpose:         Demonstrates adding and removing items to a list with pre-checks done with                    loops
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
using System.Globalization; // additional namespace

namespace Module5
{
    public partial class Module5Ex3 : Form
    {
        public Module5Ex3()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cboMWC.Text == string.Empty)
            {
                MessageBox.Show("Enter a new member", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string newMember = cboMWC.Text;  //assign the new member to be added to a variable
            bool duplicate = false;  // duplication indicator 

            //a foreach loop to iterate through the items in the list and check for potential duplication

            foreach (string aItem in cboMWC.Items) //for each item in the combo box
            {
                if (string.Equals(newMember, aItem, StringComparison.OrdinalIgnoreCase)) //ignoring case, compare each member in the list to the member to be added
                {
                    duplicate = true; //if the member already exists in the list, set duplication indicator to true
                    break; //break out of the loop
                }
            }

            if (duplicate)  //if duplicate is true, new member is not added
            {
                MessageBox.Show("Member not added", "Duplicate member", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMWC.Text = string.Empty;
            }
            else  //otherwise, new member is added
            {
                TextInfo aTextInfo = new CultureInfo("en-US", false).TextInfo; //create a TextInfo object based on "en-US" culture

                newMember = aTextInfo.ToTitleCase(newMember); //change the name of the new member to be added to proper case

                cboMWC.Items.Add(newMember); //add the new member to the list
                MessageBox.Show("New member added", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMWC.Text = string.Empty;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (txtRemove.Text == string.Empty)
            {
                MessageBox.Show("Enter a member to remove", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string removeMember = txtRemove.Text;  //assign the member to be removed to a variable
            bool inList = false; // variable to capture whether member to be removed is in the list
            int removeIndex = 0; // variable to capture the index of the member to be removed

            //a for loop to iterate through the items in the list to check whether the member to be removed is in the list

            for (int i = 0; i <= cboMWC.Items.Count -1; ++i) //why count - 1?; index of the items in the list starts at 0
            {
                if (string.Equals(removeMember, cboMWC.Items[i].ToString(), StringComparison.OrdinalIgnoreCase)) //ignoring case, compare each member in the list to the member to be dropped
                {
                    inList = true; //if the member to be dropped is in the list, set inList to true
                    removeIndex = i; // assign the index of the member to be removed
                    break; // break out of the loop
                }
            }

            if (inList)  //if inList is true, drop the member
            {
                cboMWC.Items.RemoveAt(removeIndex); // remove the member
                MessageBox.Show("Member removed", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtRemove.Text = string.Empty;
            }
            else  //otherwise, member is not removed
            {
                MessageBox.Show("Member is not on list", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtRemove.Focus();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
