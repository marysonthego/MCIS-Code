
import javax.swing.JOptionPane;



public class GreatestCommonDivisor {
  /** Main method */
  public static void main(String[] args) {

    // Prompt the user to enter two integers
	    String message= "Enter first integer: ";

	    // get the answer from user
	     String input = JOptionPane.showInputDialog(message);

	    // convert answers to int
	    int  n1 =   Integer.parseInt(input);


	  message= "Enter second integer ";

	    // get the answer from user
	  input = JOptionPane.showInputDialog(message);

	    // convert answers to int
	 int n2 =   Integer.parseInt(input);

    int gcd = 1;
    int k = 2;
    while (k <= n1 && k <= n2) {
      if (n1 % k == 0 && n2 % k == 0)
        gcd = k;
      k++;
    }

    JOptionPane.showMessageDialog(null,"The greatest common divisor for " + n1 +
      " and " + n2 + " is " + gcd);
  }
}
