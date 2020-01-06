package PA05;

public class Grade {
	private int id;
	private String assignment;
	private Student student;
	private double score;
	private static int noOfGrades;
	
	// complete grade object constructor
	public Grade (int id, String assignment, Student student, double score){
		// increment noOfGrades by one for each new instantiated Grade object 
	    noOfGrades++;
	    this.id = id;
	    this.assignment = assignment;
	    this.student = student;
	    this.score = score;
	}
	
	// compete public getter and setter methods
	public int getId() {
	    return id;
	}
	
	public String getAssignment() {
	    return assignment;
	}
	
	public Student getStudent() {
	    return student;
	}
	
	public double getScore() {
	    return score;
	}
	
	public void setID(int id) {
	    this.id = id;
	}
	
	public void setAssignment(String assignment) {
	    this.assignment = assignment;
	}
	
	public void setStudent(Student student) {
	    this.student = student;
	}
	
	public void setScore(double score) {
	    this.score = score;
	}
}
