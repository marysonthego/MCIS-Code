/*
 * Project:         Assignment Set 6 - Program 15 MClarkAS6.ScoreCard
 * Date:            11/9/2018
 * Developed By:    LV, Mary Clark
 * Class Name:      ScoreCard
 * Assumption:      The scorecard is for a specific tournament and year
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MClarkAS6
{
    class ScoreCard
    {
        #region "Constants"

        const string PGATour = "2018 U.S. Open Championship", CourseName = "Shinnecock Hills";
        readonly int[] CoursePars = { 4, 3, 4, 4, 5, 4, 3, 4, 4, 4, 3, 4, 4, 4, 4, 5, 3, 4 };

        #endregion

        #region "Properties"

        public string PlayerName { get; private set; }
        public int[,] ScoresByRound { get; private set; }

        #endregion

        #region "Constructor"

        public ScoreCard(string name, int[,] scores)
        {
            PlayerName = name;

            ScoresByRound = scores;
        }

        #endregion

        #region "Methods"

        /* Complete this method to calculate and return the player's status after each hole for a given round.

           Status after hole 1 =  Score for hole 1 - Par for hole 1

           Status after holes 2 through 18 = 
            
           Status after previous hole + (Score for current hole - Par for current hole)
        */
        
        public int[] CalcStatusAfterHole(int round)
        {
            int[] resultPerHole = new int[18];
            int holes = 18;
            for (int i = 0; i < holes; i++)
            {
                if (i == 0)
                    resultPerHole[i] = ScoresByRound[round-1, i] - CoursePars[i];
                else
                    resultPerHole[i] = resultPerHole[i-1] + (ScoresByRound[round-1, i] - CoursePars[i]);
            }

            return resultPerHole;
        }

        /* Complete this method to calculate and return the player's average score for holes of a specific par (i.e., 3, 4 or 5).

          Player's average score for holes of a specific par = 
            
          Player's total score for holes of a specific par for all 4 rounds / (Total number of holes of a specific par * number of rounds (i.e., 4))

          Note: Do not use a manual count of the number of holes of a specific par.

          Instead, write code to find the number of holes of a specific par.
        */
        
        public double CalcAverageScoresByPar(int par)
        {
            int parHoleCount = 0;
            double cumScoreForPar = 0;
            for (int i = 0; i < 4; i++) // rounds
            {
                for (int j = 0; j < 18; j++) // holes
                {
                    if (CoursePars[j] == par)
                    {
                        cumScoreForPar = cumScoreForPar + ScoresByRound[i, j];
                        parHoleCount++;
                    }
                }
            }
            return cumScoreForPar / parHoleCount;
        }

        /* Complete this method to calculate and return the player's overall performance by score type (i.e., Number of Eagles, Birdies, Pars, Bogeys and Double Bogeys)

           Number of Eagles = Count of number of times player's score is two strokes below par

           Number of Birdies = Count of number of times player's score is one stroke below par

           Number of Pars = Count of number of times player's score is equal to par

           Number of Bogeys = Count of number of times player's score is one stroke above par

           Number of Double Bogeys = Count of number of times player's score is two strokes above par
        */

        public string CalcPerformanceByScoreType()
        {
            const int eagles = -2, birdies = -1, pars = 0, bogeys = 1, doubleBogeys = 2;
            int current = 0;
            int [] countByScoreType  = new int[5];
            string returnString = string.Empty;

            for (int i = 0; i < 4; i++) // rounds
            {
                for (int j = 0; j < 18; j++) // holes
                {
                    current = ScoresByRound[i, j] - CoursePars[j];
                    switch (current)
                    {
                        case eagles:
                            countByScoreType[0]++;
                            break;
                        case birdies:
                            countByScoreType[1]++;
                            break;
                        case pars:
                            countByScoreType[2]++;
                            break;
                        case bogeys:
                            countByScoreType[3]++;
                            break;
                        case doubleBogeys:
                            countByScoreType[4]++;
                            break;
                        default:
                            break;
                    }
                }
            }
            //lblResultMessage.Text = $"\"{tBoxRadius.Text}\" is invalid. \n\nEnter the radius as an integer between 1 and 99.";
            returnString = $"Eagles {countByScoreType[0]}\nBirdies {countByScoreType[1]}\nPars {countByScoreType[2]}\nBogeys {countByScoreType[3]}\nDoubleBogeys {countByScoreType[4]}";
            return returnString;
        }

        #endregion
    }
}