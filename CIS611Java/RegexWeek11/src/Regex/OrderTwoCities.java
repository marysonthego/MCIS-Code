import javax.swing.JOptionPane;

public class OrderTwoCities {
  public static void main(String[] args) {
    
    
    // Prompt the user to enter two cities
	  String city1 = JOptionPane.showInputDialog("Enter the first city: ");
    
	 String city2 = JOptionPane.showInputDialog("Enter the second city: ");
    
    
    if (city1.compareTo(city2) < 0)
      System.out.println("The cities in alphabetical order are " +
         city1 + " " + city2);
    else
    	JOptionPane.showMessageDialog(null,"The cities in alphabetical order are " +
          city2 + " " + city1);
  }
}