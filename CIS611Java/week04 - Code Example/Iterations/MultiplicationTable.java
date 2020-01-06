

import javax.swing.JOptionPane;

public class MultiplicationTable {
  /** Main method */
  public static void main(String[] args) {
    // Display the table heading
	  JOptionPane.showMessageDialog(null,"           Multiplication Table");

    // Display the number title
	String output = "";
    System.out.print("    ");
    for (int j = 1; j <= 9; j++)
    	output+="   " + j;
        output+="\n-----------------------------------------\n";

    // Print table body
    for (int i = 1; i <= 9; i++) {
      output+=i + " | ";
      for (int j = 1; j <= 9; j++) {
        // Display the product and align properly
    	  output+= i * j;
      }
      output+="\n";
    }
    JOptionPane.showMessageDialog(null,output);

  }
}
