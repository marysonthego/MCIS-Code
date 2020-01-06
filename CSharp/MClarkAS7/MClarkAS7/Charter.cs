using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MClarkAS7
{
     [Serializable] class Charter
    {
        /* 
         * A Static generic dictionary object shared by all instances.
         */
        static readonly IDictionary<int, decimal> RateTable;

        /*
         * public properties defining a Charter object
         */
        public decimal CharterFee { get; private set; }
        public decimal CharterHours { get; private set; }
        public string CustomerName { get; private set; }
        public int YachtSize { get; private set; }
        public string YachtType { get; private set; }

        public static IDictionary<int, decimal> RateTable1 => RateTable;

        /*
         * Static constructor to initialize the static dictionary 
         * containing the rate table used by all Charter instances.
         * Static constructors are never explicitly called. They
         * are called before the first instantiation of the class.
         */
        static Charter()
        {
            RateTable = new Dictionary<int, decimal>
            {
                { 22, 198.0m },
                { 24, 243.0m },
                { 30, 275.0m },
                { 32, 361.0m },
                { 36, 492.0m },
                { 38, 521.0m },
                { 45, 658.0m }
            };
        }

        /*
          Parameterless constructor required to implement a BindingSource
          in FormAllCharters to display CharterList in dataGridViewAllCharters. 
          Note that the static constructor was executed before this is called.
        */
        public Charter() { }

        /*
          Parameterized Instance constructor.
          This constructor is called when the Add New Charter button is clicked.
        */
        public Charter(string customerName, string yachtType, int yachtSize, decimal charterHours)
        {
            CustomerName = customerName;
            YachtType = yachtType;
            YachtSize = yachtSize;
            CharterHours = charterHours;
            CharterFee = CalculateCharterFee();
        }

        /*
         * The Static RateTable is used to calculate a charter fee.
         * Each Charter instance has a calculated CharterFee.
         */
        private decimal CalculateCharterFee()
        {
          if (RateTable1.TryGetValue(YachtSize, out decimal rate))
            {
                return rate * CharterHours;
            }
          else
            {
                return 0m;
            }
        }

    }
}
