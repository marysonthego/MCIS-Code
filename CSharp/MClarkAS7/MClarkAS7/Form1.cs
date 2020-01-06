using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MClarkAS7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       /* public void Form1_Load(object sender, EventArgs e)
        {
          private CharterManager aManager;
          aManager = new CharterManager();
          charterManagerBindingSource.DataSource = aManager;
          dataGridView1.DataSource = charterManagerBindingSource;
        }
         */                             
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("cell content click", "cell content click", MessageBoxButtons.OK);
        }

        private void charterManagerBindingSource_AddingNew(object sender, EventArgs e)
        {

            // e.NewObject = charterManagerBindingSource.
            DialogResult dialogResult = MessageBox.Show("adding new", "adding new", MessageBoxButtons.OK);
        }

        private void charterManagerBindingSource_ListChanged(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("List Changed", "List Changed", MessageBoxButtons.OK);
        }

        private void charterManagerBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("current changed", "current changed", MessageBoxButtons.OK);
        }
    }
}
