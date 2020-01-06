/*
 * Project:         Module 9; Example 2
 * Date:            November 2018
 * Developed By:    LV
 * Class Name:      Module9Ex2 - Summary Form
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
    public partial class Module9Ex2Summary : Form
    {
        public Module9Ex2Summary()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
