package Regex;

import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class SimpleMatcherExample {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		// fixed string
		System.out.println("fixed string --------------------------------------------------");
		String str= new String("Java");
		
		if (str.matches("Java") || str.equals("Java"))
			System.out.println("It matches");
		else 
			System.out.println("It is not matching");
		
		
		// String follow a pattern
		System.out.println("String follow a pattern --------------------------------------------------");
		if ( "Java is fun".matches("Java.*") && "Java is cool".matches("Java.*") 
				  && "Java is powefull".matches("Java.*")) // .* matches 0 or more characters
			System.out.println("It matches");
		else 
			System.out.println("No match");
		
		
		
		// Pattern to find the word "Joe" or the word "Jim" or both
				System.out.println("Pattern 'Joe' or the word 'Jim' or both--------------------------------------------------");
				if ( "humbapumpa jim".matches(".*(jim|joe).*"))
					System.out.println("It matches");
				else 
					System.out.println("No match");
				if ("humbapumpa jom".matches(".*(jim|joe).*"))
					System.out.println("It matches");
				else 
					System.out.println("No match");
				if ("humbaPumpa joe".matches(".*(jim|joe).*"))
					System.out.println("It matches");
				else 
					System.out.println("No match");
				if ("humbapumpa joe jim".matches(".*(jim|joe).*"))
					System.out.println("It matches");
				else 
					System.out.println("No match");
				
		//   Pattern for phone number matching ##########, ### #######, or ###,#######
				System.out.println("Pattern for phone number--------------------------------------------------");
				if ( "1233323322".matches("\\d\\d\\d([,\\s])?\\d\\d\\d\\d"))
					System.out.println("It matches");
				else 
					System.out.println("No match");
				if ( "1233323".matches("\\d\\d\\d([,\\s])?\\d\\d\\d\\d"))
					System.out.println("It matches");
				else 
					System.out.println("No match");
				if ( "123 3323".matches("\\d\\d\\d([,\\s])?\\d\\d\\d\\d"))
					System.out.println("It matches");
				else 
					System.out.println("No match");
				if ( "123,3323".matches("\\d\\d\\d([,\\s])?\\d\\d\\d\\d"))
					System.out.println("It matches");
				else 
					System.out.println("No match");
		
			
		//   Regular expression for a number range
							System.out.println("Pattern for a certain number range--------------------------------------------------");
							if ( "1233".matches("\\d{3}")) // to get a match (.*"\\d{3}".*)
								System.out.println("It matches");
							else 
								System.out.println("No match");
							if ( "0".matches("\\d{3}"))
								System.out.println("It matches");
							else 
								System.out.println("No match");
							if ( "29 Kasdkf 2300 Kdsdf".matches("\\d{3}")) // to get a match (.*"\\d{3}".*)
								System.out.println("It matches");
							else 
								System.out.println("No match");
							if ( "99900234".matches("\\d{3}")) // to get a match (.*"\\d{3}".*)
								System.out.println("It matches");
							else 
								System.out.println("No match");
							
							
		//   Regular expression for a number range using Pattern&Matcher classes
							System.out.println("Pattern for a certain number range using Pattern&Matcher classes--------------------------------------------------");
							if ( testRange("1233"))
								System.out.println("It matches");
							else 
								System.out.println("No match");
							if ( testRange("0"))
								System.out.println("It matches");
							else 
								System.out.println("No match");
							if ( testRange("29 Kasdkf 2300 Kdsdf"))
								System.out.println("It matches");
							else 
								System.out.println("No match");
							if ( testRange("99900234"))
								System.out.println("It matches");
							else 
								System.out.println("No match");
					
             //   Regular expression for a word boundry
							System.out.println("Pattern for a word boundry--------------------------------------------------");
							if ( testWordBoundry("This island is beautiful"))
								System.out.println("It matches");
							else 
								System.out.println("No match");
							
							
              //   Regular expression to find duplicated words (\\b(\\w+) \\1\\b)
							System.out.println("Pattern for duplicated words--------------------------------------------------");
							if ( testduplicatedWords("Java Java Method Method"))
							 System.out.println("It matches");
							else 
							System.out.println("No match");	
							if ( "this this".matches("\\b(\\w+) \\1\\b"))
								 System.out.println("It matches");
								else 
								System.out.println("No match");	
							
							
			//   Regular expression to find a word in case it starts in a new line
							System.out.println("Pattern for duplicated words--------------------------------------------------");
							if ( testduplicatedWords("Java Java Method Method"))
							 System.out.println("It matches");
							else 
							System.out.println("No match");	
							if ( "this this".matches("\\b(\\w+) \\1\\b"))
								 System.out.println("It matches");
								else 
								System.out.println("No match");	
	}
	
	 
	public static boolean testRange (String s){
		    Pattern pattern = Pattern.compile("\\d{3}");
		    Matcher matcher = pattern.matcher(s);
		    if (matcher.find()){
		      return true; 
		    } 
		    return false; 
		  }

	public static boolean testWordBoundry (String s){
	    Pattern pattern = Pattern.compile("\\bis\\b"); // for word island use regex "\\bi.*d\\b"
	    Matcher matcher = pattern.matcher(s);
	    if (matcher.find()){
	      return true; 
	    } 
	    return false; 
	  }
	
	
	public static boolean testduplicatedWords (String s){
	    Pattern pattern = Pattern.compile("\\b(\\w+)\\s+\\1\\b"); 
	    Matcher matcher = pattern.matcher(s);
	    if (matcher.find()){
	         
	    	return true; 
	    } 
	    return false; 
	  }
	
}
