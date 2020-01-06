package PA07;

public class Faculty extends Person {

	private String rankOfFaculty; // values are Lecturer, Assistant Professor, Associate professor, Professor
    public static final String[] RANKLIST = {"Lecturer", "Assistant Professor", "Associate Professor", "Professor"};


	public Faculty(String firstName, String lastName, Address address, String phoneNumber, String emailAddress, String rankOfFaculty) {
        super(firstName, lastName, address, phoneNumber, emailAddress);
        // call the super class constructor to pass the Person data fields
		this.rankOfFaculty = rankOfFaculty; // values are Lecturer, Assistant Professor, Associate Professor, Professor
	}
    public Faculty() {

    }
    public String[] getRankList() {
        return RANKLIST;
    }
    public String getRankOfFaculty() {
        return rankOfFaculty;
    }
    @Override
    public String getFirstName() {
        return super.getFirstName();
    }
    @Override
    public String getLastName() {
        return super.getLastName();
    }
    @Override
    public Address getAddress() {
        return super.getAddress();
    }
    @Override
    public String getPhoneNumber() {
        return super.getPhoneNumber();
    }
    @Override
    public String getEmailAddress() {
        return super.getEmailAddress();
    }
    public void setRankOfFaculty (String rank) {
        rankOfFaculty = rank;
    }
    @Override
    public void setFirstName(String first) {
        super.setFirstName(first);
    }
    @Override
    public void setLastName(String last) {
        super.setLastName(last);
    }
    @Override
    public void setAddress(Address addr) {
        super.setAddress(addr);
    }
    @Override
    public void setPhoneNumber(String phone) {
        super.setPhoneNumber(phone);
    }
    @Override
    public void setEmailAddress(String email) {
        super.setEmailAddress(email);
    }
	// Override the abstract method from Person
	@Override
	public String toString() {
		return getFirstName() + " "+ getLastName() + " " +
               getAddress().toString() + " , " + getPhoneNumber() + ", " +
               getEmailAddress() + ", " + getRankOfFaculty();
	}

}
