
import javax.swing.JOptionPane;

  public class ChineseZodiac {
  public static void main(String[] args) {
       
	    String message; 
	    message= "Enter a year: ";
	        
	    // get the answer from user
	    String input = JOptionPane.showInputDialog(message);
	    
	    // convert answers to int
	    int  year =   Integer.parseInt(input);    
	  
	
    switch (year % 12) {
      case 0: JOptionPane.showMessageDialog(null,"monkey"); break;
      case 1: JOptionPane.showMessageDialog(null,"rooster"); break;
      case 2: JOptionPane.showMessageDialog(null,"dog"); break;
      case 3: JOptionPane.showMessageDialog(null,"pig"); break;
      case 4: JOptionPane.showMessageDialog(null,"rat"); break;
      case 5: JOptionPane.showMessageDialog(null,"ox"); break;
      case 6: JOptionPane.showMessageDialog(null,"tiger"); break;
      case 7: JOptionPane.showMessageDialog(null,"rabbit"); break;
      case 8: JOptionPane.showMessageDialog(null,"dragon"); break;
      case 9: JOptionPane.showMessageDialog(null,"snake"); break;
      case 10: JOptionPane.showMessageDialog(null,"horse"); break;
      case 11: JOptionPane.showMessageDialog(null,"sheep"); break;
    }
  }
}
