/*
 * Project:         Module 6; Example 3
 * Date:            October 2018
 * Developed By:    LV
 * Class Name:      Module6Ex3 - Presentation Layer
 * Purpose:         Test ScoreCard class (two-dimensional array); Demonstrate jagged array
 * Uses:            ScoeCard class
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
    public partial class Module6Ex3 : Form
    {

        //declare class level object variable

        private ScoreCard aCard;

        public Module6Ex3()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // assign player name to pName

            string pName = txtName.Text;

            // assign the four text boxes to an array
            // use a loop to process each textbox in the array

            TextBox[] roundBoxes = { txtRound1, txtRound2, txtRound3, txtRound4 };

            // a jagged array is an array of arrays
            // it is an array whose elements are arrays
            
            // use a jagged array to store the scores of each round as an array
            // create a one-dimensional array with four elements.
            // each of the four elements is also a one-dimensional array

            int[][] roundScores = new int[4][];

            for (int round = 0; round < 4; ++round)
            {
                // split each hole score in the round using tab (\t) as the split character

                string[] tempStrScores = roundBoxes[round].Text.Split(new char[] { '\t' }, StringSplitOptions.RemoveEmptyEntries);

                // convert the string array to an int and assign to roundScores array

                int[] tempIntScores = Array.ConvertAll(tempStrScores, int.Parse);

                roundScores[round] = tempIntScores;
            }

            // create a two-dimensional array with the data from the jagged array

            int[,] scoresByRound = new int[4, 18];

            for (int row = 0; row < 4; ++row)
            {
                for (int col = 0; col < 18; ++col)
                {
                    scoresByRound[row, col] = roundScores[row][col];
                }
            }

            // instantiate ScoreCard object

            aCard = new ScoreCard(pName, scoresByRound);

            // disable/enable controls

            grpScoreInfo.Enabled = false;
            grpStats.Enabled = true;
        }

        private void btnHoleAverages_Click(object sender, EventArgs e)
        {
            lstHoleAverages.DataSource = aCard.CalcAverageScoresByHole();
        }

        private void btnRoundTotals_Click(object sender, EventArgs e)
        {
            lstRoundTotals.DataSource = aCard.CalcTotalScoresByRound();
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            lblTotal.Text = aCard.CalcTotalScore().ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // reset the form for fresh inputs

            foreach (Control aControl in grpScoreInfo.Controls)
            {
                if (aControl is TextBox)
                    aControl.Text = null;

                lstHoleAverages.DataSource = null;
                lstRoundTotals.DataSource = null;
                lblTotal.Text = null;

                // enable/disable controls

                grpScoreInfo.Enabled = true;
                grpStats.Enabled = false;

                // set focus

                txtName.Focus();
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            // declare variable of type DialogResult

            DialogResult aResult;

            // assign the return value to the variable

            aResult = MessageBox.Show("Do you wish to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            // take action based on the value of aResult

            if (aResult == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                txtName.Focus();
            }
        }
    }
}