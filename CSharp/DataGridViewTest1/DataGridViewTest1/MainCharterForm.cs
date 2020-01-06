using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewTest1
{
    public partial class MainCharterForm : Form
    {
        internal CharterManager aCharterManager;

        public MainCharterForm()
        {
            InitializeComponent();
        }

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

        private void btnAddCharter_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            int size;

            if (String.IsNullOrEmpty(tBoxCustomerName.Text))
            {
                dialogResult = MessageBox.Show("Please enter the customer name", "Error: Missing Customer Name", MessageBoxButtons.OK);
                return;
            }
            if (String.IsNullOrEmpty(listBoxYachtTypes.Text))
            {
                dialogResult = MessageBox.Show("Please select the yacht type", "Error: No yacht type selected", MessageBoxButtons.OK);
                return;
            }
            if (String.IsNullOrEmpty(listBoxYachtSize.Text))
            {
                dialogResult = MessageBox.Show("Please select the yacht size", "Error: No yacht size selected", MessageBoxButtons.OK);
                return;
            }
            else
                size = Convert.ToInt32(listBoxYachtSize.Text);
            if (nudCharterHours.Value == 0)
            {
                dialogResult = MessageBox.Show("Please select the number of hours", "Error: Hours not selected", MessageBoxButtons.OK);
                return;
            }
            //For singleton implementation
            //aCharterManager = CharterManager.instance;

            aCharterManager.AddCharter(tBoxCustomerName.Text, listBoxYachtTypes.Text, size, nudCharterHours.Value);

            allChartersToolStripMenuItem.Enabled = true;
            numberOfChartersByYachtSizeToolStripMenuItem.Enabled = true;
            summaryOfChartersToolStripMenuItem.Enabled = true;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            aCharterManager.CreateCharterFile();
            Close();
        }

        private void allChartersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListChartersForm aForm = new ListChartersForm();
            aForm.charterManagerBindingSource.DataSource = aCharterManager;
            aForm.Show();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
