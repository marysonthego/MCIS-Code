public class Customer {
	
	private int id;
	private String fName, lName;
	private double amount;
	private CreditCard card;

	
	public Customer(String fName, String lName, int id, double amount, CreditCard card) {
		super();
		this.fName = fName;
		this.lName = lName;
		this.setId(id);
		this.setAmount(amount);
		this.setCard(card);
		
	}
	
	// DONE | add public setter/getter methods, and also the toString method
	
	public String toString() {
		return id + ", " + fName + ", " + lName + ", " + amount + ", " + this.card.toString();
	}

	public CreditCard getCard() {
		return card;
	}

	public void setCard(CreditCard card) {
		this.card = card;
	}

	public double getAmount() {
		return amount;
	}

	public void setAmount(double amount) {
		this.amount = amount;
	}

	public int getId() {
		return id;
	}

	public void setId(int id) {
		this.id = id;
	}
	
	public String getName() {
		return this.fName + " " + this.lName;
	}
	
}
