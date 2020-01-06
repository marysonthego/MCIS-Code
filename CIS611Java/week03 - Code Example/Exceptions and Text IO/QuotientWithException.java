
import javax.swing.JOptionPane;


public class QuotientWithException {
  
	public static void main(String[] args) {
    
    
    // Prompt the user to enter two integers
		 // Prompt the user to enter two integers
		  String message; 
		    message= "Enter integer 1: ";
		        
		    // get the answer from user
		    String input1 = JOptionPane.showInputDialog(message);
		    
		    message= "Enter integer 2: ";
	        
		    // get the answer from user
		    String input2 = JOptionPane.showInputDialog(message);
		    
		    // convert answers to int
		    int  number1 =   Integer.parseInt(input1);
		    int  number2 =   Integer.parseInt(input2);
    
    try {
      if (number2 == 0)
        
    	  throw new ArithmeticException("Divisor cannot be zero");
    
      JOptionPane.showMessageDialog(null, number1 + " / " + number2 + " is " +
        (number1 / number2));
    }
    catch (Exception ex) {
    	JOptionPane.showMessageDialog(null,"Exception: an integer " + 
        "cannot be divided by zero ");
    }

    JOptionPane.showMessageDialog(null,"Execution continues ...");
  }
}
