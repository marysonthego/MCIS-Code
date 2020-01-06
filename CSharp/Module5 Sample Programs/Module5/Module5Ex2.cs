/*
 * Project:         Module 5; Example 2
 * Date:            October 2018
 * Developed By:    LV
 * Class Name:      Module5Ex2 - Presentation Layer
 * Purpose:         Demonstrates methods and property of the items collection of a combo box
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
    public partial class Module5Ex2 : Form
    {
        public Module5Ex2()
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
            else
            {
                cboMWC.Items.Add(cboMWC.Text); //adds the new member to the list
                MessageBox.Show("New member added", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                cboMWC.Text = string.Empty;
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (cboMWC.Text == string.Empty)
            {
                MessageBox.Show("Enter a new member", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                cboMWC.Items.Insert(3,cboMWC.Text); //adds the new member to the fourth (arbitrarily, just for demonstration) position on the list
                MessageBox.Show("New member added", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                cboMWC.Text = string.Empty;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (cboMWC.SelectedIndex == -1)
            {
                MessageBox.Show("Select the member to remove", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                cboMWC.Items.RemoveAt(cboMWC.SelectedIndex); //remove selected member from list
                MessageBox.Show("Member removed", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMWC.Text = string.Empty;
            }
        }

        private void btnRemoveAlt_Click(object sender, EventArgs e)
        {
            if (txtRemove.Text == string.Empty)
            {
                MessageBox.Show("Enter a member to remove", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                TextInfo aTextInfo = new CultureInfo("en-US", false).TextInfo; //create a TextInfo object based on "en-US" culture

                string removeMember = aTextInfo.ToTitleCase(txtRemove.Text);  //change the name of the member to be removed to titlecase - to facilitate proper comparison with the items on the list

                if (cboMWC.Items.Contains(removeMember)) // if the member to remove is on the list
                {
                    cboMWC.Items.Remove(removeMember); // remove the member
                    MessageBox.Show("Member removed", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtRemove.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Member is not on list", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtRemove.Focus();
                }
             }
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"There are {cboMWC.Items.Count} members in the MWC", "Member Count", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult aResult = MessageBox.Show("Clear the list?", "Caution", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (aResult == DialogResult.Yes)
            {
                cboMWC.Items.Clear();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
