/*
 * Project:         Module 6
 * Date:            October 2018
 * Developed By:    LV
 * Class Name:      LottoTicket
 * Purpose:         Demonstrates arrays
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module6
{
    class LottoTicket
    {
        #region "Property"

        public int[] LottoNumbers { get; private set; }

        #endregion

        #region "Constructor"

        public LottoTicket()
        {
            // call the PickNumbers or PickNumbersAlt method to assign values to LottoNumbers 

            // LottoNumbers = PickNumbers();

            LottoNumbers = PickNumbersAlt();
        }

        #endregion

        #region "Methods"

        // generates 6 random numbers between 1 and 49 using the Random class
        // the random numbers are assigned to an integer array and returned 
        private int[] PickNumbers()
        {
            // declare an integer array with six elements

            int[] randNumbers = new int[6];

            //instantiate an object of the Random class

            Random aRandom = new Random();

            // call the Next method on the Random object to generate 6 random numbers

            for (int x = 0; x < randNumbers.Length; ++x)
            {
                randNumbers[x] = aRandom.Next(1, 49);
            }

            // sort the array

            Array.Sort(randNumbers);

            return randNumbers;
        }

        // another version of PickNumbers
        // avoids picking duplicate numbers

        private int[] PickNumbersAlt()
        {
            // declare an integer array with six elements

            int[] randNumbers = new int[6];

            //instantiate an object of the Random class

            Random aRandom = new Random();

            int counter = 0;

            while (counter < randNumbers.Length)
            {
                int aNumber = aRandom.Next(1, 49);

                // the IndexOf method searches a one-dimensional array for a specific value
                // if the value is found, the method returns the index of the element with the matching value
                // if the value is not found, the method returns a value of -1
                
                // if the number already exists in the array, skip adding it to the array

                if (Array.IndexOf(randNumbers, aNumber) >= 0)
                {
                    continue;
                }

                randNumbers[counter] = aNumber;
                ++counter;
            }

            Array.Sort(randNumbers);

            return randNumbers;
        }

        #endregion
    }
}
