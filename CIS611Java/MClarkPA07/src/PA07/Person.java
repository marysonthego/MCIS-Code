package PA07;

public abstract class Person {
	private String firstName; // example, Jim
	private String lastName; // example, Miller
	private Address address;
	private String phoneNumber; // example, (970) 421-1212.
	private String emailAddress; // example, jim@gmail.com.

	public Person (String fName, String lName, Address addr, String phoneNum, String email) {
        firstName = fName;
        lastName = lName;
        address = addr;
        phoneNumber = phoneNum;
        emailAddress = email;
    }

    public Person () {
    }

    protected String getFirstName() {
        return firstName;
    }
    protected String getLastName() {
        return lastName;
    }
    protected Address getAddress() {
        return address;
    }
    protected String getPhoneNumber() {
        return phoneNumber;
    }
    protected String getEmailAddress() {
        return emailAddress;
    }
    protected void setFirstName(String first) {
        firstName = first;
    }
    protected void setLastName(String last) {
        lastName = last;
    }
    protected void setAddress(Address addr) {
        address = addr;
    }
    protected void setPhoneNumber(String phone) {
        phoneNumber = phone;
    }
    protected void setEmailAddress(String email) {
        emailAddress = email;
    }
	public abstract String toString();
}
