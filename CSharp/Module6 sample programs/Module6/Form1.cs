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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           decimal[] y = new decimal[textBox1.Lines.Length];

            for (int x = 0; x < textBox1.Lines.Length; ++x)
            {
                y[x] = decimal.Parse(textBox1.Lines[x]);
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {


            string[] stringScores = textBox2.Text.Split(new char[] { '\t' }, StringSplitOptions.RemoveEmptyEntries);

            int[] test = Array.ConvertAll(stringScores, int.Parse);

            int[] test1 = new int[] { 2, 3, 4, 4, 5, 4, 5, 6, 6, 7, 11, 7, 8, 8, 8, 2, 4, 5 };

            int[,] test2 = new int[4,18];

           for (int col = 0; col < 18; ++col)
           {
                test2[0, col] = test[col];
                test2[1, col] = test1[col];
           }
 
        }
            
    }
}
