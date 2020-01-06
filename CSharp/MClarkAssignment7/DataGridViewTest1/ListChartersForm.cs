/*
 * Class ListChartersForm is a secondary form that displays the list of
 * Charter items in a datagridview.
 * This form supports deleting multiple charters with a context menu strip.
 * The user can select multiple rows. Right-clicking on any selected row
 * displays a Delete context menu item which allows the user to delete all the
 * selected rows from the CharterList.
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
    public partial class ListChartersForm : Form
    {
        public ListChartersForm()
        {
            InitializeComponent();
        }

        private void ListChartersForm_Load(object sender, EventArgs e)
        {
            // set the DataGridView to display the charters in the list collection
            charterManagerBindingSource.DataSource = Program.aMainCharterForm.aCharterManager;
            charterManagerBindingSource.DataMember = "CharterList";
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
            }
        }
    }
}
