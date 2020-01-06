/*
 * Project:         Module 8; Example 1
 * Date:            November 2018
 * Developed By:    LV
 * Class Name:      Module8Ex1
 * Purpose:         Demonstrate Menu, Status Bar, Dialog Box, and Timer controls
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

namespace Module8
{
    public partial class Module8Ex1 : Form
    {
        public Module8Ex1()
        {
            InitializeComponent();
        }

        private void Module8Ex1_Load(object sender, EventArgs e)
        {
            // set the second panel of the status bar to display today's date

            stbPanel2.Text = DateTime.Today.ToShortDateString();

            // alternatively

            // stbInfo.Items[1].Text = DateTime.Today.ToShortDateString();

            // set the third panel of the status bar to display the current time

            stbPanel3.Text = DateTime.Now.ToLongTimeString();

            // alternatively

            // stbInfo.Items[2].Text = DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // the Timer fires a Tick event every second; updating the time displayed in the status bar

            stbPanel3.Text = DateTime.Now.ToLongTimeString();
        }
         
        private void mnuFileOpen_Click(object sender, EventArgs e)
        {
            // display the File Open Dialog box

            openFileDialog1.ShowDialog();
        }

        private void mnuFileSaveAs_Click(object sender, EventArgs e)
        {
            // display the Save File Dialog box

            saveFileDialog1.ShowDialog();
        }

        private void mnuEditFont_Click(object sender, EventArgs e)
        {
            // display the Font Dialog box

            fontDialog1.ShowDialog();

            // set the Font of the label to the selected font

            lblQuote.Font = fontDialog1.Font;
        }

        private void mnuEditColor_Click(object sender, EventArgs e)
        {
            // display the Color Dialog box

            colorDialog1.ShowDialog();

            // set the ForeColor of the label to the selected color

            lblQuote.ForeColor = colorDialog1.Color;
            
        }

        private void mnuViewToolBar_Click(object sender, EventArgs e)
        {
            // toggle the Checked property of the ViewToolBar menu item

            mnuViewToolBar.Checked = !mnuViewToolBar.Checked;
        }

        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
