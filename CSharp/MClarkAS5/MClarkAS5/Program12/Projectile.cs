/*
 * Class Name: MClarkAS5.Program12.Projectile
 * Class Description: Projectile performs calculations about a projectile.
 * Given the initial height and velocity, the maximum height the projectile 
 * can reach, the amount of time until it lands, and its height at a given 
 * number of seconds after launch are computed.
 * 
 * The initial height, initial velocity, maximum height, and landing time 
 * are exposed through public read-only properties.
 * 
 * Developer Name: Mary Clark
 * Date Created: 10/26/18
 * Date Last Modified: 10/30/18
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program12
{
    class Projectile
    {
        /* 
         * Auto-implemented instance properties with
         * public get and private set methods
         */
        public int InitialHeight { get; private set; } //in feet
        public int InitialVelocity { get; private set; }  //in feet/sec
        public double MaxHeight { get; private set; } //in feet
        public double LandTime { get; private set; }  //in seconds

        /* 
         * Constructor
         * Requires an integer initial height in feet and
         * an integer initial velocity in feet/second
         * Calculates MaxHeight and LandTime for this instance
         */
        public Projectile (int anInitialHeight, int anInitialVelocity)
        {
            InitialHeight = anInitialHeight ;
            InitialVelocity = anInitialVelocity;
            CalcMaxHeight();
            CalcLandTime();
        }

        /*
         * FindHeight is a private method to calculate height at a given time.
         * Arguments: the time in seconds as a double.
         * Returns: the height in feet of the projectile at that time as a double.
         */
        private double FindHeight (double seconds)
        {
            double height = InitialHeight + (InitialVelocity * seconds) - (16 * Math.Pow(seconds, 2));
            return height;
        }

        /*
         * CalcMaxHeight is a private method that calculates
         * the maximum height the current projectile instance can reach.
         * It calculates the time of max height
         * then calls FindHeight to calculate the max height at that time.
         * Arguments: None
         * Returns: The Max Height in feet is returned as a double.
         */
        private double CalcMaxHeight()
        {
            double timeOfMaxHeight = 0;
            if (InitialVelocity > 0)
            {
                timeOfMaxHeight = InitialVelocity / 32;
                MaxHeight = FindHeight(timeOfMaxHeight);
                return MaxHeight;
            }
            else
                return MaxHeight = InitialHeight;
        }

        /*
         * CalcLandTime is a private method that calculates
         * the time in seconds it will take for the current projectile instance
         * to land after launch.
         * 
         * CalcLandTime utilizes a do/while loop to calculate the
         * current height of the projectile at 1/10th second intervals.
         * When the current height reaches zero, the projectile has landed.
         * If the initial velocity is zero, the projectile has landed with 
         * no travel. In this case, the land time is zero.
         * Arguments: None
         * Returns: time in seconds to land as a double
         */
        private double CalcLandTime()
        {
            double time = 0;
            double currentHeight = InitialHeight;
            if (InitialVelocity > 0)
            {
                do
                {
                    time += 0.1;
                    currentHeight = FindHeight(time);
                }
                while (currentHeight > 0);
            return LandTime = time;
            }
            else return LandTime = 0;
        }
    }
}
