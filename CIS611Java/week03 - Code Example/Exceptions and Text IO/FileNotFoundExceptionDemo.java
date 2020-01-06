
import java.io.*;
import java.util.Scanner;

import javax.swing.JOptionPane;

public class FileNotFoundExceptionDemo { 
  public static void main(String[] args) {
    
	    
    // Prompt the user to enter a file name
	  String message; 
	    message= "Enter a filename: ";
	        
	    // get the answer from user
	    String filename = JOptionPane.showInputDialog(message);
	    
	       
    try {
      
    	File file = new File(filename);
    	FileReader fr = new FileReader(file); 
      
      System.out.println("File " + filename + " exists "); 
      // Processing file ...
      
    /*  char [] a = new char[50];
      fr.read(a); // reads the content to the array
      for(char c : a)
          System.out.print(c); //prints the characters one by one
      fr.close();*/
      
    }
    catch (FileNotFoundException ex) {
      System.out.println("Exception - " +  "File Name: " + filename + " not found");
    } 
  }
}
