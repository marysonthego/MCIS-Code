package PP03;

public class PayRecord {

	private int rID;
	private Employee employee;
	private PayPeriod payPeriod;
	private TaxIncome payTax;

	private double payHours;
	private double payRate;

	private double montlyIncome;
	private int numMonths;

	public static final int REG_HOURS = 40;
	public static final double OT_RATE = 1.25;

	// pay record constructor for hourly employee
	public PayRecord(int id, Employee e, PayPeriod period, double hours, double rate) {

		this.setrID(id);
		this.setEmployee(e);
		this.setPayPeriod(period);
		this.setPayHours(hours);
		this.setPayRate(rate);
		this.setMontlyIncome(0);
		this.setNumMonths(0);
		this.setPayTax(new TaxIncome());

	}

	// pay record constructor for full time employee
	public PayRecord(int id, Employee e, PayPeriod period, double mIncome, int mNum) {

		this.setrID(id);
		this.setEmployee(e);
		this.setPayPeriod(period);
		this.setPayHours(0);
		this.setPayRate(0);
		this.setMontlyIncome(mIncome);
		this.setNumMonths(mNum);
		this.setPayTax(new TaxIncome());

	}

	// [x] 1- add setters and getters methods

	public int getrID() {
		return rID;
	}

	public void setrID(int rID) {
		this.rID = rID;
	}

	public Employee getEmployee() {
		return employee;
	}

	public void setEmployee(Employee employee) {
		this.employee = employee;
	}

	public PayPeriod getPayPeriod() {
		return payPeriod;
	}

	public void setPayPeriod(PayPeriod payPeriod) {
		this.payPeriod = payPeriod;
	}

	public TaxIncome getPayTax() {
		return payTax;
	}

	public void setPayTax(TaxIncome payTax) {
		this.payTax = payTax;
	}

	public double getPayHours() {
		return payHours;
	}

	public void setPayHours(double payHours) {
		this.payHours = payHours;
	}

	public double getPayRate() {
		return payRate;
	}

	public void setPayRate(double payRate) {
		this.payRate = payRate;
	}

	public double getMontlyIncome() {
		return montlyIncome;
	}

	public void setMontlyIncome(double montlyIncome) {
		this.montlyIncome = montlyIncome;
	}

	public int getNumMonths() {
		return numMonths;
	}

	public void setNumMonths(int numMonths) {
		this.numMonths = numMonths;
	}

	// [x] 2- add override method toString()

	public String toString() {
		String rID = Integer.toString(this.rID);
		String empString = "Employee [" + this.employee.toString() + "]";
		String payPString = "Pay Period [" + this.payPeriod.toString() + "]";
		String payHours = " Pay Hours: " + Double.toString(this.payHours);
		String payRate = "Pay Rate: " + Double.toString(this.payRate);
		String monthlyInc = "Monthly Income: " + Double.toString(this.montlyIncome);
		String numberOfMonths = "Number of months:" + Integer.toString(this.numMonths);
		String grossPay = "Gross Pay: " + this.grossPay();
		String netPay = "Net Pay:" + this.netPay();
		String temp = "";
		if (this.employee.getEmpStatus().toString() == "FullTime") {
			temp = "rID: " + rID + ", " + empString + ", " + payPString + ", " + monthlyInc + ", " + numberOfMonths
					+ ", " + grossPay + ", " + netPay;
		} else {
			temp = "rID: " + rID + ", " + empString + ", " + payPString + ", " + payHours + ", " + payRate + ", "
					+ grossPay + ", " + netPay;
		}
		return temp;
	}

	// [x] 3- complete the code in the following methods: grossPay() and netPay()
	// complete the code to compute the gross pay for the employee based on the
	// employee status
	public double grossPay() {
		double output = 0;
		if (this.employee.getEmpStatus().toString() == "FullTime") {
			output = this.montlyIncome * this.numMonths;
		} else {
			double hours = this.payHours;
			double OT = 0;
			if (hours > 40) {
				OT = hours - 40;
				hours -= 40;
			}
			output = (hours * this.payRate) + ((OT * this.payRate) * OT_RATE);
		}
		return output;
	}

	// complete the code in this method to compute the net pay of the employee after
	// taxes (state and federal)
	public double netPay() {
		double gross = this.grossPay();
		double tax = this.payTax.compIncomeTax(gross);
		return gross - tax;
	}

}
