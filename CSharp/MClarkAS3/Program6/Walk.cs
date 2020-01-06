/*
 * Class Name: MClarkAssignmentSet3.Program6.Walk
 * Class Description: Walk calculates and returns the number of miles walked based on the values of the properties provided when a Walk object is instantiated. 
 * The Walk class requires values for the properties WalkerName, NumberOfSteps and LengthOfSteps as arguments to the Constructor. 
 * There is no default Constructor.
 * The class constant inchesPerMile is the factor used to convert the units of distance walked from inches to miles.
 * Developer Name: Mary Clark
 * Date Created: 9/30/2018
 * Date Last Modified: 9/30/2018
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program6
{
    public class Walk
    {
        /*
         * A class constant for converting inches to miles.
         */
        const int inchesPerMile = 63360;
     

        /*
         * Auto-implemented properties for a Walk instance. The private variables corresponding to these properties are automatically generated and not explicitly specified.
         */
        public string WalkerName { get; set; }
        public int NumberOfSteps { get; set; }
        public int LengthOfSteps { get; set; }

        /*
         * Constructor for a Walk object. name, numSteps, and stepLength are required.
         */
        
        public Walk(string name, int numSteps, int stepLength)
        {
            WalkerName = name;
            NumberOfSteps = numSteps;
            LengthOfSteps = stepLength;
        }

         /* 
          * The public method CalcMilesWalked returns the number of miles walked for this Walk instance.
         */
        public decimal CalcMilesWalked()
        {
            return (NumberOfSteps * LengthOfSteps) / inchesPerMile;
        }
    }
}
