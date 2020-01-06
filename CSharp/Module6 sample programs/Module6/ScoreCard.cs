/*
 * Project:         Module 6
 * Date:            October 2018
 * Developed By:    LV
 * Class Name:      ScoreCard
 * Purpose:         Demonstrates two-dimensional arrays
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module6
{
    class ScoreCard
    {
        #region "Constant"

        int[] CoursePars = { 4, 3, 4, 4, 5, 4, 3, 4, 4, 4, 3, 4, 4, 4, 4, 5, 3, 4 };

        //can we use this to calculate other stats?

        #endregion

        #region "Property"

        public string PlayerName { get; private set; }
        public int[,] ScoresByRound { get; private set; }

        #endregion

        #region "Constructor"

        public ScoreCard(string name, int[,] scores)
        {
            PlayerName = name;

            // instantiate array

            // ScoresByRound = new int[,] { };

            ScoresByRound = scores;
        }

        #endregion

        #region "Methods"

        public double[] CalcAverageScoresByHole()
        {
            // assign the number of rounds and holes to variables

            int numRounds = ScoresByRound.GetLength(0);
            int numHoles = ScoresByRound.GetLength(1);

            // create a one dimensional array to store the average score for each hole 

            double[] averageScores = new double[numHoles];

            // loop through the array to calculate the total score for each hole
            // divide the total by the number of rounds to calculate average hole score

            // for each hole

            for (int col = 0; col < numHoles; ++col)
            {
                int totalHoleScore = 0;

                // for each round 

                for (int row = 0; row < numRounds; ++row)
                {
                    totalHoleScore += ScoresByRound[row, col];
                }

                averageScores[col] = (double) totalHoleScore / numRounds;
            }

            return averageScores;
        }

        public int[] CalcTotalScoresByRound()
        {
            // assign the number of rounds and holes to variables

            int numRounds = ScoresByRound.GetLength(0);
            int numHoles = ScoresByRound.GetLength(1);

            // create a one dimensional array to store the totale score for each round 

            int[] totalScores = new int[numRounds];

            // loop through the array to calculate the total score for each round
            
            // for each round

            for (int row = 0; row < numRounds; ++row)
            {
                int totalRoundScore = 0;

                // for each hole

                for (int col = 0; col < numHoles; ++col)
                {
                    totalRoundScore += ScoresByRound[row, col];
                }

                totalScores[row] = totalRoundScore;
            }

            return totalScores;
        }

        public int CalcTotalScore()
        {
            // assign the number of rounds and holes to variables

            int numRounds = ScoresByRound.GetLength(0);
            int numHoles = ScoresByRound.GetLength(1);

            // declare an array to store the total score 

            int totalScore = 0;

            // loop through the array to calculate the total score

            // for each round

            for (int row = 0; row < numRounds; ++row)
            {
                // for each hole

                for (int col = 0; col < numHoles; ++col)
                {
                    totalScore += ScoresByRound[row, col];
                }
            }

            // alternatively

            //foreach (int aScore in ScoresByRound)
            //{
            //    totalScore += aScore;
            //}

            // another alternative
            // call the CalcTotalScoresRound() method to get round scores
            // sum the round scores to get the total score

            //int[] scoresByRound = CalcTotalScoresByRound();

            //foreach (int aTotal in scoresByRound)
            //{
            //    totalScore += aTotal;
            //}

            return totalScore;
        }

        #endregion
    }
}