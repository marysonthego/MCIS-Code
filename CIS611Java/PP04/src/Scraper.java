package PP4;

// May 5, 2019
// CIS 611 Programming Project 04
// Mary Clark with Tristan Krug
// The scraper class is the workhorse of the application
// A scraper object is instantiated by the UserGui.scrape method


import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.IOException;
import java.io.InputStreamReader;
import java.net.URL;
import java.nio.charset.Charset;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;
import java.util.regex.Matcher;

public class Scraper {

	private Matcher emptyMatch, raMatch, stripMatch, endMatch, pageMatch;
    private Path outPath;
    private String outName = "NFLStat.txt";
    private Charset charset = Charset.forName("ISO_8859_1");
	private BufferedReader reader = null;
    private BufferedWriter writer = null;
    private StringBuilder sb;
    private String url;

    // The scraper constructor creates a BufferedWriter (writer) to
    // write the output to "NFLStat.txt"
	public Scraper () {
        try {
            outPath = Paths.get(outName);
            writer = Files.newBufferedWriter(outPath, charset);

        } catch (IOException e) {
        System.out.println("Error: " + e);
            }
    }
    // parseData is called repeatedly by UserGUI.scrape to extract
    // the data from a series of web pages by examining each line
    // for matches to patterns defined as static final in the Regex class.
    // parseData reads each line from the web page one by one.
    // Data from each web page is accumulated in a large StringBuilder (sb).
    // After all lines have been parsed, sb holds all the data retrieved from
    // the current web page. writeResults is called to write the contents of
    // sb to the file "NFLStat.txt".
	public void parseData(String url) throws IOException {
        this.url = url;
        try {
        reader = new BufferedReader(new InputStreamReader(new URL(url).openConnection().getInputStream()));
        } catch (IOException e) {
            System.out.println("\n Invalid URL \n");
        }

            String line;
            sb = new StringBuilder(40000);

            while ((line = reader.readLine()) != null) {
                if (line.startsWith("<td")) {
                    emptyMatch = Regex.EMPTY_PAIR.matcher(line);
                    raMatch = Regex.NO_RA.matcher(line);
                    stripMatch = Regex.STRIP_HTML.matcher(line);
                    endMatch = Regex.END_PLAYER.matcher(line);
                    pageMatch = Regex.END_PAGE.matcher(line);

                if (emptyMatch.find()) {
                    line = emptyMatch.quoteReplacement("--");
                    sb.append(line).append("\t");
                    continue;
                }
                if (raMatch.find()) {
                    continue;
                }
                if(stripMatch.find()) {
                    line = stripMatch.replaceAll("");
                    if (line.length() > 6 && line.contains("1&nbsp"))
                        line = line.substring(0,2);
                    sb.append(line).append("\t");
                    if (line.length() > 4 && line.length() <= 15)
                        sb.append("\t");
                }
                if (endMatch.find())
                    sb.append("\n");

                if (pageMatch.find())
                    break;
            }
        }
        writeResults();
    }

    // writeResults is called by parseData to write the contents of
    // the StringBuffer (sb) to the file NFLStat.txt
    private void writeResults() throws IOException {

        writer.write(sb.toString());
        //System.out.println("sb.toString =" + sb.toString());
    }

    // Display is called by UserGUI.scrape. Display returns the current
    // StringBuffer (sb) to UserGUI for display in a JTextArea
	// shows the output (scraped data) in a text-area
	public StringBuilder display(){
        return sb;
    }

    // getReader is called by UserGUI.scrape to get the reader
    // so that it can close it when all web page retrievals are done.
    public BufferedReader getReader() {
        return reader;
    }
    
    // getWriter is called by UserGUI.scrape to get the writer
    // so that it can close it when all web page retrievals are done.
    public BufferedWriter getWriter() {
        return writer;
    }
} //end class









