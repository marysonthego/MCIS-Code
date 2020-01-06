using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridViewTest1
{
    static class RateTable
    {
        /* 
         * A Static generic dictionary object shared by all instances.
         */
        public static readonly IDictionary<int, decimal> RateTableDictionary;

        /* Static constructor for the static class RateTable 
         */
        static RateTable()
        {
            RateTableDictionary = new Dictionary<int, decimal>
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
    }
}
