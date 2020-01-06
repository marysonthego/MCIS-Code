package Regex;

import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class SimpleLinkMatching {
	
	public static void main(String args[]){  
	
	//Pattern htmltag;
	//Pattern link;
	Pattern htmlATag = Pattern.compile("<a\\s+\\b[^>]*href=\"[^>]*>(.*?)</a>"); // <a .....</a>
	Pattern link = Pattern.compile("href=\"[^>]*\">"); // href= .......>
	
	String linkStr = "<a href=\"https://uk.yahoo.com/\" data-ylk=\""
			+ "t5:home;slk:home;\"class=\"Td(n)! Td(u)!:h Fz(13px) "
			+ "C(#fff)!\"><i id=\"my-home\" class=\"Fl(start) NavLinks_Lh(1.7) "
			+ "Mend(6px) Ycon YconHome Fz(13px) Mt(-1px) Td(n)! "
			+ "Td(n)!:h C(#fff)!\">&#x2302;</i><b class=\"Mstart(-1px) Fw(400) "
			+ "C(#fff)!\">Home</b></a>"
			+ "<a href=\"https://uk.eurosport.yahoo.com/\" data-ylk=\"t5:sports;slk:sports;\""
					+ "class=\"Td(n)! Td(u)!:h Fz(13px) C(#fff)!\">Sport</a>"
			+ "<a href=\"http://uk.finance.yahoo.com/\" data-ylk=\"t5:finance;slk:finance;\""
			+ "class=\"Td(n)! Td(u)!:h Fz(13px) C(#fff)!\">Finance</a>\""
			+ "<a href=\"https://uk.screen.yahoo.com/\" data-ylk=\"t5:screen;slk:screen;\""
			+ "class=\"Td(n)! Td(u)!:h Fz(13px) C(#fff)!\">Screen</a>\"";
	Matcher aTagmatch = htmlATag.matcher(linkStr);
	
	
	//if (tagmatch.matches())// matches methods only true when the whole text matches the regex;
		                    // it is better to use find() method that searches for a match in the  entire text
	int count =1;
	while (aTagmatch.find()) {
	
	System.out.println(" The Group matching "+ count+ ": " + aTagmatch.group());
	Matcher linkMatcher = link.matcher(aTagmatch.group());
	linkMatcher.find();
	String linkURL = linkMatcher.group().replaceFirst("href=\"", "").replaceAll("/\".*", "");
	System.out.println(" TheURL Link Matching "+ count+ ": "+ linkURL);
	count++;
	
	}
	
		
	}

}
