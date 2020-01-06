
public class CreditCard {
	
	private long number;
	private String expDate;
	
	public CreditCard(long number, String expDate){
		this.number = number;
		this.expDate = expDate;
	}
	
	// DONE | add public setter/getter methods, and also the toString method
	public long getNumber() {
		return number;
	}
	
	public void setNumber(long num) {
		this.number = num;
	}
	
	public String toString() {
		String temp = Long.toString(number);
		HashCode h = new HashCode();
		temp = h.getHashCode(temp);
		return temp + ", " + this.expDate;
	}

	public String getExpDate() {
		return expDate;
	}

	public void setExpDate(String expDate) {
		this.expDate = expDate;
	}
}
