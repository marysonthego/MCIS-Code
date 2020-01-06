using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program6
{
    public partial class WalkForm : Form
    {
        public WalkForm()
        {
            InitializeComponent();
        }
        string name;
        int numSteps;
        int stepLength;
        string textBoxNameInitialValue = "Enter your name here";
        decimal nudStepsInitialValue = 10000;
        decimal nudLengthInitialValue = 36;
        string lblResultInitialValue = "Miles Walked";

        private void btnWalk_Click(object sender, EventArgs e)
        {
            name = textBoxName.Text;
            numSteps = Convert.ToInt32(nudSteps.Value);
            stepLength = Convert.ToInt32(nudLength.Value);
            Walk aWalk = new Walk(name, numSteps, stepLength);
            lblResult.Text = aWalk.CalcMilesWalked().ToString("n") + " " + lblResultInitialValue;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textBoxName.Text = textBoxNameInitialValue;
            nudSteps.Value = nudStepsInitialValue;
            nudLength.Value = nudLengthInitialValue;
            lblResult.Text = lblResultInitialValue;
            textBoxName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
