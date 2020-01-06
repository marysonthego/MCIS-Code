/*
 * Project:         Module 2; Examples 1 & 2
 * Date:            August 2018
 * Developed By:    LV
 * Class Name:      Food
 * Description:     Food class with one method to calculate calories
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2
{
    class Food
    {
        /* Method to calculate calories for a food item
         * Parameters: Amount of fat, carbs, and protein (in grams) for a food item
         * Output: Calorie count for food item
        */
        public int CalculateCalories(int intFat, int intCarbs, int intProtein)
        {
            // constants and Variable

            const int intFatCaloriesPerGram = 9;
            const int intCarbsAndProteinCaloriesPerGram = 4;

            int intCalories;

            // calculate calories

            intCalories = (intFat * intFatCaloriesPerGram) + ((intCarbs + intProtein) * intCarbsAndProteinCaloriesPerGram);

            // return calories

            return intCalories;
        }
    }
}
