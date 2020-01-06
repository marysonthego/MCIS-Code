import java.awt.*;
import java.io.*;
import java.net.*;
import javax.swing.* ;

public class SimpleWebSourceGetter {

    static void getSourceCode(String url)
    {
    	String mystring = "";
        try
        {
            //creating the URL
            URL pageURL = new URL(url);
            
            //Create the http url connection object
            HttpURLConnection urlConnection = (HttpURLConnection) pageURL.openConnection();
           
            //Reading the stream
            InputStream in = new BufferedInputStream(urlConnection.getInputStream());
            
            Reader r = new InputStreamReader(in);
            
            int c;
            while((c = r.read()) != -1)
            {
               mystring = mystring + String.valueOf((char)c);
            }// end reading loop
            
            
        }// end try block
        catch(MalformedURLException ex)
        {
            System.out.println(url + " is not a valid URL. Please enter a URL starting with http://");
        }// end catch for improper URL
        catch(IOException ie)
        {
            System.out.println("Error while reading: " + ie.getMessage());
        }// end catch for io reasons
        System.out.print(mystring);
    }// end getSourceCode method
    
    public static void main (String[] args)
    {
        String url = "http://www.ebay.com/itm/130480040659";
        getSourceCode(url);

    }  // end main method	
	
