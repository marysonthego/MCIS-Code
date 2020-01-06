/*
 * Project:         Module 4
 * Date:            September 2018
 * Developed By:    LV
 * Class Name:      LoanApplication
 * Purpose:         Demos if ans switch statements
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4
{
    #region "Enumeration"

    // an enumeration is a set of constants represented by identifiers
    // by default, enumeration values are integers.  
    // an enumeration type can also be declared as byte, short or long
    // if values are not explicitly assigned, each enumeration item is automatically assigned a value
    // values start at 0 and increase by 1

    public enum LoanType
    {
        Auto = 1,
        Home = 2
    }

    #endregion

    class LoanApplication
    {
        
        #region 'Constants"

        const decimal poorRatio = 0.50m, fairRatio = 0.45m, goodRatio = 0.40m, veryGoodRatio = 0.35m, excellentRatio = 0.30m;

        const decimal autoLowRate = 0.04m, autoMidRate = 0.06m, autoHighRate = 0.08m;

        const decimal homeLowRate = 0.03m, homeMidRate = 0.05m, homeHighRate = 0.07m;
        
        #endregion

        #region "Fields"

        private int applicantIncome, applicantDebt;
        private decimal debtToIncomeRatio;

        #endregion

        #region "Properties"

        public string ApplicantName { get; set; }
        public LoanType LoanFor { get; set; }
        public char CreditRating { get; private set; }
        public int CreditScore { get; private set; }

        public int ApplicantIncome
        {
            get
            {
                return applicantIncome;
            }
            set
            {
                applicantIncome = value;
                SetDebtToIncomeRatio();
                SetCreditRating();
                SetCreditScore();
            }
        }

        public int ApplicantDebt
        {
            get
            {
                return applicantDebt;
            }
            set
            {
                applicantDebt = value;
                SetDebtToIncomeRatio();
                SetCreditRating();
                SetCreditScore();
            }
        }

        #endregion

        #region "Constructor"

        public LoanApplication(string name, int income, int debt, LoanType forWhat)
        {
            ApplicantName = name;
            ApplicantIncome = income;
            ApplicantDebt = debt;
            LoanFor = forWhat;
        }

        #endregion

        #region "Private Methods"

        private void SetDebtToIncomeRatio()
        {
            debtToIncomeRatio = (decimal)ApplicantDebt / ApplicantIncome;
        }

        // an if...else if...else statement

        private void SetCreditRating()
        {
            if (debtToIncomeRatio <= excellentRatio)
            {
                CreditRating = 'A';
            }
            else if (debtToIncomeRatio <= veryGoodRatio)
            {
                CreditRating = 'B';
            }
            else if (debtToIncomeRatio <= goodRatio)
            {
                CreditRating = 'C';
            }
            else if (debtToIncomeRatio <= fairRatio)
            {
                CreditRating = 'D';
            }
            else if (debtToIncomeRatio <= poorRatio)
            {
                CreditRating = 'E';
            }
            else
            {
                CreditRating = 'F';
            }
        }

        // a switch statement

        private void SetCreditScore()
        {
            switch (CreditRating)
            {
                case 'A':
                    CreditScore = 760;
                    break;
                case 'B':
                    CreditScore = 680;
                    break;
                case 'C':
                    CreditScore = 520;
                    break;
                case 'D':
                    CreditScore = 450;
                    break;
                case 'E':
                    CreditScore = 370;
                    break;
                default:
                    CreditScore = 300;
                    break;
            }
        }

        #endregion

        #region "Public Methods"

        //a simple if-else statement

        public string CheckPreQualification()
        {
            string outcome;

            if (debtToIncomeRatio <= goodRatio)
            {
                outcome = "Let's do business";
            }
            else
            {
                outcome = "Sorry, we'll need more documentation";
            }

            return outcome;
        }

        // a ternary conditional operator is an abbreviated version of the if-else statement

        public bool IsPreApproved()
        {
            bool outcome = (debtToIncomeRatio <= veryGoodRatio) ? true : false;

            return outcome;
        }

        // nested if statement

        public decimal DetermineInterestRate()
        {
            decimal result = 0;

            if (LoanFor == LoanType.Auto)
            {
                if (CreditScore >= 620)
                {
                    result = autoLowRate;
                }
                else if (CreditScore >= 550)
                {
                    result = autoMidRate;
                }
                else
                {
                    result = autoHighRate;
                }
            }
            else if (LoanFor == LoanType.Home)
            {
                if (CreditScore >= 620)
                {
                    result = homeLowRate;
                }
                else if (CreditScore >= 550)
                {
                    result = homeMidRate;
                }
                else
                {
                    result = homeHighRate;
                }
            }

            return result;

            // am alternate way with compound expressions using the conditional AND operator

            //if (LoanFor == LoanType.Auto && CreditScore >= 620)
            //{
            //    result = autoLowRate;
            //}
            //else if (LoanFor == LoanType.Auto && CreditScore >= 550)
            //{
            //    result = autoMidRate;
            //}
            //else if (LoanFor == LoanType.Auto && CreditScore < 550)
            //{
            //    result = autoHighRate;
            //}
            //else if (LoanFor == LoanType.Home && CreditScore >= 620)
            //{
            //    result = homeLowRate;
            //}
            //else if (LoanFor == LoanType.Home && CreditScore >= 550)
            //{
            //    result = homeMidRate;
            //}
            //else if (LoanFor == LoanType.Home && CreditScore < 550)
            //{
            //    result = homeHighRate;
            //}

            //return result;
        }
        
        #endregion
    }
}
