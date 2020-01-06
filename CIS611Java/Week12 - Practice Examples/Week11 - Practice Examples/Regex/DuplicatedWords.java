package Regex;

import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class DuplicatedWords {
	
	public static void main(String args[]) throws Exception {
			      String duplicatePattern = "\\b(\\w+)\\b\\s+\\b\\1\\b";
			      String input="This This text text another another";
			      Pattern p = Pattern.compile("\\b(\\w+)\\b\\s+\\b\\1\\b");
			      Matcher m = p.matcher(input);
			      int matches = 0;
			      /*String phrase = " this is a test to test ";
			      Matcher m = p.matcher(phrase);*/
			      String val = null;
			      
			      while (m.find()) {
			         val = ":" + m.group() + ":";
			         System.out.println(val);
			         matches++;
			      }
			      
			      if(matches>0)
			         System.out.println("The string has matched with the pattern.");
			      else
			      System.out.println("The string has not matched with the pattern.");
			   
	}
			

}
