package PA06;

/*
 * Code a Student.java class that has a status, and the values of the status
 * are ((1) Freshman, (2) Sophomore, (3) Junior, or (4) Senior.) and also
 * a subclass of Person. The status attribute is private with public getter
 * and setter. Also code a toString() method by overriding the toString()
 * form Person class, and concatenate its return from the parent class with
 * the additional fields from the current subclass data fields.
 */

public class Student extends Person{


   private String status; // Values are Freshman, Sophomore, Junior, Senior
   private static final String[] STATUS_ARRAY = {"Freshman", "Sophomore", "Junior", "Senior"};

Student(String firstName, String lastName, Address address, String phoneNumber, String emailAddress, String status){
		// call the super class constructor to pass the Person data fields
		super(firstName,lastName,address,phoneNumber,emailAddress);
		this.status = status;
	}

Student() { }

public String[] getStatusList() {
    return STATUS_ARRAY;
}
public String getStatus() {
        return status;
    }

public String getFirstName() {
        return super.getFirstName();
    }

public String getLastName() {
        return super.getLastName();
    }

public Address getAddress() {
        return super.getAddress();
    }

public String getPhoneNumber() {
        return super.getPhoneNumber();
    }

public String getEmailAddress() {
        return super.getEmailAddress();
    }

public void setStatus(String stat) {
        status = stat;
    }

public void setFirstName(String first) {
        super.setFirstName(first);
    }

public void setLastName(String last) {
        super.setLastName(last);
    }

public void setAddress(Address addr) {
        super.setAddress(addr);
    }

public void setPhoneNumber(String phone) {
        super.setPhoneNumber(phone);
    }

public void setEmailAddress(String email) {
        super.setEmailAddress(email);
    }
// Override the abstract method from Person
@Override
public String toString() {
        return "Student: [firstName=" + getFirstName() +
               " , lastName=" + getLastName() +
               " , " + getAddress().toString() +
               " , phoneNumber=" + getPhoneNumber() +
               " , emailAddress=" + getEmailAddress() +
               " , status=" + status + "]";
	}

}
