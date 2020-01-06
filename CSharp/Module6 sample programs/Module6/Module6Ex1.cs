/*
 * Project:         Module 6; Example 1
 * Date:            October 2018
 * Developed By:    LV
 * Class Name:      Module6Ex1 - Presentation Layer
 * Purpose:         Demonstrates Arrays
 * Uses:            LottoTicket
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

namespace Module6
{
    public partial class Module6Ex1 : Form
    {
        public Module6Ex1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // declare and instantiate a LottoTicket object

            LottoTicket aTicket = new LottoTicket();

            // display the ticket numbers in the ListBox
            // listboxes have a datasource property that can be set to a valid data source such as an array 

            lstLottoNumbers.DataSource = aTicket.LottoNumbers;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
