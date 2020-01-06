/*
 * Project:         Module 5; Example 1
 * Date:            October 2018
 * Developed By:    LV
 * Class Name:      Module5Ex1 - Presentation Layer
 * Purpose:         Demonstrates List and Combo Boxes
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

namespace Module5
{
    public partial class Module5Ex1 : Form
    {
        public Module5Ex1()
        {
            InitializeComponent();
        }

        private void btnNickName_Click(object sender, EventArgs e)
        {
            if (cboMWC.SelectedIndex == -1)  //if an item is not selected
            {
                MessageBox.Show("Choose a University", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nickName = string.Empty;

            //assign nickname associated with the selected university to nickName
            
            switch (cboMWC.SelectedIndex)
            {
                case 0:
                    nickName = "Falcons";
                    break;
                case 1:
                    nickName = "Broncos";
                    break;
                case 2:
                    nickName = "Rams";
                    break;
                case 3:
                    nickName = "Bulldogs";
                    break;
                case 4:
                    nickName = "Rainbow Warriors";
                    break;
                case 5:
                    nickName = "Wolf Pack";
                    break;
                case 6:
                    nickName = "Lobos";
                    break;
                case 7:
                    nickName = "Aztecs";
                    break;
                case 8:
                    nickName = "Spartans";
                    break;
                case 9:
                    nickName = "Rebels";
                    break;
                case 10:
                    nickName = "Aggies";
                    break;
                case 11:
                    nickName = "Cowboys, Cowgirls";
                    break;
            }

            lblNickName.Text = nickName;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
