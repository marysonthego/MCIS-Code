
 
import java.util.Scanner;

import javax.swing.JFileChooser;
import javax.swing.JOptionPane;

public class ReadFileUsingJFileChooser {
  public static void main(String[] args) throws Exception {
    
	  JFileChooser fileChooser = new JFileChooser();
    if (fileChooser.showOpenDialog(null)
        == JFileChooser.APPROVE_OPTION) {
      // Get the selected file
      java.io.File file = fileChooser.getSelectedFile();

      // Create a Scanner for the file
      Scanner input = new Scanner(file);

      // Read text from the file
      while (input.hasNext()) {
    	    JOptionPane.showMessageDialog(null,input.nextLine());
      }

      // Close the file
      input.close();
    }
    else {
        JOptionPane.showMessageDialog(null,"No file selected");
    }
  }
}
