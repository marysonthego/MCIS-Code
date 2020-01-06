
package PA07;

public class Student extends Person{


	private String status; // Values are Freshman, Sophomore, Junior, Senior
    public static final String[] STATUSLIST = {"Freshman", "Sophomore", "Junior", "Senior"};

	Student(String firstName, String lastName, Address address, String phoneNumber, String emailAddress, String status){
        super(firstName, lastName, address, phoneNumber, emailAddress);
		// call the super class constructor to pass the Person data fields
		this.status = status;
	}
    Student() {
    }

public String[] getStatusList() {
    return STATUSLIST;
}
public String getStatus() {
        return status;
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
public void setStatus(String stat) {
        status = stat;
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
        return getFirstName() + " " + getLastName() +
               " " + getAddress().toString() +
               " , " + getPhoneNumber() + ", " +
               getEmailAddress() + ", " + status;
	}
}
