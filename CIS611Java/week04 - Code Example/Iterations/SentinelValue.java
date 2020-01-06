

import javax.swing.JOptionPane;


public class SentinelValue {
  /** Main method */
  public static void main(String[] args) {

	    String message;
	    String input;


	    // Read an initial data
		 message= "Enter an int value (the program exits if the input is 0): ";
	    // get the answer from user
	     input = JOptionPane.showInputDialog(message);

	  // convert answers to int
	  int data =   Integer.parseInt(input);



    // Keep reading data until the input is 0
    int sum = 0;
    while (data != 0) {
      sum += data;

      // Read the next data
      message= "Enter an int value (the program exits if the input is 0): ";
      // get the answer from user
       input = JOptionPane.showInputDialog(message);

    // convert answers to int
    data =   Integer.parseInt(input);

    }

    JOptionPane.showMessageDialog(null,"The sum is " + sum);
  }
}
