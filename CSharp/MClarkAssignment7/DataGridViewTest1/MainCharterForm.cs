/*
 * Class MainCharterForm
 * - is the primary form in the project. 
 * Developer: Mary Clark
 * December, 2018 for CIS605
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

namespace MClarkAssignment7
{
    public partial class MainCharterForm : Form
    {
        internal CharterManager aCharterManager;
        bool addNewYacht = false;

        public MainCharterForm()
        {
            InitializeComponent();
        }

        /*
         * CharterListForm_Load instantiates the CharterManager instance
         * and defines the binding source for CharterList
         */
        private void CharterListForm_Load(object sender, EventArgs e)
        {
            if (aCharterManager is null)
            {
                aCharterManager = new CharterManager();
                // set the DataGridView to display the charters in the list collection
                charterManagerBindingSource.DataSource = aCharterManager;
                charterManagerBindingSource.DataMember = "CharterList";
            }

        }

        /*
         * An Add Charter button that validates the input data 
         * (e.g., customer name is entered, yacht type and size are selected), 
         * instantiates a YatchManager object (one time only; when the first charter is added),
         * calls the appropriate method on the YatchManager object to add the charter
         * enables the three menu items within the Display menu
         */
        private void btnAddCharter_Click(object sender, EventArgs e)
        {
            //NOTE: The logic to instantiate a CharterManager in CharterListForm_Load

            DialogResult dialogResult;
            int size;

            //Validate Customer Name
            if (String.IsNullOrEmpty(tBoxCustomerName.Text))
            {
                dialogResult = MessageBox.Show(this,"Please enter the customer name", "Error: Missing Customer Name", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //Validate Yacht Type
            if (String.IsNullOrEmpty(cBoxYachtType.Text)) //No selection
            {
                dialogResult = MessageBox.Show(this, "Please select the yacht type", "Error: No yacht type selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else //Yacht Type not in the list
            {
                int index = cBoxYachtType.FindStringExact(cBoxYachtType.Text);
                if (index == -1) //User typed in a name not in the list
                {
                    MessageBox.Show(this, $"Unknown yacht type {cBoxYachtType.Text}. Please select a yacht type from the list. To add a new yacht type, right-click and select \"Add Yacht Type\"", "Error: Unknown Yacht Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cBoxYachtType.ResetText();
                    return;
                }
            }

            //Validate Yacht Size
            if (String.IsNullOrEmpty(listBoxYachtSize.Text))
            {
                dialogResult = MessageBox.Show(this, "Please select the yacht size", "Error: Yacht size not selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
                size = Convert.ToInt32(listBoxYachtSize.Text);

            //Validate Charter Hours
            if (nudCharterHours.Value == 0)
            {
                dialogResult = MessageBox.Show(this, "Please select the number of hours", "Error: Hours not selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //For singleton implementation
            //aCharterManager = CharterManager.instance;

            //Add the charter
            aCharterManager.AddCharter(tBoxCustomerName.Text, cBoxYachtType.Text, size, Convert.ToInt32(nudCharterHours.Value));
            dialogResult = MessageBox.Show(this, $"Added charter for {tBoxCustomerName.Text}.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            allChartersToolStripMenuItem.Enabled = true;
            numberOfChartersByYachtSizeToolStripMenuItem.Enabled = true;
            summaryOfChartersToolStripMenuItem.Enabled = true;
        }

        /*
         * The exit event writes out an updated CharterFile
         */
        private void btnExit_Click(object sender, EventArgs e)
        {
            aCharterManager.CreateCharterFile();
            Close();
        }

        /*
         * The All Charters menu item should display (in another form) all the charters 
         * in a DataGridView. Display your name and an appropriate title at the top of the form
         */
        private void allChartersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListChartersForm aForm = new ListChartersForm();
            aForm.charterManagerBindingSource.DataSource = aCharterManager;
            aForm.Show();
        }

        /*
         * The Number of Charters for a Yacht Size menu item 
         * should display (in a message box) the number of charters 
         * for a specific yacht size selected by the user from the 
         * drop-down combo box. Make sure the user has selected a 
         * yacht size before calling the method in the CharterManger class.
        */
        private void numberOfChartersByYachtSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            int size;
            if (String.IsNullOrEmpty(listBoxYachtSize.Text))
            {
                dialogResult = MessageBox.Show("Please select the yacht size", "Error: No yacht size selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                size = Convert.ToInt32(listBoxYachtSize.Text);
                int count = aCharterManager.GetCharterCountBySize(size);
                dialogResult = MessageBox.Show($"Charter count for yacht size {size} is {count}", $"Charter Count for size {size}", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /*
         * The Charters Summary menu item should display (in another form) the lowest charter 
         * fee, the total fees from all charters, and the average fee of all the charters. 
         * Display your name and an appropriate title at the top of the form
         * - Added a Count to display the number of items in the CharterList.
         */
        private void summaryOfChartersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CharterSummaryForm summaryForm = new CharterSummaryForm();

            summaryForm.lblLowestCharterFee.Text = aCharterManager.FindLowestCharterFee().ToString("c");
            summaryForm.lblAverageFee.Text = aCharterManager.GetAverageCharterFee().ToString("c");
            summaryForm.lblTotalFees.Text = aCharterManager.GetTotalCharterFees().ToString("c");
            summaryForm.lblCharterCount.Text = aCharterManager.CharterList.Count.ToString("n0");
            summaryForm.Show();
        }

        /*
         * Reset all items on the form to default values
         */
        private void ResetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tBoxCustomerName.ResetText();
            listBoxYachtSize.SelectedItem = null;
            cBoxYachtType.ResetText();
            cBoxYachtType.SelectedIndex = -1;
            nudCharterHours.Value = 0m;
        }

        /*
         * Event is also called by addYachtTypeContextMenuItem1
         */
        private void addYachtTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addNewYacht = true;
            cBoxYachtType.Focus();
        }

        /*
         * Validate new yacht type entries from the user
         */
        private void cBoxYachtType_AddNewYacht()
        {
            Console.WriteLine($"AddNewYacht cBoxYachtType.Text:{cBoxYachtType.Text}");

            if (String.IsNullOrEmpty(cBoxYachtType.Text)) //User hit enter without typing anything
            {
                MessageBox.Show(this, "An empty string cannot be added.", "Error: Empty String", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else //new item entered
            {
                cBoxYachtType.Items.Add(cBoxYachtType.Text);
                MessageBox.Show(this, $"The item {cBoxYachtType.Text} was added", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /*
         * Event is also called by removeYachtTypeContextMenuItem2
         */
        private void removeYachtTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cBoxYachtType.SelectedIndex == -1)
            {
                MessageBox.Show(this, $"Select the yacht type to remove.", "Error: No yacht type selected.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string itemRemoved = cBoxYachtType.Text;
                cBoxYachtType.Items.RemoveAt(cBoxYachtType.SelectedIndex);
                MessageBox.Show(this, $"{itemRemoved} was removed", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /*
         * Select the existing yacht type equivalent to the string the user typed in
         * or create a new yacht type if they have clicked the Add New Yacht menu/context item
         */
        private void cBoxYachtType_Leave(object sender, EventArgs e)
        {
            Console.WriteLine($"Leave cBoxYachtType.Text:{cBoxYachtType.Text} cBoxYachtType.SelectedIndex:{cBoxYachtType.SelectedIndex}");
            if (cBoxYachtType.SelectedIndex == -1)
            {
                if (cBoxYachtType.Items.Contains(cBoxYachtType.Text))
                    cBoxYachtType.SelectedIndex = cBoxYachtType.Items.IndexOf(cBoxYachtType.Text);
                else if (addNewYacht)
                    cBoxYachtType_AddNewYacht();
                else
                   cBoxYachtType.ResetText();
                addNewYacht = false;
            }
        }
    }
}
