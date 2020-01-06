/*
 * Project:         Module 1; Example 1
 * Date:            August 2018
 * Developed By:    LV
 * Class Name:      Greeter
 * Description:     Business Logic class for displaying greetings
 * Purpose:         Demonstrate examples of simple methods
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1
{
    class Greeter
    {
        // method with no parameters
        public string SayHello()
        {
            return "Hello";
        }

        // method with one parameter
        // concatenates or joins "Goodbye" to the passed argument and returns the resulting string
        public string SayGoodBye(string strName)
        {
            // return "Goodbye, " + strName;
            return $"Goodbye {strName}"; //interpolation is faster
        }

    }
}
