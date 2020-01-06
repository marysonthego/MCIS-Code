package PP03;


    // 1- The Employee class extends superclass Person
    // 2- add the subclass Employee constructor that calls the supper Person class constructor, you should provide input data for all parent class data fields
   // 3- add setters/getters methods
   // 4- add override toString() method that overrides toString() in the superclass Person

public class Employee extends Person {

	private int eID;
    private Status empStatus;

    public Employee(String fname, String lname, Address address, int id, Status status) {
        super(fname, lname, address);
        empStatus = status;
        eID = id;
    }

    public Employee(String fname, String lname, String street, int houseNumber, String city, String state, int zipCode, int id, Status status){
        super(fname, lname, street, houseNumber, city, state, zipCode);
        empStatus = status;
        eID = id;
    }

    public Address getEmpAddress() {
        return address;
    }
    public int getEmpHouseNumber() {
        return getHouseNumber();
    }

    public String getEmpStreet() {
        return getStreet();
    }

    public String getEmpCity() {
        return getCity();
    }

    public String getEmpState() {
        return getState();
    }

    public int getEmpZip() {
        return getZip();
    }

    public int geteEmpID() {
        return eID;
    }

    public String getEmpfName() {
        return fName;
	}

    public String getEmplName() {
        return lName;
	}

    public Status getEmpStatus() {
        return empStatus;
    }

    public void setEmpAddress(Address address) {
        this.address = address;
	}

    public void setEmpAddress(String street, int houseNumber, String city, String state, int zip) {
        setHouseNumber(houseNumber);
        setStreet(street);
        setCity(city);
        setState(state);
        setZip(zip);
    }

    public void setEmpHouseNumber(int houseNumber) {
        setHouseNumber(houseNumber);
    }

    public void setEmpStreet(String street) {
        setStreet(street);
    }

    public void setEmpCity(String city) {
        setCity(city);
    }

    public void setEmpState(String state) {
        setState(state);
    }

    public void setEmpZip(int zip) {
        setZip(zip);
    }

    public void setEmpeID(int id) {
        eID = id;
    }

	public void setEmpfName(String fName) {
		this.fName = fName;
	}

	public void setEmplName(String lName) {
		this.lName = lName;
	}

    public void setEmpStatus(Status s) {
        empStatus = s;
    }

	@Override
	public String toString() {
		return "Employee [fName=" + fName + ", lName=" + lName + ", address=" + address.toString() + "eID=" + eID + "Status=" + empStatus + "]";
	}
}
