import javax.swing.JOptionPane;

public class LotteryUsingStrings {
  public static void main(String[] args) {
    // Generate a lottery as a two-digit string
    String lottery = "" + (int)(Math.random() * 10)
      + (int)(Math.random() * 10);

    // Prompt the user to enter a guess
    String guess = JOptionPane.showInputDialog("Enter your lottery pick (two digits): ");
    

    // Get digits from lottery
    int lotteryDigit1 = lottery.charAt(0); 
    int lotteryDigit2 = lottery.charAt(1); 

    // Get digits from guess
    int guessDigit1 = guess.charAt(0);
    int guessDigit2 = guess.charAt(1);

    System.out.println("The lottery number is " + lottery);

    // Check the guess
    if (guess.equals(lottery))
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
