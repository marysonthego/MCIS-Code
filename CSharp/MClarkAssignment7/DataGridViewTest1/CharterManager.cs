/*
 * Class CharterManager 
 * - is serializable to enable saving the CharterList in the file Charters.dat.
 * - controls the CharterList BindingList
 * Developer: Mary Clark
 * December, 2018 for CIS605
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace MClarkAssignment7
{
    [Serializable]
    class CharterManager
    {
        //CharterList contains a list of Charter objects.
        public BindingList<Charter> CharterList { get; private set; }

        //The file saving the CharterList
        //By default the file is in the same directory as the .exe file
        //Example:
        //C:\Users\marys\source\CSharp\MClarkAssignment7\bin\Debug
        const string CharterFile = "Charters.dat";

        //Parameterless CharterManager constructor creates the CharterList
        //and populates it with the data in the CharterFile
        public CharterManager()
        {
            CharterList = new BindingList<Charter>();
            LoadCharterFile();
        }

        //Add a new Charter to the CharterList given a Charter object
        public void AddCharter(Charter aCharter)
        {
            CharterList.Add(aCharter);
        }

        // instantiate a Charter object and add it to the CharterList collection
        // overload the AddCharter method (above)
        public void AddCharter(string customerName, string yachtType, int yachtSize, decimal charterHours)
        {
            Charter aCharter = new Charter(customerName, yachtType, yachtSize, charterHours);
            CharterList.Add(aCharter);
        }

        //Return the CharterList
        public BindingList<Charter> GetAllCharters()
        {
            return CharterList;
        }

        /*
         * Find and return the lowest charter fee among all the charters.
         * The foreach loops through the CharterList setting "lowest" to
         * the lowest value so far.
         */
        public decimal FindLowestCharterFee()
        {
            decimal lowest = 1000000.00m;
            foreach (Charter element in CharterList)
            {
                if (element.CharterFee < lowest)
                    lowest = element.CharterFee;
            }
            return lowest;
        }

        /*
         * Sum up and return the total fees from all the charters
         */
        public decimal GetTotalCharterFees()
        {
            decimal fees = 0m;
            foreach (Charter element in CharterList)
                fees += element.CharterFee;
            return fees;
        }

        /*
         * Calculate and return the average charter fee
         */
        public decimal GetAverageCharterFee()
        {
            decimal fees = GetTotalCharterFees();
            int count = CharterList.Count;

            if (count > 0 && fees > 0m)
                return fees / (decimal)count;
            else
                return 0m;
        }

        /*
         * Count and return the number of charters for a specific yacht size
         */
        public int GetCharterCountBySize(int size)
        {
            int count = 0;

            foreach (Charter element in CharterList)
            {
                if (element.YachtSize == size)
                    count++;
            }
            return count;
        }

        //CreateCharterFile is called when the program exits
        public void CreateCharterFile()
        {
            try
            {
                using (Stream stream = File.Open(CharterFile, FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, CharterList);
                }
            }
            catch (IOException)
            {}
        }

        //LoadCharterFile is called in the CharterManager constructor
        //The Charter objects in the file are added to the CharterList
        //at startup
        private void LoadCharterFile()
        {
            if (File.Exists(CharterFile))
            {
                // create a file stream object
                FileStream aStream = new FileStream(CharterFile, FileMode.Open, FileAccess.Read);
                // create a binary formatter object
                BinaryFormatter bin = new BinaryFormatter();
                CharterList = (BindingList<Charter>)bin.Deserialize(aStream);
                aStream.Close();
            }
        }
    }
}
