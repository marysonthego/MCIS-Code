/*
 * Project:         Module 8
 * Date:            November 2018
 * Developed By:    LV
 * Class Name:      Food
 * Purpose:         Demos a class whose objects will be managed by another class - FoodManager
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module8
{
    #region "Enumeration"

    public enum FoodGroup
    {
        BreadRicePasta = 1,
        Fruit = 2,
        Vegetable = 3,
        Dairy = 4,
        MeatEggNuts = 5,
        FatOilSweet = 6
    }
    #endregion
    class Food
    {
        #region "Variables/Fields"
        
        private int fatGrams, carbGrams, proteinGrams;

        #endregion

        #region "Properties"

        public int FatGrams
        {
            get
            {
                return fatGrams;
            }
            set
            {
                fatGrams = value;
                CalculateCalories();
            }
        }

        public int CarbGrams
        {
            get
            {
                return carbGrams;
            }
            set
            {   carbGrams = value;
                CalculateCalories();
            }
        }
        
        public int ProteinGrams
        {
            get
            {
                return proteinGrams;
            }
            set
            {
                proteinGrams = value;
                CalculateCalories();
            }
        }

        #endregion

        #region "Auto-implemented Properties"

        public string FoodName { get; set; }
        public FoodGroup FoodType { get; set; }
        public int Calories { get; private set; }

        #endregion

        #region "Constructors"

        public Food(string foodName, FoodGroup foodType, int fatGrams, int carbGrams, int proteinGrams)
        {
            FoodName = foodName;
            FoodType = foodType;
            FatGrams = fatGrams;
            CarbGrams = carbGrams;
            ProteinGrams = proteinGrams;
        }

        public Food() { }

        #endregion

        #region "Methods"

        // a private method to calculate and set the calories for the food object

        private void CalculateCalories()
        {
            // constants and Variable

            const int fatCaloriesPerGram = 9;
            const int carbAndProteinCaloriesPerGram = 4;

            int caloricValue;

            // calculate calories

            caloricValue = (FatGrams * fatCaloriesPerGram) + ((CarbGrams + ProteinGrams) * carbAndProteinCaloriesPerGram);

            // set the Calories property value

            Calories = caloricValue;
        }

        #endregion
    }
}
