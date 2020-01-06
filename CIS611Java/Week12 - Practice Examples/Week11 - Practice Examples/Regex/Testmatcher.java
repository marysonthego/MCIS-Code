import java.io.*;
import java.util.regex.*;
import javax.swing.*;
import java.awt.*;
	public class  Testmatcher{
		public String FindTarget;
		public String myInputFile;

		


		public void parsePages(Testmatcher s) {
			int startchar = 0;
			BufferedReader in = null;
			try {

				Pattern pattern;
				Matcher matcher;
				in = new BufferedReader(new FileReader(s.myInputFile));
				String line = "";

				pattern = Pattern.compile("This is the target");
				boolean found = false;

				while ((line = in.readLine()) != null && !found) {
					try {
						matcher = pattern.matcher(line);
						//System.out.println(line);
						if (matcher.find()) {
							s.FindTarget = line;
//							startchar = line.indexOf("T");
//						    s.FindTarget = line.substring(startchar, startchar + 18);						
							
							System.out.println("We found the target: " + s.FindTarget);

							found = true;
							} // end if
						
					}// end try 
					catch (Exception e) {
					}//end catch
				}// end while
				in.close();
			} // end try 
			catch (IOException ioe) {
			} // end catch

		} // parsePages method
		

		public static void main(String[] args) {

			Testmatcher temp = new Testmatcher();
			temp.myInputFile = "testmatcher.txt";
			String outfile = "PutStuffHere.txt";
			PrintWriter outputStream = null;
			String endLine = "\r\n";
			String tab = "\t";
		
			temp.parsePages(temp); // read one file with data, save into array
			try  //create output file
			{
				outputStream = new PrintWriter(outfile);
				//System.out.println("Opened output file");
			}// end try
			catch (FileNotFoundException e) {
				System.out.println("Error opening file: " + outfile);
			}// end catch

			outputStream.println(temp.FindTarget + tab + "more data here" + endLine);
			outputStream.close();
		} // end main method

	} // end class