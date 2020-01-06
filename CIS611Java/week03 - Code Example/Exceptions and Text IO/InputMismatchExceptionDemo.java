
import java.util.*;

import javax.swing.JOptionPane;

public class InputMismatchExceptionDemo {
  public static void main(String[] args) {
    
	
    boolean continueInput = true;

    do {
    	String message; 
    	try {
    	  
    	    message= "Enter an integer: ";
    	        
    	    // get the answer from user
    	    String input = JOptionPane.showInputDialog(message);
    	    
    	    // convert answers to int
    	    int  number =   Integer.parseInt(input);  
        
  
        // Display the result
    	JOptionPane.showMessageDialog(null,
          "The number entered is " + number);
        
        continueInput = false;
      } 
      
    	catch (NumberFormatException e) {
    	  message= "Try again. (" + 
    	          "Incorrect input: an integer is required)";
	        
  	    // get the answer from user
  	    JOptionPane.showMessageDialog(null, message);
  	    
  	   
    	  
      }
    } while (continueInput);
  }
}
