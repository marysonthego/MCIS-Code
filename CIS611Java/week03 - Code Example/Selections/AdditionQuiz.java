
import javax.swing.JOptionPane;

public class AdditionQuiz {
  
  public static void main(String[] args) {
    int number1 = (int)(System.currentTimeMillis() % 10);
    int number2 = (int)(System.currentTimeMillis() * 7 % 10);

    
    String message; 
    message= "What is " + number1 + " + " + number2 + "? ";
        
    // get the answer from user
    String input = JOptionPane.showInputDialog(message);
    
    // convert answers to int
    int  answer =   Integer.parseInt(input);
    
    message = number1 + " + " + number2 + " = " + answer + " is " +
      (number1 + number2 == answer);
    // show output  
    JOptionPane.showMessageDialog(null, message);
  }
}
