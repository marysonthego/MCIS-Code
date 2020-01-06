import java.io.*;
import java.util.regex.*;
import javax.swing.*;
import java.awt.*;

	public class  Testmatcher2 {
		public static String MyWebPageURL;
		public static String myInputFile;
		

		


		public static void parsePages(String line) {
			int startchar = 0;
			
			

				Pattern pattern;
				Matcher matcher;				
				pattern = Pattern.compile("(This is the target)");
//				pattern = Pattern.compile("<a href=\"(.*?)\">binary");
				boolean found = false;

				
					try {
						matcher = pattern.matcher(line);
						//System.out.println(line);
						if (matcher.find()) {
					
							
							System.out.println("We found the target: " + matcher.group());

							found = true;
						} // end if
						else{
							System.out.println("We did not find the target: ");
							found = false;
						}// end else
						
					}// end try 
					catch (Exception e) {
						
					
					}//end catch
				
				


		} // parsePages method
		

		public static void main(String[] args) {

			
			MyWebPageURL = "http://techcrunch.com/2011/05/07/why-the-new-guy-cant-code/";
			WebSourceGetter sg = new WebSourceGetter();
			parsePages(sg.getSourceCode(MyWebPageURL));
			String outfile = "PutStuffHere.txt";
			PrintWriter outputStream = null;
			String endLine = "\r\n";
			String tab = "\t";
		
			 // read one file with data, save into array
			try  //create output file
			{
				outputStream = new PrintWriter(outfile);
				//System.out.println("Opened output file");
			}// end try
			catch (FileNotFoundException e) {
				System.out.println("Error opening file: " + outfile);
			}// end catch

			outputStream.println("put data here" + tab + "more data here" + endLine);
			outputStream.close();
		} // end main method

	} // end class