import javax.swing.*;

public class JOptionPaneShowInputDialogExample {
  public static void main(String[] args)   {
    
    
	  
	  // prompt the user to enter their name
    String name = JOptionPane.showInputDialog("What's your name?");

    // get the user's input. note that if they press Cancel, 'name' will be null
    JOptionPane.showMessageDialog(null,"The user's name is " + name + "\n and input lenghth is: " + name.length());
   
  }
}