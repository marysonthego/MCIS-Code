package PP03;

public class Person {

	protected String fName ;
    protected String lName ;
    protected Address address;

    public Person(String fName, String lName, String street, int houseNum, String city, String state, int zip) {
    	this.fName = fName;
        this.lName = lName;
        this.address = new Address(street, houseNum, city, state, zip);
    }

	public Person(String fName, String lName, Address address) {
		this.fName = fName;
		this.lName = lName;
		this.address = address;
	}

	public String getfName() {
		return fName;
	}

	public void setfName(String fName) {
		this.fName = fName;
	}

	public String getlName() {
		return lName;
	}

	public void setlName(String lName) {
		this.lName = lName;
	}

	public Address getAddress() {
		return address;
	}

	public void setAddress(Address address) {
		this.address = address;
	}

    public void setAddress(String street, int houseNum, String city, String state, int zip) {
        this.address = new Address(street, houseNum, city, state, zip);
    }

    public int getHouseNumber() {
        return address.getHouseNumber();
    }

    public String getStreet() {
        return address.getStreet();
    }

    public String getCity() {
        return address.getCity();
    }

    public String getState() {
        return address.getState();
    }

    public int getZip() {
        return address.getZipCode();
    }

    public void setHouseNumber(int houseNumber) {
        address.setHouseNumber(houseNumber);
    }

    public void setStreet(String street) {
        address.setStreet(street);
    }

    public void setCity(String city) {
        address.setCity(city);
    }

    public void setState(String state) {
        address.setState(state);
    }

    public void setZip(int zip) {
        address.setZipCode(zip);
}

	@Override
	public String toString() {
		return "Person [fName=" + fName + ", lName=" + lName + ", address=" + address.toString() + "]";
	}


}
