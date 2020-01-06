package PA05;

public class Course {
	
	private int id;
	private String description;
	private Student[] students;
	private Grade[] grades;
	
	// complete course object constructor
	public Course (int id, String description, int n){	
		// you should initialize the students and grades arrays here
		// these array should be of size n 
	    this.id = id;
	    this.description = description;
	    students = new Student[n];
	    grades = new Grade[n];
	}

	// Creates and adds a student object to the  students array
	public void addStudent(int id, String name) {
	    
	    students[students.length] = new Student(id, name); 
		
	}

	// adds a grade object to the  grades array
   public void addGrade(int id, String assignment, Student student, double score) {
		grades[grades.length] = new Grade(id, assignment, student, score);
		
	}
   
   
   
   public double getGradeAVG(){
       Double sum = 0.0;
       for (int i=0; i<grades.length; i++) {
         sum += grades[i].getScore();  
       }
	   return sum/(double)grades.length;
	   
	}
   
   
  public String getHighestStudentGrade(){
	   
	   return "";
		
	}
  
  public int getID() {
      return this.id;
  }
  
  public Grade getGrades() {
      return this.grades;
  }
   
   
}
