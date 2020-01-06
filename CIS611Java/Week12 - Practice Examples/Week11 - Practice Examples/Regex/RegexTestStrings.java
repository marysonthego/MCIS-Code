package Regex;

public class RegexTestStrings {
	
	public static final String InputString = "This is my small example "
		      + "string which I'm going to " + "use for pattern matching.";

		  public static void main(String[] args) {
		    System.out.println(InputString.matches("\\w.*"));
		    String[] splitString = (InputString.split("\\s+"));
		    System.out.println(splitString.length);// should be 14
		    for (String string : splitString) {
		      System.out.println(string);
		    }
		    // replace all whitespace with tabs
		    System.out.println(InputString.replaceAll("\\s+", "\t"));
		  }
		
} 

