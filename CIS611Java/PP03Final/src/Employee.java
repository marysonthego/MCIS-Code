package PP03;

// [x] 1 - The Employee class extends superclass Person
public class Employee extends Person {

	private int eID;
	private Status empStatus; //FULLTIME or HOURLY

	public Employee(String firstName, String lastName, Address address, int eID, Status empStatus) {
		// [x] 2 - add the subclass Employee constructor that calls the supper Person
		// class constructor, you should provide input data for all parent class data
		// fields
		super(firstName, lastName, address);
		this.seteID(eID);
		this.setEmpStatus(empStatus);
	}

	// [x] 3 - add setters/getters methods
	public Status getEmpStatus() {
		return empStatus;
	}

	public void setEmpStatus(Status empStatus) {
		this.empStatus = empStatus;
	}

	public int geteID() {
		return eID;
	}

	public void seteID(int eID) {
		this.eID = eID;
	}

	// [x] 4 - add override toString() method that overrides toString() in the
	// superclass Person
	public String toString() {
		String temp = super.toString();
		temp += ", " + this.eID + ", " + this.empStatus;
		return temp;
	}

}
