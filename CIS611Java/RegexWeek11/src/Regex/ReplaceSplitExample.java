package Regex;

public class ReplaceSplitExample {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		// Replace all matching substring
			System.out.println("Replace all matching substring --------------------------------------------------");
			System.out.println("Java Java Java".replaceAll("v\\w", "wi"));
		
		
		// Replace the first matching substring
		   System.out.println("Replace the first matching substring --------------------------------------------------");
		   System.out.println("Java Java Java".replaceFirst("v\\w", "wi"));
		   
		// Replace the first matching substring with quantifier (greedy)
		   System.out.println("Replace the first matching substring with a quantifier--------------------------------------------------");
		   System.out.println("Jaaavaa".replaceFirst("a+", "R"));
		   
		   
		// Replace the first matching substring with quantifier (greedy) and (reluctant quantifier) ?
		   System.out.println("Replace the first matching substring with a quantifier and reluctant ?--------------------------------------------------");
		   System.out.println("Jaaavaa".replaceFirst("a+?", "R"));	   
		   
		
		
		// The first overloaded spit method - split by the matching substring 
		   System.out.println("Split by the matching substring --------------------------------------------------");
		   String[] tokens = "Java1HTML2Pert3JavaScript".split("\\d");	
		   printTokens(tokens);
		   
		   
		// The second overloaded spit method - split by the matching substring a limit parameter
		   // limit = 0
		   System.out.println("Split matching substring with limit 0--------------------------------------------------");
		   tokens = "Java1HTML2Pert3JavaScript4".split("\\d",0);
		   printTokens(tokens);
		   
		   // limit = 1
		   System.out.println("Split matching substring with limit 1--------------------------------------------------");
		   tokens = "Java1HTML2Pert3JavaScript".split("\\d",1);
		   printTokens(tokens);
		   
		   // limit = 2
		   System.out.println("Split matching substring with limit 2--------------------------------------------------");
		   tokens = "Java1HTML2Pert3JavaScript".split("\\d",2);
		   printTokens(tokens);
		   
		   
		   // limit = 3
		   System.out.println("Split matching substring with limit 3--------------------------------------------------");
		   tokens = "Java1HTML2Pert3JavaScript".split("\\d",3);
		   printTokens(tokens);
		   
		   // limit = 4
		   System.out.println("Split matching substring with limit 4--------------------------------------------------");
		   tokens = "Java1HTML2Pert3JavaScript".split("\\d",4);
		   printTokens(tokens);
		   
		   // limit = 5
		   System.out.println("Split matching substring with limit 5--------------------------------------------------");
		   tokens = "Java1HTML2Pert3JavaScript".split("\\d",5);
		   printTokens(tokens);
		   
		   
		   
		   
	}
	
	public static void printTokens(String[] tokens) {
		for (String token:tokens)
		    System.out.print(token + ", ");
		 System.out.println();
	}

}
