/*
 * Class Name: MClarkAS5.Program13.NFLWinnersForm
 * 
 * Class Description: When an end user selects a team 
 * in the "NFL Teams" ComboBox, clicking the 
 * "How Many Wins?" button displays the number of 
 * times the selected team has won the Super Bowl.
 * 
 * Clicking the "How Many Back-To-Back Wins?" button
 * displays the number of times the selected team
 * has won the Super Bowl back-to-back.
 * 
 * Clicking either button before a team is selected
 * results in a MessageBox "Error: no team selected".
 * The default Retry button puts focus on the "NFL Teams"
 * ComboBox. The Cancel button exits the application.
 * 
 * NFLWinnersForm utilizes bitmap resources for each team
 * logo, the NFL logo, the NFL icon, and the background
 * image.
 * 
 * Developer Name: Mary Clark
 * Date Created: 10/26/2018
 * Date Last Modified: 10/30/2018
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;

namespace Program13
{
    /*
     * Class MClarkAS5.Program13.NFLWinnersForm
     */

    public partial class NFLWinnersForm : Form
    {
        /*
         * Create a private Dictionary object for the class
         */
        Dictionary<int, string> champsDictionary = new Dictionary<int, string>();
        
        /*
         * A private string for the selected team name
         */
        string team;

        /*
         * Constructor for NFLWinnersForm
         */
        public NFLWinnersForm()
        {
            InitializeComponent();
            LoadDictionary();
        }

        /*
         * Exit button event handler
         * 
         * Terminate the program when the Exit button is clicked
         */
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        /*
         * Event handler for "How Many Wins?" button
         * 
         * If no team is selected 
         *   display a Retry/Cancel MessageBox
         *     Retry sets focus on the "NFL Teams" Combobox
         *     Cancel terminates the program
         * Else
         *   A foreach compares each value in champsDictionary 
         *   to the selected team.
         *   
         *   Increment winCount on each match.
         *   
         *   Switch on winCount to properly format the result string.
         *   
         *   Display the result in lblResult.
         */
        private void btnWins_Click(object sender, EventArgs e)
        {
            if (cBoxAllTeams.SelectedIndex < 0)
            {
                lblResult.Visible = false;
                DialogResult dResult = MessageBox.Show(this, "Retry to select a team. Cancel to exit.", "Error: no team selected", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                if (dResult == DialogResult.Retry)
                    cBoxAllTeams.Focus();
                else
                    Close();
            }
            else
            {
                int winCount = 0;
                // To get the values alone, use the Values property.
                Dictionary<int, string>.ValueCollection valueColl =
                    champsDictionary.Values;
                foreach (string s in valueColl)
                {
                    if (s.Equals(team))
                        winCount++;
                }
                switch (winCount)
                {
                    case 0:
                        lblResult.Text = $"The {team} have never won the Super Bowl.";
                        break;
                    case 1:
                        lblResult.Text = $"The {team} have won the Super Bowl {winCount} time.";
                        break;
                    default:
                        lblResult.Text = $"The {team} have won the Super Bowl {winCount} times.";
                        break;
                }
                lblResult.Visible = true;
            }
        }

        /*
         * Event handler for "How Many Back-To-Back Wins?" button
         * 
         * If no team is selected 
         *   display a Retry/Cancel MessageBox
         *     Retry sets focus on the "NFL Teams" Combobox
         *     Cancel terminates the program
         * Else
         * Use a foreach to compare each value in champsDictionary 
         * with the selected team name. 
         * 
         * The foreach implements an algorithm which increments
         * b2bCount only if the team also won the previous year.
         * 
         * A switch on b2bCount properly formats the result string
         * 
         * The result string is displayed in lblResult
         */
        private void btnB2B_Click(object sender, EventArgs e)
        {
            if (cBoxAllTeams.SelectedIndex < 0)
            {
                lblResult.Visible = false;
                DialogResult dResult = MessageBox.Show(this, "Retry to select a team. Cancel to exit.", "Error: no team selected", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                if (dResult == DialogResult.Retry)
                    cBoxAllTeams.Focus();
                else
                    Close();
            }
            else
            {
                Dictionary<int, string>.ValueCollection valueColl =
                    champsDictionary.Values;
                int prevCount = 0;
                int b2bCount = 0;
                foreach (string s in valueColl)
                {
                    if (s.Equals(team))
                    {
                        if (prevCount > 0)
                        {
                            b2bCount++;
                            prevCount--;
                        }
                        prevCount++;
                    }
                    else
                        if (prevCount > 0)
                            prevCount--;
                }
                switch (b2bCount)
                {
                    case 0:
                        lblResult.Text = $"The {team} have never won the Super Bowl back-to-back.";
                        break;
                    case 1:
                        lblResult.Text = $"The {team} have won the Super Bowl back-to-back {b2bCount} time.";
                        break;
                    default:
                        lblResult.Text = $"The {team} have won the Super Bowl back-to-back {b2bCount} times.";
                        break;
                }
                lblResult.Visible = true;
            }
        }

        /*
         * Given that the cBoxWinners combobox is 
         * initially populated with a collection list of 
         * Super Bowl winners in order of wins:
         * 
         * LoadDictionary uses a for loop to increment
         * two variables (i and j) to populate 
         * champsDictionary from the collection list data in the
         *  cBoxWinners combobox as follows:
         *   j sets the integer key to a year, beginning with 1967
         *   i sets the string value to the winning team name for that year
         * A Try/Catch block encapsulates the Add method 
         * to ensure that each key is unique
         * 
         * champsDictionary example entry: 
         *   Key = 1967
         *   Value = Packers
         *   
         * Note that, to conform to the requirements of the assignment,
         * the champsDictionary key/value pairs
         * are NOT USED to determine back-to-back winners. 
         */
        private void LoadDictionary()
        {
            int count = cBoxWinners.Items.Count;
            int j = 1967;

            for (int i = 0; i < count; i++, j++)
            {
                try
                {
                    champsDictionary.Add(j, cBoxWinners.Items[i].ToString());
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Duplicate key found");
                    return;
                }
            }
        }

        /*
         * Event handler for the "NFL Teams" combobox
         * 
         * When a new item is selected
         * If the selection is blank 
         *   return
         * Else
         *   Hide any previous lblResult
         *   Set team to the selected team
         *   Handle an anomaly where if team = "49ers",
         *   the resouce manager stores the bitmap as "_49ers".
         *   Locate the team logo bitmap with a resource manager
         *   Display the bitmap in the picturebox pBox
         */
        private void cBoxAllTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBoxAllTeams.SelectedIndex < 0)
                return;
            else
            {
                lblResult.Visible = false;
                team = cBoxAllTeams.SelectedItem.ToString();
                if (team == "49ers") team = "_49ers";

                ResourceManager rm = Properties.Resources.ResourceManager;
                Bitmap myImage = (Bitmap)rm.GetObject(team);
                pBox.BackgroundImage = myImage;
                if (team == "_49ers") team = "49ers";
            }
        }

        /*
         * Unused CSVReader method
         * 
        private void CSVReader()
        {
            string CSVFullPath = @"C:\Users\marys\source\repos\MClarkAS5\Program13\data.csv";
          //  Dictionary dict = CSVFullPath.ReadLines("textwords0.csv").Select(line => line.Split(',')).ToDictionary(line => line[0], line => line[1]);
            DataTable myDataTable = new DataTable();
            try
            {
                using (TextFieldParser myParser = new TextFieldParser(CSVFullPath))
                {
                    myParser.TextFieldType = FieldType.Delimited;
                    myParser.SetDelimiters(new string[] { "," });

                    while (!myParser.EndOfData)
                    {
                        string[] row = myParser.ReadFields();
                        foreach (string column in row)
                        {
                            DataColumn datacolumn = new DataColumn(column);
                            datacolumn.AllowDBNull = true;
                            myDataTable.Columns.Add(datacolumn);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //MalformedLineException
            }
        }
        */
    }
}
    