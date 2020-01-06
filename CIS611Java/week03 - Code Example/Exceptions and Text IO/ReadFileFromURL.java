
import java.util.Scanner;

import javax.swing.JOptionPane;

public class ReadFileFromURL {
  public static void main(String[] args) {
	  
	  // input url
	  String URLString = JOptionPane.showInputDialog("Enter a URL: ");
    
    try {
      java.net.URL url = new java.net.URL(URLString);
      int count = 0;
      Scanner input = new Scanner(url.openStream());
      while (input.hasNext()) {
        String line = input.nextLine();
        count += line.length();
      }

      JOptionPane.showMessageDialog(null,"The file size is " + count + " bytes");
    }
    catch (java.net.MalformedURLException ex) {
    	JOptionPane.showMessageDialog(null,"Invalid URL");
    }
    catch (java.io.IOException ex) {
    	JOptionPane.showMessageDialog(null,"IO Errors");
    }
  }
}
