using System;
using System.Windows.Forms;

namespace MClarkAS7
{
    public partial class FormCharterManager : Form
    {
        CharterManager aCharterManager;
        FormAllCharters aFormAllCharters;

        public FormCharterManager()
        {
            InitializeComponent();
        }

        /*
         * Instantiate a 2nd form, FormAllCharters, and display it
         * when the All Charters menu item is clicked.
         */
        private void allChartersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (aCharterManager is null)
            {
                aCharterManager = CharterManager.instance;
                aFormAllCharters = new FormAllCharters();
                aFormAllCharters.Show(this);
            }
        }

        /*
         * When the Add Charter Button is clicked, validate the Customer Name,
         * Yacht Type, and Yacht Size. Ensure that something was selected or
         * entered for each.
         * Set aCharterManager to the singleton instance.
         * If all is well, call AddCharter on the singleton instance 
         * to add the new charter to the CharterList and 
         * enable the All Charters, Number of Charters, and
         * Charter Summary menu items.
         */
        private void btnAddCharter_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;

            if (tBoxCustomerName.TextLength == 0)
            {
                dialogResult = MessageBox.Show("Please enter the customer name", "Error: Missing Customer Name", MessageBoxButtons.OK);
                return;
            }
            if (cBoxYachtTypes.Text == null)
            {
                dialogResult = MessageBox.Show("Please select the yacht type", "Error: No yacht type selected", MessageBoxButtons.OK);
                return;
            }
            int size = Convert.ToInt32(lBoxYachtSize.Text);
            if (size <= 0 )
            {
                dialogResult = MessageBox.Show("Please select the yacht size", "Error: No yacht size selected", MessageBoxButtons.OK);
                return;
            }
            //For singleton implementation
            aCharterManager = CharterManager.instance;
            
            //aCharterManager = new CharterManager();

            aCharterManager.AddCharter(tBoxCustomerName.Text, cBoxYachtTypes.Text, size, nudHoursChartered.Value);

            allChartersToolStripMenuItem.Enabled = true;
            numberOfChartersForAYachtTypeToolStripMenuItem.Enabled = true;
            chartersSummaryToolStripMenuItem.Enabled = true;
        }

        /*
         * The Exit menu item closes the application
         */
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
