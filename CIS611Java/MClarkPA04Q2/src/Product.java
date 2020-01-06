
//*********************************************************************
//*                                                                   *
//*  CIS611                  Spring, 2019             Mary Clark      *
//*                                                                   *
//*                     Program Assignment PA04Q2                     *
//*                                                                   *
//*                     Class Description                             *
//* Class Product                                                     *
//*                                                                   *
//* The main() method, which prompt the user to input the file name   *
//* of the input file (this may include the file path if the file is  *
//* not stored in the same project folder), creates two arrays        *
//* pName (String[]) and pPrice (double[]) of size 50, and then       *
//* sequentially calls and passes file name (path) pName, pPrice to   *
//* the static methods, readFromFile(), sortArrays, and writeToFile() *
//*                                                                   *
//* readFromFile() is a static method that will read data from the    *
//* enclosed “products.txt” text file with this document, and it      *
//* stores the product names and product prices in the method         *
//* parameters arrays pName and pPrice, respectively. After complete  *
//* reading data from file, the method should display a JOPtionPane   *
//* message dialog of the array elements (product names and prices)   *
//*                                                                   *
//* sortArrays() is a static method that passes the parameter arrays  *
//* pName and pPrice to the static selectionSort() method in the Sort *
//* class in order to sort both arrays based on the prices data       *
//* elements in the pPrice array, that means any change in the pPrice *
//* array will also results in a change in the pName array.           *
//*                                                                   *
//* writeToFile() is a static method that will write/store the sorted * 
//* arrays data elements in the parameter list (pName and pPrice) into*
//* a file (line by line), the data should be stored in the           *
//* “sortedProducts.txt” text file. After complete writing data to    *
//* file, the method should display a JOPtionPane message dialog of   *
//* the array elements (product names and prices) , data should be    *
//* sorted based on the product prices
//*                                                                   *
//*  Date Created: 02/25/2019                                         *
//*                                                                   *
//*  Saved in: Product.java                                           *
//*                                                                   *
//*********************************************************************

import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;
import java.nio.file.NoSuchFileException;
import java.nio.file.Path;
import java.nio.file.Paths;
import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.File;
import javax.swing.JOptionPane;

/**
 * @author Mary Clark
 *
 */
public class Product {

    public static void main(String[] args) {
        
        String[] pName = new String[50];
        Double[] pPrice = new Double[50];
        Path fullPath;
        String fileName = "products.txt";
        
        fileName = JOptionPane.showInputDialog("Enter a new filename or click OK to use products.txt",
                "products.txt");
        fullPath = Paths.get(fileName);
        try {
             fullPath = fullPath.toRealPath();
        } catch (NoSuchFileException e) {
            System.out.println("No Such File Exception " + e.getFile() + " " + e.getReason());
            JOptionPane.showMessageDialog(null, "No Such File Exception:\n" + e.getFile() + "\n Reason: " + e.getReason(), "Error", JOptionPane.ERROR_MESSAGE);
        } catch (IOException e) {
            System.out.println("IOException " + e);
            JOptionPane.showMessageDialog(null, "IO Exception:\n" + e.getMessage() + "\n" + e.getStackTrace(), "Error", JOptionPane.ERROR_MESSAGE);
        }
        fileName = fullPath.toString();
        readFromFile(fileName,pName,pPrice);
        sortArrays(pName,pPrice);
        writeToFile(pName,pPrice);
    }
    
    public static void readFromFile(String fileName, String[] pName, Double[]pPrice) {
        String input = new String("");
        File fileIn = new File(fileName);
        BufferedReader in = null;
        char separator = ',';
        int separatorAt = 0;
        
        System.out.println(fileIn.getAbsolutePath());
        try {
            in = new BufferedReader(new FileReader(fileIn));
            for ( int i=0; i<pName.length; i++) {
                if (in.ready()) {
                    input = in.readLine();
                    separatorAt = input.indexOf(separator);
                    pName[i] = input.substring(0,separatorAt);
                    pPrice[i] = ((Integer)(Integer.parseInt(input.substring(separatorAt+1,input.length())))).doubleValue();     
                   }
                }        
             }
            catch (java.io.FileNotFoundException e) {
                System.out.println("File Not Found Exception \n" + e.getMessage());
                JOptionPane.showMessageDialog(null, "File Not Found Exception \n" + e.getMessage(), "Error", JOptionPane.ERROR_MESSAGE);
            }
            catch(java.lang.NullPointerException e) {
                System.out.println("Null Pointer Exception " + e.getCause() + e.getStackTrace());
                JOptionPane.showMessageDialog(null, "Null Pointer Exception \n" + e.getMessage(), "Error", JOptionPane.ERROR_MESSAGE);
            }
            catch (java.io.IOException e) {
                System.out.println("IO Exception " + e.getCause() + e.getStackTrace());
                JOptionPane.showMessageDialog(null, "IO Exception \n" + e.getMessage(), "Error", JOptionPane.ERROR_MESSAGE);
            } 
            finally {
                try {
                    if (in != null)
                        in.close();
                } 
                catch (java.io.IOException e) {
                    System.out.println("IO Exception " + e.getCause() + e.getStackTrace());
                    JOptionPane.showMessageDialog(null, "IO Exception \n" + e.getMessage(), "Error", JOptionPane.ERROR_MESSAGE);
                    }
                }
        Object[] lines = new Object[pName.length];
        if (pName[0] == null) {
            JOptionPane.showMessageDialog(null, "Product List is empty.", "Error", JOptionPane.ERROR_MESSAGE);
            System.exit(0);
        }
        else {
            for (int x=0; x < lines.length; x++) {
                String theLine = String.format("%-20s %8.2f",pName[x], pPrice[x]);
                lines[x] = theLine;
            }
            JOptionPane.showMessageDialog(null,lines);
        }
    }
    
    public static void sortArrays(String[] pName, Double[] pPrice) {
        Sort.selectionSort(pName, pPrice);
    }
    
    public static void writeToFile(String[] pName, Double[]pPrice) {
        String fileName = "sortedProducts.txt";
        
        fileName = JOptionPane.showInputDialog("Enter a new filename or click OK to write products sorted by price to sortedProducts.txt", "sortedProducts.txt");
        File fileOut = new File(fileName);
        BufferedWriter out = null;
        String separator = ",";

        try {
            out = new BufferedWriter(new FileWriter(fileOut));
            for ( int i=0; i<pName.length; i++) {
                out.write(pName[i], 0, pName[i].length());
                out.write(separator,0,1);
                out.write(pPrice[i].toString(),0,(pPrice[i].toString()).length());
                out.newLine();
            }
        } 
        catch (IOException e) {
            System.out.println("IOException " + e);
            JOptionPane.showMessageDialog(null, "IO Exception:\n" + e.getMessage() + "\n" + e.getStackTrace(), "Error", JOptionPane.ERROR_MESSAGE);
        }
        finally {
            try {
                out.close();
            }
            catch (IOException e) {
                System.out.println("IOException " + e);
                JOptionPane.showMessageDialog(null, "IO Exception:\n" + e.getMessage() + "\n" + e.getStackTrace(), "Error", JOptionPane.ERROR_MESSAGE);
            }
        }
        
        Object[] lines = new Object[pName.length];
        if (pName[0] == null) {
            JOptionPane.showMessageDialog(null, "Product List is empty.", "Error", JOptionPane.ERROR_MESSAGE);
            System.exit(0);
        }
        else {
            for (int x=0; x < lines.length; x++) {
                String theLine = String.format("%-20s %8.2f",pName[x], pPrice[x]);
                lines[x] = theLine;
            }
            JOptionPane.showMessageDialog(null,lines);
        }
    }
}
