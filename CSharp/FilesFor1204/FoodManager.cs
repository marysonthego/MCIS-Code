/*
 * Project:         Module 8
 * Date:            November 2018
 * Developed By:    LV
 * Class Name:      FoodManager
 * Purpose:         Demos a class that manages a collection of Food objects
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Module8
{
    class FoodManager
    {
        #region "Property"

        // BindingList<T> is a strongly typed collection for storing related objects
        // The "T" is a placeholder; it is replaced by the type of elements the List is intended to store 
        public BindingList<Food> FoodList { get; private set; }

        #endregion

        #region "Constructor"

        // instantiate a FoodManager object and the FoodList collection

        public FoodManager()
        {
            FoodList = new BindingList<Food>();
        }

        #endregion

        #region "Methods"

        // add a Food object to the FoodList collection

        public void AddFood(Food aFood)
        {
            FoodList.Add(aFood);
        }

        // instantiate a Food object and add it to the FoodList collection
        // overload the AddFood method (above)

        public void AddFood(string foodName, FoodGroup foodType, int fatGrams, int carbGrams, int proteinGrams)
        {
            Food aFood = new Food(foodName, foodType, fatGrams, carbGrams, proteinGrams);

            FoodList.Add(aFood);
        }

        // return the list of Food objects

        public BindingList<Food> GetAllFood()
        {
            return FoodList;
        }

        // return the number of Food objects in the list

        public int GetFoodCount()
        {
            return FoodList.Count;
        }

        // return the count of Food objects of a specific food group
        // overload the method above

        public int GetFoodCount(FoodGroup aGroup)
        {
            int count = 0;

            foreach (Food aFood in FoodList)
            {
                if (aFood.FoodType == aGroup)
                {
                    ++count;
                }
            }

            return count;
        }

        // remove a Food object from the list

        public void RemoveFood(Food aFood)
        {
            FoodList.Remove(aFood);
        }

        // remove all Food objects from list

        public void RemoveAllFood()
        {
            FoodList.Clear();
        }

        // calculate and return the total calories of all Food objects in the list
        
        public int GetTotalCalories()
        {
            int total = 0;

            foreach (Food aFood in FoodList)
            {
                total += aFood.Calories;
            }

            return total;
        }
  
        #endregion
    }
}
