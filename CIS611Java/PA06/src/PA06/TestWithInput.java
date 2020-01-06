package PA06;

import static javax.swing.JOptionPane.ERROR_MESSAGE;
import static javax.swing.JOptionPane.showInputDialog;

/*
 * part two, you will write a separate Java program (TestWithInput.java),
 * which will accept the all the pieces of information using JOptionPane only
 * (instead of hardcoding, as you did in part one). Following user input needs
 * to be obtained using separate JOptionPane:
 *
 * 1. Number of Person. This number (n) will be used to set the size of
 * personArray. It is expected that the students test the code with at
 * least with size 2, where one Faculty instance and one student
 * instance is populated.
 *
 * 2. For each person, get the following pieces of information for each
 * Person (person could be either a faculty, or a Student) using JOptionPane:
 * a. Information on Address (using this information, you will create
 * an instance of Address
 * b. Information on Date (using this information, you will create
 * an instance of MyDate)
 * c. Information on Faculty, or a Student (using this information,
 * you will create an instance of Faculty).
 * You may design your program to give a prompt to the user to decide on
 * whether to enter the Student information, or the Faculty information.
 * Based on the selection of the user, either the Faculty information,
 * or the Student information will be entered by the user.
 * And using the information entered, an instance of Faculty (or Student)
 * will get created and will be used to populate an element of personArray.
 *
 * Next, you will iterate through the elements of personArray and display
 * the information of the person (you will use toString) in a new
 * JOptionPane. Use line separator to separate the information of each person.
 *
 * The program should not crash if input values are kept empty, or
 * empty space is entered in Part 2. There is no need to code to check
 * for any format of the phone number email address (they cannot be blank, or empty).
 *
 * Why it is better to extend JPanel than JFrame: https://stackoverflow.com/questions/34770435/difference-between-implementing-jframe-and-jpanel
 *
 */

public class TestWithInput {

	private static Person[] personArray;
    private int count = 0;
    private int size = 0;
    private String selected;

    TestWithInput() {
        createArray();
    }

    private void createArray() {
      size=0;

      String numberOfPersons = showInputDialog(null, "How many faculty and students do you want add?", 2);
      while (size == 0) {
      try {
          size = Integer.parseInt(numberOfPersons);
        } catch (NumberFormatException e) {
            numberOfPersons = showInputDialog(null, "Invalid input. Integer required", "Error", ERROR_MESSAGE);
        }
      }
      personArray = new Person[size];
    }

    public void addFacultyToList(Faculty aFaculty) {
        if (count < size) {
        personArray[count] = aFaculty;
        count++;
        }

    }

    public void addStudentToList(Student aStudent) {
        if (count < size) {
            personArray[count] = aStudent;
            count++;
        }

    }

    public Person[] getList() {
        return personArray;
    }


}