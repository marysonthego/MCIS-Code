package TechStore;

import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;
 
public class BufferedReaderExample {
 
	public static void main(String[] args) {
 
		BufferedReader br = null;
 
		try {
 
			String line;
 
			br = new BufferedReader(new FileReader("data.txt"));
 
			while ((line = br.readLine()) != null) {
				
				String[] stringArr = line.split(";");
				for (String s:stringArr)
				   System.out.print(s + ";" + "");
				
				System.out.println();
			}
 
		} catch (IOException e) {
			e.printStackTrace();
		} finally {
			try {
				if (br != null)br.close();
			} catch (IOException ex) {
				ex.printStackTrace();
			}
		}
 
	}
}
