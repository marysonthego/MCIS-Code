package Regex;


/*For advanced regular expressions the java.util.regex.Pattern 
and java.util.regex.Matcher classes are used
*/


/*The Java Matcher class (java.util.regex.Matcher) is used to search through 
a text for multiple occurrences of a regular expression. You can also use 
a Matcher to search for the same regular expression in different texts.
*/

import java.util.regex.Matcher;
import java.util.regex.Pattern;


public class PatternMatcherExample {
	
	public static final String INPUT_STRING = "This is my small example "
			+ "string which I'm going to use for pattern matching";

	  public static void main(String[] args) {
	    
		 Pattern pattern = Pattern.compile("\\w+");
	    // in case you would like to ignore case sensitivity,
	    // you could use this statement:
	    // Pattern pattern = Pattern.compile("\\w+", Pattern.CASE_INSENSITIVE);
	    
		  Matcher matcher = pattern.matcher(INPUT_STRING); // Creating a Matcher is done 
		                                                   //via the matcher() method in the Pattern class.
	    // checks or finds all occurrence
		  /*You cannot use the matches() method to search for multiple 
		  occurrences of a regular expression in a text. 
		  For that, you need to use the find(), start() and end() methods. */
	    while (matcher.find()) {
	      System.out.print("Start index: " + matcher.start());
	      System.out.print(" End index: " + matcher.end() + " ");
	      System.out.println(matcher.group());
	    }
	    
	    // now create a new pattern and matcher to replace whitespace with tabs
	    Pattern replace = Pattern.compile("\\s+");
	    Matcher matcher2 = replace.matcher(INPUT_STRING);
	    System.out.println(matcher2.replaceAll("\t"));
	    
	    
	    // using matches() method that matches the regular expression against the whole text
	        String text = "This is the text to be searched " +
	            "for occurrences of the https://outlook.office365.com/owa/?realm=colostate.edu#path=/mail";

	        String patternString = ".*https://.*";

	        Pattern patternURL = Pattern.compile(patternString);

	        Matcher matcherURL = patternURL.matcher(text);
	        /*The matches() method in the Matcher class matches 
	        the regular expression against the whole text passed 
	        to the Pattern.matcher() method, when the Matcher was created.*/
	        System.out.println("URL is found:" + matcherURL.matches() );
	        
	        /*If the regular expression matches the whole text, 
	        then the matches() method returns true. 
	        If not, the matches() method returns false.
	        */
	  // using lookingAt() method to find a text matches the beginning of a text
	  // but not the whole text
	       text    =
	                "This is the text to be searched " +
	                "for occurrences of the http:// pattern.";

	        patternString = "This is the";

	        pattern = Pattern.compile(patternString, Pattern.CASE_INSENSITIVE);
	        matcher = pattern.matcher(text);

	        System.out.println("lookingAt = " + matcher.lookingAt());
	        System.out.println("matches   = " + matcher.matches());
	        
	        
	        
	  }

}
