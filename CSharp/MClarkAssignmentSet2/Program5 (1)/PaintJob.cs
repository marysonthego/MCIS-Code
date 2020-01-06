/*
 * Class Name: MClarkAssignmentSet2.Program5.PaintJob
 * Class Description: PaintJob assumes that 1 gallon of paint covers 325 sq feet, and the labor cost is $2.80 per square foot painted. Two constants, sqFeetPerGal, and laborPerSqFoot are created to hold these values.
 * PaintJob contains one method, CalculateEstimate, which returns a (decimal) paint job cost estimate based when called with the number of sqaure feet to paint and the paint cost per gallon.  
 * Developer Name: Mary Clark
 * Date Created: 9/9/2018
 * Date Last Modified: 9/15/2018
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program5
{
    class PaintJob
    {
        /*
         * Class Defaults:
         * assume 1 gal covers 325 Sq Feet
         * assume labor is $2.80/sq foot
         */
        const decimal sqFeetPerGal = 325;
        const decimal laborPerSqFoot = 2.80m;
        /*
         * Calculate the paint job estimate as paint costs + labor costs and return the estimate.
         */
        public decimal CalculateEstimate (decimal sqFeet, decimal costPerGal)
        {
            decimal estimate;
            estimate = ((sqFeet / sqFeetPerGal) * costPerGal) + (sqFeet * laborPerSqFoot);
            return estimate;
        }
    }
}
