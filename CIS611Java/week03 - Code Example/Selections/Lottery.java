
import javax.swing.JOptionPane;

public class Lottery {
  
	public static void main(String[] args) {
    // Generate a lottery
    int lottery = (int)(Math.random() * 100);

    // Prompt the user to enter a guess
    String message; 
    message="Enter your lottery pick (two digits): ";
        
    // get the answer from user
    String input = JOptionPane.showInputDialog(message);
    
    // convert answers to int
    int  guess =   Integer.parseInt(input);
    
    
    // Get digits from lottery
    int lotteryDigit1 = lottery / 10;
    int lotteryDigit2 = lottery % 10;

    // Get digits from guess
    int guessDigit1 = guess / 10;
    int guessDigit2 = guess % 10;

    JOptionPane.showMessageDialog(null,"The lottery number is " + lottery);

    // Check the guess
    if (guess == lottery)
    	JOptionPane.showMessageDialog(null,"Exact match: you win $10,000");
    else if (guessDigit2 == lotteryDigit1
          && guessDigit1 == lotteryDigit2)
    	JOptionPane.showMessageDialog(null,"Match all digits: you win $3,000");
    else if (guessDigit1 == lotteryDigit1 
          || guessDigit1 == lotteryDigit2 
          || guessDigit2 == lotteryDigit1 
          || guessDigit2 == lotteryDigit2)
    	JOptionPane.showMessageDialog(null,"Match one digit: you win $1,000");
    else
    	JOptionPane.showMessageDialog(null,"Sorry, no match"); 
  }
}
