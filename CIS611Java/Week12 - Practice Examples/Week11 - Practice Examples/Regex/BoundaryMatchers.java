package Regex;

	import java.util.regex.*;  
	
	public class BoundaryMatchers {
	
		public static void main(String args[]){  
			
			// the following regular expressions matches the whole text
			
		System.out.println("(., ) " + 
		    Pattern.matches(".", " ")); //False
		
				
	   // It would return true if string matches exactly "tom"
	   System.out.println("(tom, Tom) "+
	     Pattern.matches("tom", "Tom")); //False
		
	   /* returns true if the string matches exactly 
	    * "tom" or "Tom"
	    */
	   System.out.println("([Tt]om, Tom) " +
	        Pattern.matches("[Tt]om", "Tom")); //True
	   
	   System.out.println("([Tt]om, Tom) " + 
	     Pattern.matches("[Tt]om", "Tom")); //True
		
	   /* Returns true if the string matches exactly "tim" 
	    * or "Tim" or "jin" or "Jin"
	    */
	   System.out.println("([tT]im|[jJ]in, Tim) "+
	     Pattern.matches("[tT]im|[jJ]in", "Tim"));//True
	   
	   System.out.println("([tT]im|[jJ]in, jin) " +
	     Pattern.matches("[tT]im|[jJ]in", "jin"));//True
		
	   /* returns true if the string contains "abc" at 
	    * any place
	    */
	   System.out.println("(.*abc.*, deabcpq) " + 
	     Pattern.matches(".*abc.*", "deabcpq"));//True
		
	   /* returns true if the string does not have a 
	    * number at the beginning
	    */
	   System.out.println("(^[^\\d].*, 123abc) "+ 
	     Pattern.matches("^[^\\d].*", "123abc")); //False
	   
	   System.out.println("(^[^\\d].*, abc123) " +
	     Pattern.matches("^[^\\d].*", "abc123")); //True
		
	   // returns true if the string contains of three letters
	   System.out.println("([a-zA-Z][a-zA-Z][a-zA-Z], aPz) " +
	     Pattern.matches("[a-zA-Z][a-zA-Z][a-zA-Z]", "aPz"));//True
	   System.out.println("([a-zA-Z][a-zA-Z][a-zA-Z], aAA) " +
	     Pattern.matches("[a-zA-Z][a-zA-Z][a-zA-Z]", "aAA"));//True
	   System.out.println("([a-zA-Z][a-zA-Z][a-zA-Z], apZx) " +
	     Pattern.matches("[a-zA-Z][a-zA-Z][a-zA-Z]", "apZx"));//False
		
	   // returns true if the string contains 0 or more non-digits
	   System.out.println("(\\D*, abcde) " +
	     Pattern.matches("\\D*", "abcde")); //True
	   System.out.println("(\\D*, abcde123) " +
	     Pattern.matches("\\D*", "abcde123")); //False
		
	   /* Boundary Matchers example
	    * ^ denotes start of the line
	    * $ denotes end of the line
	    */
	   System.out.println("(^This$, This is Chaitanya) " +
	     Pattern.matches("^This$", "This is Chaitanya")); //False
	   System.out.println("(^This$, This) " +
	     Pattern.matches("^This$", "This")); //True
	   System.out.println("(^This$, Thiiiiiis) " +
			     Pattern.matches("^This$", "Thiiiiiis")); //false
	   System.out.println("(\\bThis\\b, This) " +
			     Pattern.matches("\\bThis\\b", "This")); //true
	   System.out.println("(\\s?This\\s?, This) " +
			     Pattern.matches("\\s?This\\s?", "This")); //true
	   System.out.println("(^This$, Is This Chaitanya) " +
	     Pattern.matches("^This$", "Is This Chaitanya")); //False
	}
	
	}


