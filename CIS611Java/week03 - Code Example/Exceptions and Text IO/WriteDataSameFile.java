

import javax.swing.JOptionPane;
import java.io.*;

public class WriteDataSameFile {

	public static void main(String[] args) throws Exception{
		String fileName = "scores.txt";
		File file = new File(fileName);

	    // Create a file
		FileWriter writer = new FileWriter(file, true);
	    PrintWriter output = new PrintWriter(writer);

	    // Write formatted output to the file
	    output.print("John T Smith ");
	    output.println(90);
	    output.print("Eric K Jones ");
	    output.println(85);
	    output.println("-----------------------------------------\n");

	    // Close the file
	    output.close();
	}

}
