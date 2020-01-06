

import javax.swing.JOptionPane;



public class GuessNumber {
  public static void main(String[] args) {
    // Generate a random number to be guessed
    int number = (int)(Math.random() * 101);


    JOptionPane.showMessageDialog(null,"Guess a magic number between 0 and 100");

    String message;
    String input;


    int guess = -1;
    while (guess != number) {
      // Prompt the user to guess the number
    	 message= "\nEnter your guess: ";
 	    // get the answer from user
 	     input = JOptionPane.showInputDialog(message);

 	  // convert answers to int
 	  guess =   Integer.parseInt(input);

      if (guess == number)
    	  JOptionPane.showMessageDialog(null,"Yes, the number is " + number);
      else if (guess > number)
    	  JOptionPane.showMessageDialog(null,"Your guess is too high");
      else
    	  JOptionPane.showMessageDialog(null,"Your guess is too low");
    } // End of loop
  }
}
