package PA05;
import javax.swing.JOptionPane;

/* Mary Clark - I have run completely out of time to finish this. */

public class School {
	
	private static Course course;

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		int courseID = 0;
		int studentID = 0;
		String courseDescription = "";
		int numStudents = 0;
		String studentName = "";
		
		// 1 - prompt the user to provide the number of students, integer n value
		numStudents = Integer.parseInt(JOptionPane.showInputDialog(null,"Enter number of students", 
                "Number of Students", JOptionPane.OK_CANCEL_OPTION));
	    // Ask user to enter Course ID, Description, and number of students
		// 2 - Instantiates the course object
	    Course course = new Course(courseID, courseDescription, numStudents);
		// 3 - Prompt the user to input the student data, and calls addStudentGrade() to add the student to course, for n students
	    course.addStudent(studentID, studentName);
		// 4 - Prompt the user to input the grade data, and calls aaddStudentGradeToCourse() to add the grade to course, for n grades
	    addStudentGradeToCourse(course.grades.getID(), assignment, student, score);
		// 5 - Displays the course statistics by calling displayCourseStat()
	}
	
	// it uses the course object to add a new student to the course
	public static void addStudentToCourse(int id, String name){
		
	}
	
	// it uses the course object to add a new grade object to the course
	public static void addStudentGradeToCourse(int id, String assignment, Student student, double score){
	    course.addGrade(course.getID(),assignment, student, score);
			
	}
	
	// it should display the grade average and the highest student grade, student name 
	public void displayCourseStat(){
		
	}

}
