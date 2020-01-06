
import java.io.*;
import java.util.*;

import javax.swing.JOptionPane;

public class ReplaceText {
  public static void main(String[] args) throws Exception {
    
// Check command line parameter usage
String oldStr = JOptionPane.showInputDialog("Enter the Old String to Replace: ");
String newStr = JOptionPane.showInputDialog("Enter the New String to Replace: ");
	  
if ((oldStr+newStr).length() < 0) {
        JOptionPane.showMessageDialog(null,
        "Usage: java ReplaceText sourceFile and targetFile" +  oldStr + " and " + newStr);
      System.exit(1);
    }

    // Check if source file exists
    File sourceFile = new File("source.txt");
if (!sourceFile.exists()) {
JOptionPane.showMessageDialog(null,"Source file " + "source.txt" + " does not exist");
      System.exit(2);
    }

    // Check if target file exists
    String  targetName = "target" + System.currentTimeMillis() + ".txt";
    File targetFile = new File(targetName);
    if (targetFile.exists()) {
    	JOptionPane.showMessageDialog(null,"Target file " + "target.txt" + " already exists");
      System.exit(3);
    }

    // Create input and output files
    Scanner input = new Scanner(sourceFile);
    PrintWriter output = new PrintWriter(targetFile);
    
    
    while (input.hasNext()) {
      String s1 = input.nextLine();
      String s2 = s1.replaceAll(oldStr, newStr);
      output.println(s2);
    }
    
    input.close();
    output.close();
    
    int i =1;
    Scanner targetContent = new Scanner(targetFile);
    while (targetContent.hasNext()) {
    	String str = targetContent.nextLine();
    	JOptionPane.showMessageDialog(null,"Target file  Data Line " + i + ":   " + str);
    	i++;
      }

    
  }
}
