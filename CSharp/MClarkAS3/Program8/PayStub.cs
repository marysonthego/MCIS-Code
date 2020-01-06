using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program8
{
    public class PayStub
    {
        readonly string employeeName;
        readonly int hoursWorked;
        readonly double payRate;
        readonly double netPay;

        public string EmployeeName { get; }
        public int HoursWorked { get; }
        public double PayRate { get; }
        public double NetPay { get; }

        public static int TotalNumberOfPayStubs { get; private set; }
        public static double TotalNetPay { get; private set; }

        public PayStub(string name, int hours, double rate)
        {
            employeeName = name;
            hoursWorked = hours;
            payRate = rate;
            netPay = CalcNetPay(hoursWorked, payRate);
            IncrementTotals();
        }

        public static double AverageNetPay()
        {
            return TotalNetPay / TotalNumberOfPayStubs;
        }

        private double CalcNetPay(int hrs, double payR)
        {
            double grossPay = (double)hrs * payR;
            double fedTax = grossPay * .11;
            double stateTax = grossPay * .04;
            double sSI = grossPay * .062;
            double medicareTax = grossPay * .0145;

            return grossPay - fedTax - stateTax - sSI - medicareTax;
        }

        private void IncrementTotals()
        {
            TotalNumberOfPayStubs++;
            TotalNetPay = TotalNetPay + NetPay;
        }
    }
}