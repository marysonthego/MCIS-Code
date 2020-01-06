package PP03;


import static PP03.Status.*;
import java.time.LocalDate;

// 1- add setters and getters method
// 2- add override method toString()
// 3- complete the code in the following methods: grossPay() and netPay()

public class PayRecord {

	private int rID;
    private Employee employee;
    private PayPeriod payPeriod;
    private TaxIncome payTax;

    private double payHours;
    private double payRate;

    private double monthlyIncome;
    private int numMonths;



    public static final int REG_HOURS = 40;
    public static final double OT_RATE = 1.25;

    // pay record constructor for hourly employee
    public PayRecord(int id, Employee e, PayPeriod period, double hours, double rate){

    	this.rID = id;
    	this.employee = e;
    	this.payPeriod = period;
    	this.payHours = hours;
    	this.payRate = rate;
    	this.monthlyIncome = 0;
    	this.numMonths = 0;
    	this.payTax = new TaxIncome();

    }

    // pay record constructor for full time employee
    public PayRecord(int id, Employee e, PayPeriod period, double mIncome, int mNum){

 	this.rID = id;
 	this.employee = e;
 	this.payPeriod = period;
 	this.payHours = 0;
 	this.payRate = 0;
 	this.monthlyIncome = mIncome;
 	this.numMonths = mNum;
 	this.payTax = new TaxIncome();

    }

    public int getPrID(){
        return rID;
    }

    public Employee getPrEmployee() {
        return employee;
    }

    public PayPeriod getPrPayPeriod() {
        return payPeriod;
    }


    public double getPrPayHours() {
        return payHours;
    }

    public double getPrPayRate() {
        return payRate;
    }

    public double getPrMonthlyIncome() {
        return monthlyIncome;
    }

    public int getPrNumMonths() {
        return numMonths;
    }

    public void setPrID(int id) {
        rID = id;
    }

    public void setPrEmployee(Employee e) {
        employee = e;
    }

    public void setPrPayPeriod(int PpId, LocalDate sDate, LocalDate eDate) {
        payPeriod = new PayPeriod(PpId, sDate, eDate);
    }

    public void setPrPayHours(double hours) {
        payHours = hours;
    }

    public void setPrPayRate(double rate) {
        payRate = rate;
}

    public void setPrMonthlyIncome(double mIncome) {
        monthlyIncome = mIncome;
    }

    public void setPrNumMonths(int numMonths) {
        this.numMonths = numMonths;
    }


    // complete the code to compute the gross pay for the employee based on the employee status
	public double grossPay() {
        if (employee.getEmpStatus() == FullTime) {
            return monthlyIncome;
        }
        else {
            if (payHours <= REG_HOURS) {
                return payRate * payHours;
            } else
                return (payRate * REG_HOURS) + ((payRate * OT_RATE) * (payHours - REG_HOURS));
        }
	}

  // complete the code in this method to compute the net pay of the employee after taxes (state and federal)
     public double netPay() {
         return grossPay() - payTax.compIncomeTax(grossPay());
  }

    @Override
    public String toString() {
        	return String.format("PayRecord [rID= %d, payPeriod= %s, employee= %s, status= %s, payRate= %2f, payHours= %2f, monthlyIncome= %2f, numMonths= %d, State Tax= %2f, Federal Tax= %2f, payTax= %2f, grossPay= %2f, netPay= %2f]", rID, payPeriod.toString(), employee.toString(), employee.getEmpStatus().toString(), payRate, payHours, monthlyIncome, numMonths, payTax.compStateTax(grossPay()), payTax.compFederalTax(grossPay()), payTax.compIncomeTax(grossPay()), grossPay(), netPay());
    }
}
