/*
 * Class Name: MClarkAssignmentSet2.Program4.Investment
 * Class Description: Investment is a class which contains the method CalculateFutureValue. 
 * The purpose of this class is to instantiate the class' method, CalculateFutureValue.
 * Developer Name: Mary Clark
 * Date Created: 9/9/2018
 * Date Last Modified: 9/14/2018
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program4
{
    class Investment
    {
        /*
         * The method that is called when BtnFutureValue receives a click event. The future
         * value of an investment is calculated from the values selected by the user on the InvestmentForm
         * for present value, the number of years to invest, and the interest rate percentage.
         * The future value result is returned as a decimal type.
         */
        public decimal CalculateFutureValue(decimal presentVal, decimal years, decimal rate)
        {
            return presentVal * (decimal) Math.Pow((double)(1 + (rate / 100)),(double)years);
        }
    }
}
