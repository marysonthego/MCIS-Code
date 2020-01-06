/*
 * Class Name: MClarkAS4.Program10.PropertyTax
 * Class Description: calculates Property Taxes. 
 * There is no default Constructor.
 * Developer Name: Mary Clark
 * Date Created: 10/14/2018
 * Date Last Modified: 10/14/2018
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MClarkProgram10
{
    public enum LocationType {Urban, Suburban, Rural};

    class PropertyTax
    {

        public string PropertyOwnwer { get; }
        public int BldgSqFeet { get; }
        public int LandSqFeet { get; }
        public int YearBuilt { get; }
        public string Location { get; }

        public int BldgAge { get; private set; }
        public double BldgTax { get; private set; }
        public double LandTax { get; private set; }
        public double BldgTaxDed { get; private set; }
        public double LandTaxDed { get; private set; }
        public double TotalPropTax { get; private set; }

        public PropertyTax(string name, int bldg, int land, int year, string loc)
        {
            PropertyOwnwer = name;
            BldgSqFeet = bldg;
            LandSqFeet = land;
            YearBuilt = year;
            Location = loc;

            BldgAge = DateTime.Today.Year - YearBuilt;
            CalcBuildingTax();
            CalcLandTax();
            CalcBldgTaxDeduction();
            CalcTotalPropertyTax();
        }

        private void CalcBuildingTax()
        {
            if (BldgSqFeet < 1001)
            {
                BldgTax = BldgSqFeet * .62;
            }
            else if (BldgSqFeet < 2001)
            {
                BldgTax = 620.00 + ((BldgSqFeet - 1000) * 0.64);
            }
            else if (BldgSqFeet < 3001)
            {
                BldgTax = 1260.00 + ((BldgSqFeet - 2000) * 0.66);
            }
            else if (BldgSqFeet < 4001)
            {
                BldgTax = 1920.00 + ((BldgSqFeet - 3000) * 0.68);
            }
            else if (BldgSqFeet > 4000)
            {
                BldgTax = 2600.00 + ((BldgSqFeet - 4000) * 0.70);
            }
        }
            private void CalcLandTax()
                {
            if (LandSqFeet < 10001)
            {
                LandTax = LandSqFeet * .03;
            }
            else if (LandSqFeet < 20001)
            {
                LandTax = 300.00 + ((LandSqFeet - 10000) * 0.05);
            }
            else if (LandSqFeet < 30001)
            {
                LandTax = 800.00 + ((BldgSqFeet - 20000) * 0.07);
            }
            else if (LandSqFeet < 40001)
            {
                LandTax = 1500.00 + ((LandSqFeet - 30000) * 0.09);
            }
            else if (LandSqFeet > 40000)
            {
                LandTax = 2400.00 + ((LandSqFeet - 40000) * 0.11);
            }
        }

        private void CalcBldgTaxDeduction()
        {
            if (BldgAge > 10)
                BldgTaxDed = (DateTime.Today.Year - YearBuilt) * (0.005 * BldgTax);
        }

        private void CalcLandTaxDeduction()
        {
            if (Location == LocationType.Rural && LandSqFeet < 25000)
                LandTaxDed = LandTax * 0.02;
            else if (Location == LocationType.Rural)
            {
                LandTaxDed = (LandSqFeet - 25000) * (LandTax * 0.01);
            }

                
        }

        private void CalcTotalPropertyTax()
        {
        }


    }
}
