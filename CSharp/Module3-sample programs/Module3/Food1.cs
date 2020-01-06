/*
 * Project:         Module 3
 * Date:            September 2018
 * Developed By:    LV
 * Class Name:      Food1
 * Purpose:         Demos instance properties and instance method
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3
{
    class Food1
    {
        #region "Variables/Fields"
        
        // one variable/field of the appropriate data type is declared for each instance property of the class
        // to conform with good OOP principles, variables/fields should be declared with private access

        private string foodName;
        private int fatGrams, carbGrams, proteinGrams;

        #endregion

        #region "Properties"

        // the private (i.e., hidden) variables/fields (declared above) can be selectively exposed to the "outside world" through properties
        // a property provides access to a variable/field of a class; 
        // properties define how variables/fields will be set and retrieved

        // a property can have both a get accessor and a set accessor or just one or the other
        // if a property has only a get accessor, it is a readonly property
        // if a property has only a set accessor, it is a writeonly property

        public string FoodName
        {
            get
            {
                return foodName;
            }
            set
            {
                foodName = value;
            }
        }
      
        public int FatGrams
        {
            get
            {
                return fatGrams;
            }
            set
            {
                fatGrams = value;
            }
        }

        // written in a condensed form
        public int CarbGrams
        {
            get { return carbGrams; }
            set { carbGrams = value; }
        }
        
        //written in an even more condensed form
        public int ProteinGrams { get{ return proteinGrams; } set { proteinGrams = value; } }

        #endregion

        #region "Methods"

        // an instance method to calculate and return the calories for the food object

        public int CalculateCalories()
        {
            // constants and variable

            const int fatCaloriesPerGram = 9;
            const int carbAndProteinCaloriesPerGram = 4;

            int calories;

            // calculate calories

            calories = (FatGrams * fatCaloriesPerGram) + ((CarbGrams + ProteinGrams) * carbAndProteinCaloriesPerGram);

            // return calories

            return calories;
        }

        #endregion
    }
}
