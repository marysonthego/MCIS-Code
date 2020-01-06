
import javax.swing.JOptionPane;


public class SimpleIfDemo {
  public static void main(String[] args) {
   
    // prompt the user to enter integer number
	  String message; 
	    message= "Enter an integer: ";
	        
	    // get the answer from user
	    String input = JOptionPane.showInputDialog(message);
	    
	    // convert answers to integer
	    int  number =   Integer.parseInt(input);
	    
	
    if (number % 5 == 0)
    	JOptionPane.showMessageDialog(null,"HiFive");

    if (number % 2 == 0)
    	JOptionPane.showMessageDialog(null,"HiEven");
  }
}
