import javax.swing.Icon;
import javax.swing.ImageIcon;
import javax.swing.JOptionPane;

public class ShowMessageDialogExample2 {
	
	public static void main(String[] args) {
	       String[] choices = {"Soccer", "Basketball", "Football", "Boxing", "None of these sports", "Quit"};
	       int response = JOptionPane.showOptionDialog(
	               null                       // Center in window.
	               , "What is your favourit sports?"        // Message
	               , "Sport Survey"               // Title in titlebar
	               , JOptionPane.YES_NO_OPTION  // Option type
	               , JOptionPane.PLAIN_MESSAGE  // messageType
	               , null                       // Icon (none)
	               , choices                    // Button text as above.
	               , "None of your business"    // Default button's label
	       );
	 
	       //The first usage for joptionpane showmessagedialog example
	       JOptionPane.showMessageDialog(null, "Your Choice" + choices[response]);
	       //The second usage for joptionpane showmessagedialog example
	       JOptionPane.showMessageDialog(null, "You choose " + choices[response], "Your Choice", JOptionPane.INFORMATION_MESSAGE);
	       //The third usage for joptionpane showmessagedialog example
	       Icon icon = new ImageIcon("images/smile.jpg");
	       JOptionPane.showMessageDialog(null, "You choose " + choices[response], "Your Choice", JOptionPane.INFORMATION_MESSAGE, icon);
	 
	   }

}
