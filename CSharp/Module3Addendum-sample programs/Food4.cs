/*
 * Project:         Module 3 Addendum
 * Date:            September 2018
 * Developed By:    LV
 * Class Name:      Food4
 * Purpose:         Demos a static class with static members
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3Addendum
{

    /*
     * From Microsoft Documentation *
     * 
     * A static class is basically the same as a non-static class, but there is one difference: a static class cannot be instantiated. In other words, you cannot use the new keyword to create a variable of the class type. Because there is no instance variable, you access the members of a static class by using the class name itself.
     * 
     * A static class can be used as a convenient container for sets of methods that just operate on input parameters and do not have to get or set any internal instance fields. For example, in the .NET Framework Class Library, the static System.Math class contains methods that perform mathematical operations, without any requirement to store or retrieve data that is unique to a particular instance of the Math class. That is, you apply the members of the class by specifying the class name and the method name, as shown in the following example: Math.Pow(10, 2)
     */

      /* If we wish to just provide a) the number of calories in each nutrient type, and b) calculate the number of calories for a food item given the number of fat, carb and protein grams, a static class may be sufficient
      */
    static class Food4
    {
        #region "Fields"

        public const int FatCaloriesPerGram = 9;
        public const int CarbCaloriesPerGram = 4;
        public const int ProteinCaloriesPerGram = 4;

        #endregion

        #region "Methods"

        public static int CalculateCalories(int fatGrams, int carbGrams, int proteinGrams)
        {
            // variable

            int calories;

            // calculate calories

            calories = (fatGrams * FatCaloriesPerGram) + (carbGrams * CarbCaloriesPerGram) + (proteinGrams * ProteinCaloriesPerGram);

            // return calories

            return calories;
        }
        #endregion
    }
}
