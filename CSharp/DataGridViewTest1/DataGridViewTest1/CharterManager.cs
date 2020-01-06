using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace DataGridViewTest1
{
    [Serializable]
    class CharterManager
    {
        public BindingList<Charter> CharterList { get; private set; }

        const string CharterFile = "Charters.dat";
        //By default the file is in the same directory as the .exe file
        //Example:
        //C:\Users\marys\source\CSharp\DataGridViewTest1\DataGridViewTest1\bin\Debug

        public CharterManager()
        {
            CharterList = new BindingList<Charter>();
            LoadCharterFile();
        }

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

        public BindingList<Charter> GetAllCharters()
        {
            return CharterList;
        }

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
