import javax.swing.JOptionPane;

public class HexDigit2Dec {
  public static void main(String[] args) {
    
	String hexString = JOptionPane.showInputDialog("Enter a hex digit: ");
    
    // Check if the hex string has exactly one character
    if (hexString.length() != 1) {
    	JOptionPane.showMessageDialog(null,"You must enter exactly one character");
      System.exit(1);
    }
    
    // Display decimal value for the hex digit
    char ch = Character.toUpperCase(hexString.charAt(0));    
    if (ch <= 'F' && ch >= 'A') {
      int value = ch - 'A' + 10;
      JOptionPane.showMessageDialog(null,"The decimal value for hex digit " 
        + ch + " is " + value);
    }
    else if (Character.isDigit(ch)) {
    	JOptionPane.showMessageDialog(null,"The decimal value for hex digit " 
        + ch + " is " + ch);
    }
    else {
    	JOptionPane.showMessageDialog(null,ch + " is an invalid input");
    }
  }
}
