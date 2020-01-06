/*
 * Project:         Module 5
 * Date:            October 2018
 * Developed By:    LV
 * Class Name:      Investment
 * Purpose:         Demonstrates loops
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection; // additional namespace

namespace Module5
{
    class Investment
    {
        #region "Properties

        public int InvestmentAmount { get; private set; }
        public int InvestmentPeriod { get; private set; }
        public decimal InvestmentRate { get; private set; }
        public decimal FutureValue { get; private set; }
        
        #endregion

        #region "Constructor"

        public Investment (int amount, int period, decimal rate)
        {
            InvestmentAmount = amount;
            InvestmentPeriod = period;
            InvestmentRate = rate;
            
            FutureValue = CalcFVForLoop();
            //FutureValue = CalcFVWhileLoop(); same calculation done with a while loop
            //FutureValue = CalcFVDoLoop(); same calculation done with a do loop
        }

        #endregion

        #region "Methods"

        // for loop example
        private decimal CalcFVForLoop()
        {
            decimal fv = InvestmentAmount, rate = InvestmentRate/100;

            for (int i = 1; i <= InvestmentPeriod; ++i)
            {
                fv += fv * rate;
            }

            return fv;
        }

        // while loop example
        private decimal CalcFVWhileLoop()
        {
            decimal fv = InvestmentAmount, rate = InvestmentRate/100;

            int i = 1;

            while (i <= InvestmentPeriod)
            {
                fv += fv * rate;
                ++i;
            }

            return fv;
        }

        // do loop example
        private decimal CalcFVDoLoop()
        {
            decimal fv = InvestmentAmount, rate = InvestmentRate / 100;

            int i = 1;

            do
            {
                fv += fv * rate;
                ++i;
            }
            while (i <= InvestmentPeriod);

            return fv;
        }

        // overridding ToString() method to display an investment object's property values
        public override string ToString()
        {
            return $"Investment: {InvestmentAmount.ToString("c0")} \n Duration: {InvestmentPeriod} \n Rate: {(InvestmentRate / 100).ToString("p1")} \n Future Value: {FutureValue.ToString("c2")}";
        }

        // an alternate overriding method
        
        //public override string ToString()
        //{
        //    PropertyInfo[] investmentInfo = GetType().GetProperties();

        //    StringBuilder aBuilder = new StringBuilder();

        //    foreach (PropertyInfo aInfo in investmentInfo)
        //    {
        //        aBuilder.AppendLine($"{aInfo.Name}: {aInfo.GetValue(this)}");
        //    }

        //    return aBuilder.ToString();
        //}

        #endregion
    }
}
