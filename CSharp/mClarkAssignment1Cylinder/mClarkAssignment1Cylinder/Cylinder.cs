/// Class Name: mClarkAssignment1Cylinder.Cylinder
/// Class Description: The Cylinder class provides methods to calculate 
/// the area and volume of a cylinder.
/// Developer Name: Mary Clark
/// Date Created: 9/9/2018
/// Date Last Modified: 9/9/2018
/// 
using System;

namespace mClarkAssignment1Cylinder
{
    class Cylinder
    {
        ///
        /// CalcVolume returns the volume of a cylinder as a numeric double
        /// when integers radius and height are passed in.
        /// 
        public double CalcVolume(int radius, int height)
        {
            return Math.PI * Math.Pow(radius, 2) * height;
        }
        ///
        /// CalcArea returns the area of a cylinder as a numeric double
        /// when integers radius and height are passed in.
        /// 
        public double CalcArea(int radius, int height)
        {
            return 2 * Math.PI * Math.Pow(radius,2) + 2 * Math.PI * radius * height;
        }
    }
}
