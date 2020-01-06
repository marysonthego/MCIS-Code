
import javax.swing.JOptionPane;


public class SubtractionQuiz {
  public static void main(String[] args) {
    // 1. Generate two random single-digit integers
    int number1 = (int)(Math.random() * 10);
    int number2 = (int)(Math.random() * 10);

    // 2. If number1 < number2, swap number1 with number2
    if (number1 < number2) {
      int temp = number1;
      number1 = number2;
      number2 = temp;
    }

    // 3. Prompt the student to answer “what is number1 – number2?”
    String message; 
    message= "What is " + number1 + " - " + number2 + "? ";
        
    // get the answer from user
    String input = JOptionPane.showInputDialog(message);
    
    // convert answers to int
    int  answer =   Integer.parseInt(input);
    
    
    // 4. Grade the answer and display the result
    if (number1 - number2 == answer)
    	JOptionPane.showMessageDialog(null,"You are correct!");
    else
    	JOptionPane.showMessageDialog(null,"Your answer is wrong.\n" + number1 + " - "
        + number2 + " should be " + (number1 - number2)); 
  }
}
