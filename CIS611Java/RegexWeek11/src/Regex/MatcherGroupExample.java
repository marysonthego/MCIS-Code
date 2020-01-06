package Regex;

import java.util.regex.Pattern;
import java.util.regex.Matcher;

public class MatcherGroupExample {

    public static void main(String[] args) {

        String text    =
                  "John wrote about this, and John talked about that," +
                          " and John explained everything. "
                ;

        String patternString1 = "(John)";

        Pattern pattern = Pattern.compile(patternString1);
        Matcher matcher = pattern.matcher(text);

        int count = 0;
        while(matcher.find()) {
        	count++;
            System.out.println("found " + count +  ":" + matcher.group(1));
        }
        
        
  // Multiple Groups
        /*This (.+?) expression contains a few characters with special meanings in a regular expression. 
        The . means "any character". The + means "one or more times", and relates to the . 
        (any character, one or more times). 
        The ? means "match as small a number of characters as possible".*/
        
        System.out.println("Multiple Groups ---------------------------"); 
       

      patternString1 = "(John) (.+?) ";

      pattern = Pattern.compile(patternString1);
      matcher = pattern.matcher(text);

      while(matcher.find()) {
          System.out.println("found: " + matcher.group(1) +
                             " "       + matcher.group(2));
          System.out.println("found all groups: " + matcher.group(0) );
      }
        
      // Groups Inside Groups
      /*When groups are nested inside each other ((John) (.+?)), they are numbered based on 
      when the left paranthesis of the group is met. Thus, group 1 is the big group. 
      Group 2 is the group with the expression John inside. 
      Group 3 is the group with the expression .+? inside. 
      This is important to know when you need to reference the groups 
      via the groups(int groupNo) method.*/
        
      System.out.println("Groups Inside Groups ---------------------------"); 
      
      patternString1 = "((John) (.+?)) ";

      pattern = Pattern.compile(patternString1);
      matcher = pattern.matcher(text);

      while(matcher.find()) {
          System.out.println("found: < the outer group: "  + matcher.group(1) +
                             "> < The first inner group: "       + matcher.group(2) +
                             "> < The second inner group: "       + matcher.group(3) + ">");
      }  
      
      // replaceAll() + replaceFirst()
      /*The Matcher replaceAll() and replaceFirst() methods can be used 
      to replace parts of the string the Matcher is searching through. 
      The replaceAll() method replaces all matches of the regular expression. 
      The replaceFirst() only replaces the first match. */
      
      System.out.println("replaceAll() + replaceFirst()  ---------------------------");
      
      patternString1 = "((John) (.+?)) ";

      pattern = Pattern.compile(patternString1);
      matcher = pattern.matcher(text);

      String replaceAll = matcher.replaceAll("Joe Blocked ");
      System.out.println("replaceAll   = " + replaceAll);

      // Before any matching is carried out, the Matcher is reset, so that matching 
      // starts from the beginning of the input text.
      
      String replaceFirst = matcher.replaceFirst("Joe Blocked ");
      System.out.println("replaceFirst = " + replaceFirst);
      
      
      // appendReplacement() + appendTail()
      /*The Matcher appendReplacement() and appendTail() methods are 
      used to replace string tokens in an input text, 
      and append the resulting string to a StringBuffer.*/
      
      System.out.println(" appendReplacement() + appendTail()  ---------------------------");
      patternString1 = "((John) (.+?)) ";

     pattern      = Pattern.compile(patternString1);
     matcher      = pattern.matcher(text);
      StringBuffer stringBuffer = new StringBuffer();

      while(matcher.find()){
          matcher.appendReplacement(stringBuffer, "Joe Blocked ");
          System.out.println(stringBuffer.toString());
      }
      matcher.appendTail(stringBuffer);

      System.out.println(stringBuffer.toString());
      
    }
}