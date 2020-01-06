package PA05;

public class Student {
	
	private int id;
	private String name;
	private static int noOfStudents;

	// complete student object constructor
	public Student (int id, String name){
	    
		// increment noOfStudents by one for each new instantiated Student object
	    noOfStudents++;
	    this.id = id;
	    this.name = name;
	}
	// compete public getter and setter methods
	public int getId(String name) {
	    return id;
	}
	
	public String getName(int id) {
	    return name;
	}
	
	public void setId(int id) {
	    this.id = id;
	}
	
	public void setName(String name) {
	    this.name = name;
	}
	
	public int getNoOfStudents() {
	    return noOfStudents;
	}
}
