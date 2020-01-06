/*
 * Project:         Module 9
 * Date:            November 2018
 * Developed By:    LV
 * Class Name:      FoodManager
 * Purpose:         Demos a class that manages a collection of Food objects; 
 *                  Object serialization and deserialization
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// additional namespaces

using System.ComponentModel;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Module9
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

            // call the LoadFoodObjects method

            LoadFoodObjects();
        }

        #endregion

        #region "Methods"

        // add a Food object to the FoodList collection

        public void AddFood(Food aFood)
        {
            FoodList.Add(aFood);
        }

        // instantiate a Food object and add it to the FoodList collection
        // overloads the AddFood method (above)

        public void AddFood(string foodName, int fatGrams, int carbGrams, int proteinGrams)
        {
            Food aFood = new Food(foodName, fatGrams, carbGrams, proteinGrams);

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

        // if a file containing food objects exists, read the data from the file add it to the Food list

        private void LoadFoodObjects()
        {
            const string FoodFile = "Food.dat";

            if (File.Exists(FoodFile))
            {
                // create a file stream object

                FileStream aStream = new FileStream(FoodFile, FileMode.Open, FileAccess.Read);

                // create a binary formatter object

                BinaryFormatter aFormatter = new BinaryFormatter();

                // use a loop to read all object data from file

                while (aStream.Position < aStream.Length)
                {
                    // deserialize and cast the object data to a Food object

                    Food aFood = (Food)aFormatter.Deserialize(aStream);

                    // add the food object to the food list collection

                    FoodList.Add(aFood);
                }

                // close the file stream

                aStream.Close();
            }
        }

        // save the Food objects data in the food list collection to a file

        public void SaveFoodObjects()
        {
            const string FoodFile = "Food.dat";

            // create a file stream object

            FileStream aStream = new FileStream(FoodFile, FileMode.Create, FileAccess.Write);

            // create a binary formatter object

            BinaryFormatter aFormatter = new BinaryFormatter();

            // save each food object to the file

            foreach (Food aFood in FoodList)
            {
                aFormatter.Serialize(aStream, aFood);
            }

            // close the file stream

            aStream.Close();
        }
  
        #endregion
    }
}
