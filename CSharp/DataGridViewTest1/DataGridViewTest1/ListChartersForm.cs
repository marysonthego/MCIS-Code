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
    public partial class ListChartersForm : Form
    {
        public ListChartersForm()
        {
            InitializeComponent();
        }

        private void ListChartersForm_Load(object sender, EventArgs e)
        {
            //if (Program.aMainCharterForm.aCharterManager is null)
            {
                //aCharterManager = new CharterManager();

                // set the DataGridView to display the charters in the list collection

                charterManagerBindingSource.DataSource = Program.aMainCharterForm.aCharterManager;
                charterManagerBindingSource.DataMember = "CharterList";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
