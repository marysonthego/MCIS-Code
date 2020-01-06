/*
 * Class Name: MClarkAS4.Program9.CateringEvent
 * Class Description: The CateringEvent class performs the calculations displayed on the CateringEventForm.
 * It provides accessors for several properties of the CateringEvent class.
 * The EntreType enumeration is defined for the 3 entre types available for catering.
 * An overloaded CateringEvent Constructor is provided to set the initial values for a newly created CateringEvent.
 * EntrePricePerGuest is set based on the Entre type chosen on the CateringEventForm.
 * CalculateEventCharges provides the Entre Charge, Drink Charge, Surcharge, and Total Charge for a Catering Event.
 * An overridden ToString method provides debugging information for display on the CateringEventForm.
 * There is no default Constructor.
 * 
 * Developer Name: Mary Clark
 * Date Created: 10/14/2018
 * Date Last Modified: 10/14/2018
 */
using System;
using System.Linq;

namespace MClarkProgram9
{
    public enum EntreType { PrimeRib, ChickenMarsala, GardenLasagna };


    class CateringEvent
    {
        const double PrimeRibPrice = 62.87;
        const double ChickenMarsalaPrice = 53.74;
        const double GardenLasagnaPrice = 45.31;
        const double OpenBarCharge = 46.92;
        const double WineWithDinnerCharge = 37.48;
        const double TheSurcharge = 35.00;
        const int SurchargeApplies = 100;

        public string EventName { get; set; }
        public double EntreCharge { get; private set; }
        public double DrinksCharge { get; private set; }
        public double Surcharge { get; private set; }
        public double TotalCharge { get; private set; }

        private int numberOfGuests;
        public int NumberOfGuests
        {
            get { return numberOfGuests; }
            set
            {
                numberOfGuests = value;
                CalcEventCharges();
            }
        }
        private EntreType entreChoice;
        public EntreType EntreChoice
        {
            get { return entreChoice; }
            set
            {
                entreChoice = value;
                CalcEventCharges();
            }
        }
        private Boolean openBar;
        public Boolean OpenBar
        {
            get { return openBar; }
            set
            {
                openBar = value;
                CalcEventCharges();
            }
        }
        private Boolean wineWithDinner;
        public Boolean WineWithDinner
        {
            get { return wineWithDinner; }
            set
            {
                wineWithDinner = value;
                CalcEventCharges();
            }
        }
        /*
         * Constructor for an object of type CateringEvet
         */

        public CateringEvent(string name, int guests, EntreType entre, Boolean bar, Boolean wine)
        {
            EventName = name;
            numberOfGuests = guests;
            EntreChoice = entre;
            OpenBar = bar;
            WineWithDinner = wine;
        }
        /*
         * Use a switch statement to determine the EntreCharge based on the EntreType chosen by the user.
         */

        private double EntrePricePerGuest(EntreType entre)
        {
            switch (entre)
            {
                case EntreType.PrimeRib:
                    EntreCharge = PrimeRibPrice;
                    break;
                case EntreType.ChickenMarsala:
                    EntreCharge = ChickenMarsalaPrice;
                    break;
                case EntreType.GardenLasagna:
                    EntreCharge = GardenLasagnaPrice;
                    break;
                default:
                    break;
            }
            return EntreCharge;
        }
        /*
         * Calculate the charges for the CateringEvent for display on the CateringEventForm
         */

        private void CalcEventCharges()
        {
            EntreCharge = EntrePricePerGuest(EntreChoice) * NumberOfGuests;
            DrinksCharge = Convert.ToInt32(OpenBar) * OpenBarCharge * NumberOfGuests
                          + Convert.ToInt32(WineWithDinner) * WineWithDinnerCharge * NumberOfGuests;
            /*
             * OR
             * if (OpenBar && WineWithDinner)
             *      DrinksCharge = (OpenBarCharge * NumberOfGuests) + (WineWithDinnerCharge * NumberOfGuests);
             *  elseif (OpenBar)
             *      DrinksCharge = (OpenBarCharge * NumberOfGuests);
             *  else 
             *      DrinksCharge = (WineWithDinnerCharge * NumberOfGuests);
             */
            if (NumberOfGuests > SurchargeApplies)
            {
                Surcharge = ((NumberOfGuests - SurchargeApplies) * TheSurcharge);
            }
            else
            {
                Surcharge = 0;
            }
            TotalCharge = EntreCharge + DrinksCharge + Surcharge;
            return;
        }
        /* Report debugging information for the label lblEventToString on the CateringEventForm
         */
        public override string ToString()
        {
            return $"EventName: {EventName} \n NumberOfGuests: {NumberOfGuests} \n EntreChoice: {EntreChoice} \n OpenBar; {OpenBar} \n WineWithDinner: {WineWithDinner} \n EntreCharge {EntreCharge} \n DrinksCharge {DrinksCharge} \n Surcharge {Surcharge} \n TotalCharge {TotalCharge} \n";
        }
    }
}
