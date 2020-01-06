/*
 * Project:         Module 3
 * Date:            September 2018
 * Developed By:    LV
 * Class Name:      Food3
 * Purpose:         Demos a variation on implementing the Food class
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3
{
    class Food3
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
        public int Calories { get; private set; }

        #endregion

        #region "Constructors"

        public Food3(string foodName, int fatGrams, int carbGrams, int proteinGrams)
        {
            FoodName = foodName;
            FatGrams = fatGrams;
            CarbGrams = carbGrams;
            ProteinGrams = proteinGrams;
        }

        public Food3() { }

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
