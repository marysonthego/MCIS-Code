package PA06;

/*
 * Code a Faculty.java class that has a date hired (a reference data field to
 * class MyDate.), has a rank ((1) Lecturer, (2) Assistant Professor,
 * (3) Associate Professor, or (4) Professor.), and is a subclass of Person.
 *
 * A MyDate class needs to be coded with a java.util.date attribute,
 * which is the hire date. MyDate will have myDate attribute
 * with public getter and setter.
 *
 * Also code a toString() method by overriding the toString() form
 * Person class. Also code a toString() method by overriding the
 * toString() form Person class, and concatenate its return from the
 * parent class with the additional fields from the current subclass
 * data fields.
 *
 * For the classes above, the attributes have to be private. The getter and
 * the setter, and toString() methods are public.
 *
 */

public class Faculty extends Person {

         private String rankOfFaculty; // values are Lecturer, Assistant Professor, Associate professor, Professor
         private MyDate appointmentDate;
         private static final String[] RANK_ARRAY = {"Lecturer", "Assistant Professor", "Associate Professor", "Professor"};

	public Faculty(String firstName, String lastName, Address address, String phoneNumber, String emailAddress, String rankOfFaculty, MyDate appointmentDate){
		// call the super class constructor to pass the Person data fields
		super(firstName, lastName, address, phoneNumber, emailAddress);
		this.rankOfFaculty = rankOfFaculty; // values are Lecturer, Assistant Professor, Associate Professor, Professor
		this.appointmentDate = appointmentDate;
	}

        Faculty() { }

    public String[] getRankList() {
        return RANK_ARRAY;
    }
    public String getRankOfFaculty() {
        return rankOfFaculty;
    }

    public MyDate getAppointmentDate() {
        return appointmentDate;
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

    public void setAppointmentDate(MyDate appDate) {
        appointmentDate = appDate;
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
		return "Faculty: [" + "firstName=" + getFirstName() + ",  lastName=" + getLastName() +
                ",  " + getAddress().toString() + ",  phoneNumber=" + getPhoneNumber() +
                ",  emailAddress=" + getEmailAddress() + ",  rankOfFaculty=" + rankOfFaculty +
                ",  " + appointmentDate.toString() + "]";
	}

}
