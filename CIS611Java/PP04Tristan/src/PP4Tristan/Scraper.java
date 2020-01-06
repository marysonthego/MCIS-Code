package PP4;

import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.net.URL;
import java.util.ArrayList;
import java.util.regex.Matcher;
import java.util.regex.Pattern;
import java.util.stream.Collectors;

import javax.swing.JOptionPane;

public class Scraper {

	private Regex regex;
	private String url;
	private String display;

	// constructor
	public Scraper(String url) {
		this.url = url;
		
		Pattern td = c("(?:<td class=\"tbdy\".*?>)(.*?)(?:<\\/td>)"); //matches all but TEAM and Name
		Pattern str = c("(?:<a href=\".*?\">)(.*?)(?:<\\/a>)"); // matches TEAM and Name
		this.regex = new Regex(td, td, str, td, td, td, td, str);
	}

	// reads the data from a web page and searches for the string matches
	public void parseData() {

		// pull the full site html of url into pageData
		String pageData = getHTML(url);

		// get list of pages from site pagination
		ArrayList<String> pages = getPages(pageData);
		// ...and add the original URL to pages
		pages.add(0, url);

		// scrape each page in pages for its player data table
		// and concatenate the data together
		String playerData = null;
		String temp = null;
		for (String l : pages) {
			// grab page HTML
			temp = getHTML(l);
			// and parse out the table body
			Matcher m = Pattern.compile("(?:<tbody>)(.*?)(?=<\\/tbody>)", Pattern.MULTILINE | Pattern.DOTALL)
					.matcher(temp);
			m.find();
			temp = m.group(0);
			// append
			playerData += temp + System.lineSeparator();
		}

		// regex the concatenated string to loop through each record
		Matcher m = Pattern.compile("(?:<tr class=\"(?:even|odd)\">)(.*?)(<\\/tr>)", Pattern.MULTILINE | Pattern.DOTALL)
				.matcher(playerData);

		display = "";
		temp = null;
		Matcher m1 = null;
		Matcher m2 = null;
		// build display string by looping through each player
		// and pulling off each data point
		while (m.find()) {
			temp = m.group(1);

			// setup the three matchers
			m1 = regex.getPos().matcher(temp);
			m2 = regex.getPlayerName().matcher(temp);

			m1.find(); // initialize matches
			m2.find();

			display += m1.group(1) + "\t"; // add pos
			m1.find();
			display += m1.group(1) + "\t"; // add num
			display += padString(m2.group(1)) + "\t"; // add name

			m1.find(); // move to next search item
			m2.find();

			display += m1.group(1) + "\t"; // add status
			m1.find();
			display += m1.group(1) + "\t"; // add TCKL
			m1.find();
			display += m1.group(1) + "\t"; // add SCK
			m1.find();
			m1.find(); // skip FF
			display += m1.group(1) + "\t"; // add INT
			display += m2.group(1) + System.lineSeparator(); // add TEAM
		}
		
	}

	// pass scraped data back
	public String display() {
		return this.display;
	}

	private Pattern c(String str) {
		// a wrapper for Pattern.compile() so I don't have to type it all out
		// includes the multiline & dotall options that I always forget to add
		return Pattern.compile(str, Pattern.MULTILINE | Pattern.DOTALL);
	}

	private ArrayList<String> getPages(String pageHTML) {
		// get links to each page of results
		
		String siteRoot = null;
		ArrayList<String> output = new ArrayList<String>();

		// find and bind the site root to build the full nav links later
		Matcher m0 = Pattern.compile("^(.*?)(.com)").matcher(url);
		m0.find();
		siteRoot = m0.group(0);

		// pull the pagination HTML section
		Matcher m1 = Pattern.compile("(?:<span class=\"linkNavigation floatRight\">)(.*?)(<\\/span)",
				Pattern.MULTILINE | Pattern.DOTALL).matcher(pageHTML);
		m1.find();
		String nav = m1.group(1);

		// within the pagination section, pull of each individual link from the pagination
		// use the pageRoot to build the full navigation link
		Matcher m2 = Pattern.compile("(?:href=\")(.*?)(?:\")", Pattern.MULTILINE | Pattern.DOTALL).matcher(nav);
		while (m2.find()) {
			output.add(siteRoot + m2.group(1).replaceAll("&amp;", "&"));
		}

		// remove duplicates from output if they exist
		output = (ArrayList<String>) output.stream().distinct().collect(Collectors.toList());

		return output;
	}

	private String getHTML(String pageURL) {

		StringBuilder sb = new StringBuilder();
		BufferedReader br = null;

		// pull the full site html into sb
		try {
			URL webAddress = new URL(pageURL);
			br = new BufferedReader(new InputStreamReader(webAddress.openStream()));

			String line;

			while ((line = br.readLine()) != null) {
				sb.append(line);
				sb.append(System.lineSeparator());
			}

			br.close();

		} catch (Exception e) {
			JOptionPane.showMessageDialog(null, e.getMessage());
			System.exit(0);
		}

		return sb.toString();
	}

	private String padString (String str) {
		while (str.length()<30) {
			str = str + " ";
		}
		return str;
	}
}// end class