import javax.swing.JOptionPane;


public class TestBooleanOperators {
  public static void main(String[] args) {
    

    // Receive an input
	  String message; 
	    message= "Enter an integer: ";
	        
	    // get the answer from user
	    String input = JOptionPane.showInputDialog(message);
	    
	    // convert answers to int
	    int  number =   Integer.parseInt(input);
	

	    JOptionPane.showMessageDialog(null,"Is " + number + " divisible by 2 and 3? " +
        ((number % 2 == 0) && (number % 3 == 0)));
   
	    JOptionPane.showMessageDialog(null,"Is " + number + " divisible by 2 or 3? " +
        ((number % 2 == 0) || (number % 3 == 0)));

	    JOptionPane.showMessageDialog(null,"Is " + number + 
         " divisible by 2 or 3, but not both? " +
         ((number % 2 == 0) ^ (number % 3 == 0))); 
  }
}
