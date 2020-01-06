

import javax.swing.JOptionPane;


public class RepeatAdditionQuiz {
  public static void main(String[] args) {
    int number1 = (int)(Math.random() * 10);
    int number2 = (int)(Math.random() * 10);

    String message;
    String input;

 // Prompt the user to guess the number
 	 message= "What is " + number1 + " + " + number2 + "? ";
     // get the answer from user
      input = JOptionPane.showInputDialog(message);

   // convert answers to int
   int answer =   Integer.parseInt(input);


    while (number1 + number2 != answer) {

    	// Prompt the user to guess the number
    	 message= "Wrong answer. Try again. What is " ;
        // get the answer from user
         input = JOptionPane.showInputDialog(message);

      // convert answers to int
      answer =   Integer.parseInt(input);

    }

    JOptionPane.showMessageDialog(null,"You got it!");
  }
}
