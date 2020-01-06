/*
 * Project:         Test 1
 * Date:            September 2018
 * Developed By:    Mary Clark
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS605Test1
{
    class Loan
    {
        #region "Instance Properties"

        public readonly double AnnualInterestRate, MonthlyPayment;
        public readonly int LoanAmount, LoanDuration;

        #endregion

        #region "Static Properties"

        public static int TotalNumberOfLoans { get; set; }

        #endregion

        #region "Constructor"

        /*
         ***** Requirement 1 ***** (17 Points)
         * 
         * Write a constructor that 
         * a) instantiates a loan object
         * b) sets three of the loan object's properties - LoanAmount, AnnualInterestRate, and LoanDuration - using appropriate parameters
         * c) sets the loan object's MonthlyPayment property by calling a private instance method - CalculateMonthlyPayment (see Requirement 2 below)
         * d) increment the static property, TotalNumberOfLoans, by 1
        */



        #endregion
        public Loan (int myLoanAmount, double myAnnualInterestRate, int myLoanDuration)
        {
            this.LoanAmount = myLoanAmount;
            this.AnnualInterestRate = myAnnualInterestRate;
            this.LoanDuration = myLoanDuration;
            this.MonthlyPayment = CalculateMonthlyPayment();
            TotalNumberOfLoans++;
        }
        #region "Methods"

        /*
         ***** Requirement 2 ***** (18 Points)
         * 
         * Write a private CalculateMonthlyPayment method that calculates and returns the monthly payment
         * The formula for calculating monthly payment is as follows:
         * 
         * Monthly Interest Rate = Annual Interest Rate / (12 * 100)
         * Monthly Payment = (Monthly Interest Rate * Loan Amount) / (1 - (1 + Monthly Interest Rate)^-Loan Duration))
        */

        double CalculateMonthlyPayment()
        {
            double monthlyInterestRate = AnnualInterestRate / (12 * 100);

            double monthlyPayment = Math.Pow((monthlyInterestRate * (double)LoanAmount / (1 - (1 + monthlyInterestRate))),(double)LoanDuration);

            return monthlyPayment;

        }


        /*
         ***** Requirement 3 ***** (12 Points)
         * 
         * Write a public CalculateTotalInterest method that calculates and returns the total interest on the loan
         * The formula for calculating the total interest is as follows:
         * 
         * Total Interest = (Monthly Payment * Loan Duration) - Loan Amount
        */
        public double CalculateTotalInterest()
        {
            double totalInterest = (MonthlyPayment * (double)LoanDuration) - (double)LoanAmount;
            return totalInterest;
        }
        

        #endregion
    }
}