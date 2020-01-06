using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program7
{
    public class CarRental
    {
        const decimal dailyRentalCharge = 29.50M;
        const decimal rentalChargePerMile = 0.45M;

        private int endingOdometerReading;
        private int beginningOdometerReading;
        private int numberOfDaysRented;

        public string CustomerName { get; set; }
        public decimal RentalCharge { get; private set; }

        public int EndingOdometerReading
        {
            get
            {
                return endingOdometerReading;
            }
            set
            {
                endingOdometerReading = value;
                CalculateRentalCharge();

            }
        }
        public int BeginningOdometerReading
        {
            get
            {
                return beginningOdometerReading;
            }
            set
            {
                beginningOdometerReading = value;
                CalculateRentalCharge();
            }
        }
        public int NumberOfDaysRented
        {
            get
            {
                return numberOfDaysRented;
            }
            set
            {
                numberOfDaysRented = value;
                CalculateRentalCharge();
            }
        }
        void CalculateRentalCharge()
        {
            RentalCharge = (dailyRentalCharge * NumberOfDaysRented) + ((EndingOdometerReading - BeginningOdometerReading) * rentalChargePerMile);
        }

        public CarRental()
        {
        }
        public CarRental(string custName, int endingOdometer, int beginningOdometer, int daysRented)
        {
            CustomerName = custName;
            EndingOdometerReading = endingOdometer;
            BeginningOdometerReading = beginningOdometer;
            NumberOfDaysRented = daysRented;
        }
    }
}
