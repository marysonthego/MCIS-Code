package Regex;

public class SpecialSymbols {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		// Definitions:
		
		/*inclusive:
		An inclusive range of numbers includes the first and 
		last number and all numbers in between.
       */
		
		
		/*Mutually exclusive:
		Two events are mutually exclusive 
		if they cannot occur at the same time (i.e., they have no outcomes in common).*/
		
		
		// social security match
		System.out.println("Social security pattern --------------------------------------------------");
		if ("222-33-4567".matches("[0-9]{3}-[\\d]{2}-[\\d]{4}"))
			System.out.println("It matches");
		else 
			System.out.println("No match");
		 
		
		// Even numbers pattern
				System.out.println("Even numbers pattern --------------------------------------------------");
				if ("126".matches("[\\d]*[02468]"))
					System.out.println("It matches");
				else 
					System.out.println("No match");
				
				
				// Local Phone number pattern
				System.out.println("local phone number pattern --------------------------------------------------");
				if ("(970) 491-1806".matches("\\([1-9][\\d]{2}\\) [\\d]{3}-[\\d]{4}"))
					System.out.println("It matches");
				else 
					System.out.println("No match");
				
				
				// International phone number pattern
				System.out.println("local phone number pattern --------------------------------------------------");
				if ("+218 92-6452812".matches("\\+[\\d]{1,3} [\\d]{2,3}-[\\d]{7,9}"))
					System.out.println("It matches");
				else 
					System.out.println("No match");
				
				
				// Last name pattern, it is at most 25 letters and first letter is in uppercase 
				System.out.println("local phone number pattern --------------------------------------------------");
				if ("Smith".matches("[A-Z][a-z]{1,24}"))
					System.out.println("It matches");
				else 
					System.out.println("No match");
				
				
				// java identifiers  
				System.out.println("Java identifiers pattern --------------------------------------------------");
				if ("_Employee_Name".matches("[a-zA-Z_$][\\w$]*"))
					System.out.println("It matches");
				else 
					System.out.println("No match");
				
				
				// Especial character pipe  
				/*| the vertical pipe separates a series of alternatives.
			    Example: "(a|b|c)a" matches "aa" or "ba" or "ca".*/
				System.out.println("Alternatives pattern --------------------------------------------------");
				if ("Welcome to HTML".matches("Welcome to (Java|HTML)"))
					System.out.println("It matches");
				else 
					System.out.println("No match");
				
		
	}

}
