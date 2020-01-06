/*
 * Class: MClarkAS5.Program11.WaterTank
 * Description: The WaterTank class contains methods to add and withdraw water, fill and drain the water tank, and calculate the capacity of the tank. The current water level in the tank is maintained by the property CurrentWaterLevel
 * Developer: Mary Clark
 * Date Started: 10/17/2018
 * Date Completed: 
 */
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program11
{
    class WaterTank
    {
        static readonly double footGallon = 7.48; //gallons of water per cubic foot

        public int Radius { get; private set; } //in feet
        public int Depth { get; private set; }  //in feet
        public int CurrentWaterLevel { get; private set; } //in gallons
        public int MaxCapacity { get; private set; }  //in gallons
        public int MaxCanAdd { get; private set; } //in gallons

        //For Debugging
        public string AddWaterReturnValue { get; private set; }
        public string WithdrawWaterReturnValue { get; private set; }
        bool fillReturn = true, drainReturn = true;

        //Constructor
        public WaterTank(int theRadius, int theDepth)
        {
            Radius = theRadius;
            Depth = theDepth;
            CalcMaxCapacity();
            CalcMaxAdd();
        }

        private void CalcMaxCapacity()
        {
            if (Radius > 0 && Depth > 0)
            {
                double theCapacity = Math.PI * Math.Pow(Radius, 2) * Depth * footGallon;
                MaxCapacity = Convert.ToInt32(Math.Floor(theCapacity));
            }
        }

        private void CalcMaxAdd()
        {
            MaxCanAdd = MaxCapacity - CurrentWaterLevel;
        }

        public string AddWater(int add)
        {
            int gallonsToAdd = add;

            if ((CurrentWaterLevel + gallonsToAdd) <= MaxCapacity)
            {
                CurrentWaterLevel += gallonsToAdd;
                CalcMaxAdd();
               
                AddWaterReturnValue = $"{gallonsToAdd} gallons were added. The water level is now {CurrentWaterLevel}.";
                return AddWaterReturnValue;
            }
            else
            {
                CalcMaxAdd();
                AddWaterReturnValue = $"The tank will overflow if {gallonsToAdd} gallons are added. The tank's current water level is {CurrentWaterLevel}. A maximum of {MaxCanAdd} gallons can be added.";
                return AddWaterReturnValue;
            }
        }

        public string WithdrawWater(int withdraw)
        {
            int gallonsToWithdraw = withdraw;

            if (CurrentWaterLevel - gallonsToWithdraw >= 0)
            {
                CurrentWaterLevel -= gallonsToWithdraw;
                CalcMaxAdd();

                WithdrawWaterReturnValue = $"{gallonsToWithdraw} gallons were withdrawn. The water level in the tank is now {CurrentWaterLevel} gallons.";

                return WithdrawWaterReturnValue;
            }
            else
            {
                WithdrawWaterReturnValue = $"The withdrawal request exceeds {CurrentWaterLevel} gallons - the current water level in the tank. The water was not withdrawn. You can withdraw a maximum of {CurrentWaterLevel} gallons at this time.";

                return WithdrawWaterReturnValue;
            }
        }

        public bool FillTank(int gallonsPerSecond)
        {
            if (CurrentWaterLevel + gallonsPerSecond <= MaxCapacity)
            {
                CurrentWaterLevel += gallonsPerSecond;
                CalcMaxAdd();
                fillReturn = true;
            }
            else
                fillReturn = false;
            return fillReturn;
        }

        public bool DrainTank(int gallonsPerSecond)
        {
            if (CurrentWaterLevel - gallonsPerSecond >= 0)
            {
                CurrentWaterLevel -= gallonsPerSecond;
                CalcMaxAdd();
                drainReturn = true;
            }
            else
                drainReturn = false;
            return drainReturn;
        }
       public override string ToString()
        {
           string debug = $"Radius: {Radius} \r\nDepth: {Depth} \r\nCurrentWaterLevel: {CurrentWaterLevel} \r\nAddWaterReturnValue: {AddWaterReturnValue} \r\nWithdrawWaterReturnValue: {WithdrawWaterReturnValue}\r\nFillTank: {fillReturn} \r\nDrainTank: {drainReturn}";
            return debug;
        }
    }
}
