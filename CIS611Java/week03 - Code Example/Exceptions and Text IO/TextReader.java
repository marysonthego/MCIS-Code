import java.io.*;
import java.util.*;
  
   public class TextReader {
     public static void main(String[] args) throws IOException {
   
      Scanner in = new Scanner(new FileReader("products.txt"));
    
       while(in.hasNextLine()){
        String line = in.nextLine();
  
  StringBuffer strBuf = new StringBuffer(line);
  
  //inserts "CMIS 141" into the text before the word "programming"
  strBuf.insert(8, "My name is John. ");
  
  //Display the contents of the StringBuffer class
  System.out.println(strBuf);
  
 //Adds the text "I hope I get an A!"
 strBuf.append(" Happy Holidays.\n");
  
 //Write the contents of the StringBuffer object to a file named "output.txt"
  File file = new File("output.txt");
   FileWriter writer = new FileWriter(file, true);
    PrintWriter output = new PrintWriter(writer);
     output.print(strBuf);
      output.close();
    }
  }
}