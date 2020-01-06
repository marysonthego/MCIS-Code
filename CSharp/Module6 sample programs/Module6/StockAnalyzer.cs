/*
 * Project:         Module 6
 * Date:            October 2018
 * Developed By:    LV
 * Class Name:      StockAnalyzer
 * Purpose:         Demonstrates arrays
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module6
{
    class StockAnalyzer
    {
        #region "Property"

        public string TickerSymbol { get; private set; }
        public decimal[] StockPrices { get; private set; }

        #endregion

        #region "Constructor"

        public StockAnalyzer(string symbol, decimal[] prices)
        {
            TickerSymbol = symbol;
            
            // instantiate array first (line 34) and then use it (line 36) or use the array directly (line 36) 
            // C# has multiple ways to declare and instantiate arrays

            //StockPrices = new decimal[] { };

            StockPrices = prices;
        }

        #endregion

        #region "Methods"

        public decimal FindMinimumPrice()
        {
            // start with currentMin set to the first element's value

            decimal currentMin = StockPrices[0];  
            
            // loop through the array

            for (int x = 1; x < StockPrices.Length; ++x)
            {
                // if the current element's value is less than currentMin's value
                // assign current element's value to currentMin 

                if (StockPrices[x] < currentMin)
                {
                    currentMin = StockPrices[x];
                }
            }

            // can we find the miminum without using a loop?

            return currentMin;
        }

        public decimal FindMaximumPrice()
        {
            // start with currentMax set to the first element's value

            decimal currentMax = StockPrices[0];

            // loop through the array

            foreach (decimal aPrice in StockPrices)
            {
                // if the current element's value is greater than currentMax's value
                // assign current element's value to currentMax 

                if (aPrice > currentMax)
                {
                    currentMax = aPrice;
                }
            }

            // can we find the maximum without using a loop?

            return currentMax;
        }

        public decimal CalcAveragePrice()
        {
            // sum the prices

            decimal total = 0;
            
            foreach (decimal aPrice in StockPrices)
            {
                total += aPrice;
            }

            return total / StockPrices.Length;
        }

        public decimal CalcMedianPrice()
        {
            decimal medianPrice = 0;
            
            // assign the number of elements in array to a variable

            int numElements = StockPrices.Length;

            // declare and instantiate a new array

            decimal[] sortedPrices = new decimal[numElements];

            // copy the elements of StockPrices to sortedPrices

            StockPrices.CopyTo(sortedPrices,0);

            // sort the new array;

            Array.Sort(sortedPrices);

            // check if there are even or odd number of elements

            if (numElements % 2 == 0)
            {
                // if there are even number of elements, 
                // the median is the average of the middle two prices

                decimal sumPrices = sortedPrices[numElements / 2] + sortedPrices[numElements / 2 - 1];

                //calculate average

                medianPrice = sumPrices / 2;
            }
            else
            {
                medianPrice = sortedPrices[numElements / 2];
            }

            return medianPrice;
        }

        public double CalcStandardDeviationOfPrices()
        {
            // get average price

            decimal averagePrice = CalcAveragePrice();

            // calculate squared deviations

            double sumSquaredDeviations = 0;

            foreach (decimal aPrice in StockPrices)
            {
                decimal deviation = decimal.Subtract(aPrice, averagePrice);

                sumSquaredDeviations +=  Math.Pow((double) deviation, 2);
            }

            // calculate variance

            double variance = sumSquaredDeviations / StockPrices.Length;

            // calculate standard deviation

            double stdDeviation = Math.Sqrt(variance);

            return stdDeviation;
        }

        #endregion
    }
}