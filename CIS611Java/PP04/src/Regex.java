package PP4;

// May 5, 2019
// CIS 611 Programming Project 04
// Mary Clark with Tristan Krug
// Home of the regular expressions designed to find data on
// each web page
// the Regex class is not instantiated because the patterns
// are implemented as static final class variables.


import java.util.regex.Pattern;

public class Regex {



	//pattern attributes
	private Pattern pos;
	private Pattern num;
	private Pattern playerName;
	private Pattern status;
	private Pattern tckl;
	private Pattern sck;
	private Pattern intt;
	private Pattern team;
    static final Pattern EMPTY_PAIR = Pattern.compile("class=\"tbdy\"></td>\\z");
    static final Pattern STRIP_HTML = Pattern.compile("</?[a-z][a-z0-9]*[^<>]*>|<!--.*?-->");
    static final Pattern TEAM_HTML = Pattern.compile("\"(?ism)([A-Z]{3})(?<=\\\\s1&nb)\"");
    static final Pattern NO_RA = Pattern.compile("class=\"ra\">");
    static final Pattern END_PLAYER = Pattern.compile("</td></tr>");
    static final Pattern END_PAGE = Pattern.compile("</tbody></table>");

	//constructor is never called
	public Regex(Pattern pos, Pattern num, Pattern playerName, Pattern status, Pattern tckl, Pattern sck, Pattern intt,
			Pattern team) {
		this.pos = pos;
		this.num = num;
		this.playerName = playerName;
		this.status = status;
		this.tckl = tckl;
		this.sck = sck;
		this.intt = intt;
		this.team = team;
	}
 }
