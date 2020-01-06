package PA06;

/*
 * Code a Person.java class, which is an abstract class, means an instance of
 * Person.java cannot be created. The Person.java has abstract methods, which
 * need to be implemented by the two concrete sub-classes
 * (by Sudent.java, and Faculty.java).
 *
 * Abstract classes are similar to interfaces. You cannot instantiate them,
 * and they may contain a mix of methods declared with or without an
 * implementation. However, with abstract classes, you can declare fields
 * that are not static and final, and define public, protected, and
 * private concrete methods.
 *
 * An abstract class may have static fields and static methods. You can use
 * these static members with a class reference (for example,
 * AbstractClass.staticMethod()) as you would with any other class.
 *
 */
public abstract class Person {
	private String firstName; // example, Jim
	private String lastName; // example, Miller
	private Address address;
	private String phoneNumber;
    // example, (970) 421-1212. No need to code to verify
    //the format of the phone number, other than it not being blank, or not empty
	private String emailAddress;
    // example, jim@gmail.com. No need to code to verify
    //the format of the email address, other than it not being blank, or not empty

	public static int numberOfPersons=0;

    // add the constructor with data fields
	// increment the numberOfPersons by 1 for each time the constructor is
    //called from the subclases
public Person (String fName, String lName, Address addr, String phoneNum, String email) {
        numberOfPersons++;
        firstName = fName;
        lastName = lName;
        address = addr;
        phoneNumber = phoneNum;
        emailAddress = email;
    }

Person () { }

    protected String getFirstName() {
        return firstName;
    }
    protected void setFirstName(String first) {
        firstName = first;
    }

    protected String getLastName() {
        return lastName;
    }

    protected void setLastName(String last) {
        lastName = last;
    }

    protected Address getAddress() {
        return address;
    }

    protected void setAddress(Address addr) {
        address = addr;
    }

    protected String getPhoneNumber() {
        return phoneNumber;
    }

    protected void setPhoneNumber(String phone) {
        phoneNumber = phone;
    }

    protected String getEmailAddress() {
        return emailAddress;
    }

    protected void setEmailAddress(String email) {
        emailAddress = email;
    }

	// This is an abstract method
	public abstract String toString();

}
