

import javax.swing.JOptionPane;


public class TestDoWhile {
  /** Main method */
  public static void main(String[] args) {
    int data;
    int sum = 0;
    String message;
    String input;


    // Keep reading data until the input is 0
    do {
      // Read the next data
    	message= "Enter an int value (the program exits if the input is 0): ";
        // get the answer from user
         input = JOptionPane.showInputDialog(message);

      // convert answers to int
      data =   Integer.parseInt(input);

      sum += data;
    } while (data != 0);

    JOptionPane.showMessageDialog(null,"The sum is " + sum);
  }
}
