/*
 * Project:         Module 1; Example 2
 * Date:            August 2018
 * Developed By:    LV
 * Class Name:      Abacus
 * Description:     Business Logic class for a simple calculator
 * Purpose:         Demonstrate examples of methods
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1
{
    class Abacus
    {
        // Add two numbers and return the result

        public int Add(int intOne, int intTwo)
        {
            return intOne + intTwo;
        }

        // Subtract one number from another and return the result

        public int Subtract(int intOne, int intTwo)
        {
            return intOne - intTwo;
        }

        // Multiply two numbers and return the result

        public int Multiply(int intOne, int intTwo)
        {
            return intOne * intTwo;
        }
    }
}
