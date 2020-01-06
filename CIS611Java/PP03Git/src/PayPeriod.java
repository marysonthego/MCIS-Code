package PP03;

import java.text.DateFormat;
import java.text.SimpleDateFormat;
import java.util.Date;

public class PayPeriod {

	private int pID;
	private Date pStartDate, pEndDate;

	// [x] 1- add the class constructor
	public PayPeriod(int pID, Date pStart, Date pEnd) {
		this.setpID(pID);
		this.setpStartDate(pStart);
		this.setpEndDate(pEnd);
	}
	// [x] 2- add the setters/getters methods

	public int getpID() {
		return pID;
	}

	public void setpID(int pID) {
		this.pID = pID;
	}

	public Date getpStartDate() {
		return pStartDate;
	}

	public void setpStartDate(Date pStartDate) {
		this.pStartDate = pStartDate;
	}

	public Date getpEndDate() {
		return pEndDate;
	}

	public void setpEndDate(Date pEndDate) {
		this.pEndDate = pEndDate;
	}

	// [x] 3- add override method toString()
	public String toString() {
		DateFormat df = new SimpleDateFormat("MM/dd/yyy");
		String temp = "PID:" + this.pID + " Date Range: " + df.format(this.pStartDate) + "-" + df.format(this.pEndDate);
		return temp;
	}

}
