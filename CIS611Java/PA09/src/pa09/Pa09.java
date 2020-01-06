package PA09;

import java.awt.List;
import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.File;
import java.io.IOException;
import java.nio.charset.Charset;
import java.nio.file.Files;
import java.nio.file.Path;
import java.util.regex.Matcher;
import java.util.regex.Pattern;
import javax.swing.JFileChooser;
import javax.swing.JOptionPane;
import javax.swing.filechooser.FileNameExtensionFilter;

/*
 * Program: Pa09
 * Author: Mary Clark
 * Date: 4/26/2019
 *
 * Write a Java program that reads text strings from the enclosed retail store
 * web source fileIn “RetailStore.txt”.
 * the program parses the data to return a list of matches for two things,
 * all products’ names and their suggested retail prices
 * (Product Title and Suggested Retail Price.)
 * The program must ignore (i.e., it does not return) products that do not
 * have the suggested retail prices data.
 * All retrieved data should be stored in a fileIn "matcherout.txt”.
 * Also, the program output must be displayed in a single JOPtionPane message box.
 */

public class Pa09 {

    private File fileIn;
    private String outName = "matcherout.txt";
    private Path inPath = null;
    private Path outPath = null;
    private Charset charset = Charset.forName("ISO_8859_1");
    private BufferedReader reader = null;
    private BufferedWriter writer = null;
    private String productName, msrp;
    private Pattern p1 = Pattern.compile("((?:title=\")(.+?)(?:\"\\shref))");
    private Pattern p2 = Pattern.compile("((?:Suggested Retail Price: )(.+?)(?:\"\\sclass))");
    private Matcher m1, m2;
    private int productCount = 0, lineNumber = 1;
    private List list = new List();

    //open input & output files, call readFile with path to input file
    private void openFiles() throws IOException {
        //prompt for text input file
        JFileChooser fc = new JFileChooser();
        FileNameExtensionFilter filter = new FileNameExtensionFilter("Text File", "txt");
        fc.setFileFilter(filter);
        int returnVal = fc.showOpenDialog(null);
        //user has picked an input file
        if(returnVal == JFileChooser.APPROVE_OPTION) {
            fileIn = fc.getSelectedFile();
            inPath = fileIn.toPath();
        }
        //create or truncate output file in the same directory
        //set path to point to output file relative to input file location
        outPath = inPath.resolveSibling(outName);
        writer = Files.newBufferedWriter(outPath, charset);
        readFile(inPath);
        JOptionPane.showMessageDialog(null, list, "Results",JOptionPane.INFORMATION_MESSAGE);
        reader.close();
        writer.close();
    }

    //loop, reading from input file until next line is null
    private void readFile(Path path) throws IOException {
        String line = null;
        //create reader and read first line
        reader = Files.newBufferedReader(path, charset);
        line = reader.readLine();

        //this loop drives the whole read-parse-write sequence
        //while there are lines to read, loop to parse and write each line
        while (line != null) {
            parseProduct(line);
            line = reader.readLine();
            lineNumber++;
        }
    }
    //parse an input line and send it to writeResults
    private void parseProduct(String aLine) throws IOException {

         m1 = p1.matcher(aLine);
        if (m1.find()) {
            productName = m1.group(2);
            m2 = p2.matcher(aLine);
            if (m2.find()) {
                msrp = m2.group(2);
                writeResults(productName, msrp);
            }
            else {
                msrp = null;
            }
            m2.reset();
        }
        m1.reset();
    }

    //format and write a line to the output file and add to list to display
    //in a JOptionPane
    private void writeResults(String productName, String msrp) throws IOException {
        String line = null;

        productCount++;
        System.out.println("Count = " + productCount +" lineNumber = " + lineNumber +"\n");

        line = "Title: " + productName + ", Suggested Retail Price: " + msrp;
        System.out.println(line);
        writer.write(line);
        writer.newLine();
        writer.flush();
        lineNumber++;
        list.add(line + "\n");
    }

    public static void main(String[]args) {
        Pa09 worker = new Pa09();
        try {
        worker.openFiles();

        }catch (IOException e) {
            try {
                worker.reader.close();
                worker.writer.close();
            } catch (IOException ex) {
                }
        }
    }
}