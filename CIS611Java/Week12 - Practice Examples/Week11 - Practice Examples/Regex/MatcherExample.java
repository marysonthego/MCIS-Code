package Regex;

public class MatcherExample {
	  // returns true if the string matches exactly "true"
	  public boolean isTrue(String s){
	    return s.matches("true");
	  }
	  // returns true if the string matches exactly "true" or "True"
	  public boolean isTrueVersion2(String s){
	    return s.matches("[tT]rue");
	  }

	  // returns true if the string matches exactly "true" or "True"
	  // or "yes" or "Yes"
	  public boolean isTrueOrYes(String s){
	    return s.matches("[tT]rue|[yY]es");
	  }

	  // returns true if the string contains exactly "true"
	  public boolean containsTrue(String s){
	    return s.matches(".*true.*");
	  }
	  

	  // returns true if the string contains of three letters
	  public boolean isThreeLetters(String s){
	    return s.matches("[a-zA-Z]{3}");
	    // simpler from for
//	    return s.matches("[a-Z][a-Z][a-Z]");
	  }



	  // returns true if the string does not have a number at the beginning
	  public boolean isNoNumberAtBeginning(String s){
	    return s.matches("^[^\\d].*");
	  }
	  // returns true if the string contains a arbitrary number of characters except b
	  public boolean isIntersection(String s){
	    return s.matches("([\\w&&[^b]])*");
	  }
	  // returns true if the string contains a number less then 300
	  public boolean isLessThenThreeHundred(String s){
	    return s.matches("[^0-9]*[12]?[0-9]{1,2}[^0-9]*");
	  }

	  
	  public static void main(String[] args) {
		  
		  MatcherExample m = new MatcherExample();
		  
	//    testing isTrue method
		  System.out.println(m.isTrue("true"));
		  System.out.println(m.isTrue("true2"));
		  System.out.println(m.isTrue("True"));
		  System.out.println();
		  
	//    testing isTrueVersion2 method
		  System.out.println(m.isTrueVersion2("true"));
		  System.out.println(m.isTrueVersion2("true2"));
		  System.out.println(m.isTrueVersion2("True"));
		  System.out.println();
		  
		  
    //	   testing isTrueOrYes method
		   System.out.println(m.isTrueOrYes("true"));
		   System.out.println(m.isTrueOrYes("yes"));
		   System.out.println(m.isTrueVersion2("Yes"));
		   System.out.println(m.isTrueOrYes("no"));
		   System.out.println();
		   
		   
		   
    //	   testing containsTrue method
		   System.out.println(m.containsTrue("thetruewithin"));
		   System.out.println(); 
		   
		   
		   
//		   testing isThreeLetters method
			   System.out.println(m.isThreeLetters("abc"));
			   System.out.println(m.isThreeLetters("abcd"));
			   System.out.println();  
			   
			   
//			   testing isNoNumberAtBeginning method
				   System.out.println(m.isNoNumberAtBeginning("abc"));
				   System.out.println(m.isNoNumberAtBeginning("1abcd"));
				   System.out.println(m.isNoNumberAtBeginning("a1bcd"));
				   System.out.println(m.isNoNumberAtBeginning("asdfdsf"));
				   System.out.println();  
				   
				   
				   
//				   testing isIntersection method
				   System.out.println(m.isIntersection("1"));
				   System.out.println(m.isIntersection("abcksdfkdskfsdfdsf"));
				   System.out.println(m.isIntersection("skdskfjsmcnxmvjwque484242"));
				   System.out.println();
				   
				   
//				   testing isLessThenThreeHundred method
				   System.out.println(m.isLessThenThreeHundred("288"));
				   System.out.println(m.isLessThenThreeHundred("3288"));
				   System.out.println(m.isLessThenThreeHundred("328 8"));
				   System.out.println(m.isLessThenThreeHundred("1"));
				   System.out.println(m.isLessThenThreeHundred("99"));
				   System.out.println(m.isLessThenThreeHundred("300"));				   
				   System.out.println();
		    
		  }
	  
	  
	  
	} 