/*
 * Project:         Assignment Set 6 - Program 14  MClarkAS6.StockAnalyzer
 * Date:            11/9/2018
 * Developed By:    LV, Mary Clark
 * Class Name:      StockAnalyzer
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MClarkAS6
{
    class StockAnalyzer
    {
        #region "Property"

        public string TickerSymbol { get; private set; }
        public decimal[] StockPrices { get; private set; }
        public int Count { get; private set; }
        private List<decimal> mySortedList = new List<decimal>();

        #endregion

        #region "Constructor"

        public StockAnalyzer(string symbol, decimal[] prices)
        {
            TickerSymbol = symbol;

            StockPrices = prices;
        }

        #endregion

        #region "Methods"

        /* Complete this method to find and return the smallest price change (either up or down) between any two consecutive trading days.

           Price change (either up or down) between two consecutive trading days (e.g., Days 1 and 2) =
        
                    Absolute value of (Day 2 Price - Day 1 Price) 
        */

        private void SmallestDailyPriceChangeSort(decimal d)
        {
            Count = mySortedList.Count;
            int result = 0;
            bool inserted = false;
            if (Count > 0)
            {
                for (int i = 0; i < Count; i++)
                {
                    result = mySortedList[i].CompareTo(d);
                    if (result >= 0)
                    {
                        mySortedList.Insert(i, d);
                        inserted = true;
                        break;
                    }
                }
            }
            if (!inserted)
                mySortedList.Add(d);
        }
        public decimal FindSmallestPriceChange()
        {
            int lower = StockPrices.GetLowerBound(0);
            int upper = StockPrices.GetUpperBound(0);
            int next = 0;
            decimal diff, dResult;

            for (int i = lower; i < upper; i++)
            {
                if (next <= upper)
                {
                    next++;
                    diff = Math.Abs(StockPrices[i] - StockPrices[next]);
                    SmallestDailyPriceChangeSort(diff);
                }
            }
            dResult = mySortedList[0];
            mySortedList.Clear();
            return dResult;
        }

        private void LargestDailyPercentChangeSort(decimal d)
        {
            Count = mySortedList.Count;
            int result = 0;
            bool inserted = false;
            if (Count > 0)
            {
                for (int i = 0; i < Count; i++)
                {
                    result = mySortedList[i].CompareTo(d);
                    if (result >= 0)
                    {
                        mySortedList.Insert(i, d);
                        inserted = true;
                        break;
                    }
                }
            }
            if (!inserted)
                mySortedList.Add(d);
        }
        /* Complete this method to find and return the largest percentage change in price between any two consecutive trading days.  
        
           The return value should be formatted to display with a % sign and 2 decimal places.

           Percentage change in price between two consecutive trading days (e.g., Days 1 and 2) =

                (Day 2 Price - Day 1 Price) / Day 1 Price
        */

        public string FindLargestPercentagePriceChange()
        {
            int lower = StockPrices.GetLowerBound(0);
            int upper = StockPrices.GetUpperBound(0);
            int next = 0;
            decimal diff;
            string sResult;

            for (int i = lower; i < upper; i++)
            {
                if (next <= upper)
                {
                    next++;
                    diff = (StockPrices[next] - StockPrices[i])/StockPrices[i];
                    LargestDailyPercentChangeSort(diff);
                }
            }
            sResult = mySortedList[Count-1].ToString("p");
            mySortedList.Clear();
            return sResult;
        }

        /* Complete this method to find and return the number of times there is a positive change in price  between any two consecutive trading days. 

           There is a positive change in price between two consecutive trading days (e.g., Days 1 and 2), if Day 2 Price - Day 1 Price > 0
        */

        public int FindNumTimesPositivePriceChange()
        {
            int lower = StockPrices.GetLowerBound(0);
            int upper = StockPrices.GetUpperBound(0);
            int next = 0, iResult = 0;

            for (int i = lower; i < upper; i++)
            {
                if (next <= upper)
                {
                    next++;
                    if (StockPrices[next] - StockPrices[i] > 0)
                    {
                        iResult++;
                    }
                }
            }
            return iResult;
        }

        /* Complete this method to find and return the longest period (in days) of continuous price decline.

           There is a decline in price between two consecutive trading days (e.g., Days 1 and 2), if Day 2 Price - Day 1 Price < 0

        */

        public int FindLongestPriceDeclineStreak()
        {
            int lower = StockPrices.GetLowerBound(0);
            int upper = StockPrices.GetUpperBound(0);
            int next = 0, iResult = 0, iResultCurrent = 0;

            for (int i = lower; i < upper; i++)
            {
                if (next <= upper)
                {
                    next++;
                    if (StockPrices[i] - StockPrices[next] < 0)
                    {
                        iResultCurrent++;
                    }
                    else iResultCurrent = 0;
                }
                if (iResultCurrent > iResult)
                    iResult = iResultCurrent;
            }
            return iResult;
        }

        #endregion
    }
}