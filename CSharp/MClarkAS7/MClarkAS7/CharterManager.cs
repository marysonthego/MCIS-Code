using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace MClarkAS7
{
    class CharterManager
    {
        //List of Charters
        public BindingList<Charter> CharterList { get; private set; }
        
         //Singleton implementation stuff
        //instance for Singleton pattern;
        public static readonly CharterManager instance = new CharterManager();

        //Private Constructor instantiates the list of Charters
        private CharterManager()
        {
            CharterList = new BindingList<Charter>();
            CharterList.AllowNew = true;
            CharterList.AllowRemove = false;
            CharterList.RaiseListChangedEvents = true;
            CharterList.AllowEdit = false;
        }

        
       /* public CharterManager()
        {
            CharterList = new BindingList<Charter>();
            //CharterList.AllowNew = true;
            //CharterList.AllowRemove = false;
            //CharterList.RaiseListChangedEvents = true;
            //CharterList.AllowEdit = false;
        }
       */
        //AddCharter instantiates a new Charter and adds it to CharterList
        public void AddCharter(string customerName, string yachtType, int yachtSize, decimal charterHours)
        {
            Charter aCharter = new Charter(customerName, yachtType, yachtSize, charterHours);
            //CharterList.Add(aCharter);
            aCharter = CharterList.AddNew();
            CharterList.EndNew(CharterList.Count + 1);
        }

        /*
                public decimal FindLowestCharterFee()
                {

                }

                public decimal GetAverageCharterFee()
                {

                }

                public int GetCharterCount(int yachtSize)
                {

                }

                public decimal GetTotalCharterFees()
                {

                }
          */
    }
}
