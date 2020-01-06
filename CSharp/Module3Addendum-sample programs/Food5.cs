/*
 * Project:         Module 3 Addendum
 * Date:            September 2018
 * Developed By:    LV
 * Class Name:      Food5
 * Purpose:         Demos a class with both instance and static members
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3Addendum
{
    class Food5
    {
        #region "Instance Fields"

        // a readonly field can be assigned a value either at declaration or within a constructor, and cannot be changed after
        
        public readonly string FoodName;

        public readonly int FatGrams, CarbGrams, ProteinGrams, Calories;

        #endregion

        #region "Auto-implemented Static Properties"

        // static properties have a single memory location that is common for the class and can be accessed without instantiating an object of the class.
        // the static keyword is used to distinguish a static property or method
        // The two static properties below are used to maintain summary data that is common to all objects of this class

        public static int NumFoodItems { get; private set; }
        public static int TotalCalories { get; private set; }

        #endregion

        #region "Constructor"

        public Food5(string nameOfFood, int gramsOfFat, int gramsofCarbs, int gramsOfProtein)
        {
            FoodName = nameOfFood;
            FatGrams = gramsOfFat;
            CarbGrams = gramsofCarbs;
            ProteinGrams = gramsOfProtein;

            // call CalculateCalories() method

            Calories = CalculateCalories();

            // call IncrementTotals() method

            IncrementTotals();
        }

        #endregion

        #region "Instance Methods"

        // a private method to calculate and return the calories for the food object

        private int CalculateCalories()
        {
            // constants and Variable

            const int fatCaloriesPerGram = 9;
            const int carbAndProteinCaloriesPerGram = 4;

            int caloricValue;

            // calculate calories

            caloricValue = (FatGrams * fatCaloriesPerGram) + ((CarbGrams + ProteinGrams) * carbAndProteinCaloriesPerGram);

           // return the calories

            return caloricValue;
        }

        private void IncrementTotals()
        {
            //Increment NumFoodItems by 1

            NumFoodItems++;

            //Add to TotalCalories

            TotalCalories += Calories;
        }

        #endregion

        #region "Static Method"

         // static methods can be called on the class itself without instantiating an object of the class

        // static method that calculates and returns the average calories for all food items

        public static double CalculateAverageCalories()
        {
            double result = 0;

            if (NumFoodItems > 0)
            {
                result = (double)TotalCalories / NumFoodItems;
            }

            return result; 
        }

        #endregion
    }
}
