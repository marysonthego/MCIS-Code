
import javax.swing.JOptionPane;


public class LeapYear {
  public static void main(String args[]) {
    
    // enter year
	  String message; 
	    message= "Enter a year: ";
	        
	    // get the answer from user
	    String input = JOptionPane.showInputDialog(message);
	    
	    // convert answers to int
	    int  year =   Integer.parseInt(input);
	
    // Check if the year is a leap year 
    boolean isLeapYear = 
      (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);

    // Display the result in a message dialog box
    JOptionPane.showMessageDialog(null, year + " is a leap year? " + isLeapYear);   
  } 
}
