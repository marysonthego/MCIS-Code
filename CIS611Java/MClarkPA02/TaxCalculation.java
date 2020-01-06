import javax.swing.JOptionPane;

//*********************************************************************
//*                                                                   *
//*  CIS611                  Spring, 2019             Mary Clark      *
//*                                                                   *
//*                     Program Assignment PA02                       *
//*                                                                   *
//*                     Class Description                             *
//* Java class TaxCalulation.java has one main method where various   *
//* pieces of the code are written. JOptionPane gets the following    *
//* two input values.                                                 *
//* 1. Income of the person                                           *
//* 2. Status (Single, or Married) of the person.                     *
//* For the sake of simplicity, only these two status are used        *
//* for this assignment (the status of head of household etc. are     *
//* ignored).                                                         *
//* Write more code to determine the tax of the person, based on the  *
//* above two input values, and also by using the tax table from the  *
//* PA01 assignment. Finally, display the tax of the person in        *
//* JOptionPane.                                                      *
//* The coding will be done so that any value of the income can be    *
//* entered and a value of Single or Married can be entered, and the  *
//* tax will be calculated. The grader will only enter the positive   *
//* value of the income to grade the assignment.                      *
//*                                                                   *
//* Console output is for debugging purposes.                         *
//*                                                                   *
//*  Date Created: 02/02/2019                                         *
//*                                                                   *
//*  Saved in: TaxCalculation.java                                    *
//*                                                                   *
//*********************************************************************

/**
 * @author Mary Clark
 *
 */
public class TaxCalculation{

  public static void main(String[] args) {
    
    String calculateTax;
    
    // Loop to perform tax calculation while calculateTax = true
    while (Boolean.parseBoolean(calculateTax = JOptionPane.showInputDialog
        ("Would you like to calculate your tax? True or False: "))) {
      
      // Prompt for income as an integer
      String incomeInputValue =JOptionPane.showInputDialog("Enter your income "
        + "as a whole number without decimals or commas, E.g., 15125");
    
      // Convert entered String to double
      double incomeInDouble=Double.parseDouble(incomeInputValue);

      // Prompt for filing status Single or Married - case sensitive
      String statusInString =JOptionPane.showInputDialog("Enter your filing status "
        + "as Single or Married.");
      
      int statusInInt = 0;
    
      switch(statusInString){    
        case "Single":
        case "single":
          statusInInt = 0;
            break;
        case "Married":
        case "married":  
          statusInInt = 1;
            break;
        default:
        // Default section of the code is executed if the value entered does 
        // not match the above values
          statusInInt = -1;
          System.out.println("No filing status match.");
          JOptionPane.showMessageDialog(null,"Filing Status \"" + statusInString + "\" not found.","Error",JOptionPane.ERROR_MESSAGE);
      } //end switch
    
      // An if statement is used for calculating the tax using the tax table 
      // from PA01 to determine the tax of the person. 

      double t1 = 0.0, t2 = 0.0, t3 = 0.0, t4 = 0.0, t5 = 0.0, t6 = 0.0; 
      double tax = 0.0;
      // initializing variable tax to a value
    
      if(statusInInt == 0) { // Status is Single
        // Code to calculate the tax based on income if status is Single
        if(incomeInDouble <= 8350.0) {
          tax = incomeInDouble * 0.10;
          t1  = incomeInDouble * 0.10;
        
        } else if(
          (incomeInDouble >= 8351.0 && incomeInDouble <= 33950.0)) {
          tax = ((incomeInDouble - 8350) * 0.15) + (8350 * 0.10);
          t1 = 8350.0 * 0.10;
          t2 = (incomeInDouble - 8350.0) * 0.15;
              
        } else if((incomeInDouble >= 33951.0 && incomeInDouble <= 82250.0)) {
          tax = ((incomeInDouble - 33950) * 0.25) + ((33950 - 8350) * 0.15) + (8350 * 0.10);
          t1 = 8350.0 * 0.10;
          t2 = (33950.0 - 8350.0) * 0.15;
          t3 = (incomeInDouble - 82250.0) * 0.25;
      
        } else if (incomeInDouble >= 82251.0 && incomeInDouble <= 171550.0) { 
          tax = ((incomeInDouble - 82250) * 0.28) + ((82250 - 33950) * 0.25) + ((33950 - 8350) * 0.15) + (8350 * 0.10);
          t1 = 8350.0 * 0.10;
          t2 = (33950.0 - 8350.0) * 0.15;
          t3 = (82250.0 - 33950.0) * 0.25;
          t4 = (incomeInDouble - 82250.0) * 0.28;
      
        } else if (incomeInDouble >= 171551.0 && incomeInDouble <= 372950.0) {
          tax = ((incomeInDouble - 171550) * 0.33) + ((171550 - 82250) * 0.28) + ((82250 - 33950) * 0.25) + ((33950 - 8350) * 0.15) + (8350 * 0.10);
          t1 = 8350.0 * 0.10;
          t2 = (33950.0 - 8350.0) * 0.15;
          t3 = (82250.0 - 33950.0) * 0.25;
          t4 = (171550.0 - 82250.0) * 0.28;
          t5 = (incomeInDouble - 171550.0) * 0.33;
        
        } else if (incomeInDouble >= 372951.0) {
          tax = ((incomeInDouble - 372950) * 0.35) + ((372950 - 171550) * 0.33) + ((171550 - 82550) * 0.28) + ((82550 - 33950) * 0.25) +  ((33950 - 8350) * 0.15) + (8350 * 0.10);
          t1 = 8350.0 * 0.10;
          t2 = (33950.0 - 8350.0) * 0.15;
          t3 = (82250.0 - 33950.0) * 0.25;
          t4 = (171550.0 - 82250.0) * 0.28;
          t5 = (372950.0 - 171550.0) * 0.33;
          t6 = (incomeInDouble - 372951.0) * 0.35;
        }
    } // End if status is Single
      
    else if(statusInInt == 1 ) { //Status is Married
        if(incomeInDouble <= 16700.0) {
          tax = incomeInDouble * 0.10;
          t1  = incomeInDouble * 0.10;
          
        } else if(
            (incomeInDouble >= 16701.0 && incomeInDouble <= 67900.0)) {
          tax = ((incomeInDouble - 16700) * 0.15) + (16700 * 0.10);
          t1 = 16700.0 * 0.10;
          t2 = (incomeInDouble - 16700.0) * 0.15;
                
        } else if((incomeInDouble >= 67901.0 && incomeInDouble <= 137050.0)) {
          tax = ((incomeInDouble - 67900) * 0.25) + ((67900 - 16700) * 0.15) + (16700 * 0.10);
          t1 = 16700.0 * 0.10;
          t2 = (67900.0 - 16700.0) * 0.15;
          t3 = (incomeInDouble - 67900.0) * 0.25;
        
        } else if (incomeInDouble >= 137051.0 && incomeInDouble <= 208850.0) { 
          tax = ((incomeInDouble - 137050) * 0.28) + ((137050 - 67900) * 0.25) + ((67900 - 16700) * 0.15) + (16700 * 0.10);
          t1 = 16700.0 * 0.10;
          t2 = (67900.0 - 16700.0) * 0.15;
          t3 = (137050.0 - 67900.0) * 0.25;
          t4 = (incomeInDouble - 137050.0) * 0.28;
        
        } else if (incomeInDouble >= 208851.0 && incomeInDouble <= 372950.0) {
          tax = ((incomeInDouble - 208850) * 0.33) + ((208851 - 137050) * 0.28) + ((137050 - 67900) * 0.25) + ((67900 - 16700) * 0.15) + (16700 * 0.10);
          t1 = 16700.0 * 0.10;
          t2 = (67900.0 - 16700.0) * 0.15;
          t3 = (137050.0 - 67900.0) * 0.25;
          t4 = (208850.0 - 137050.0) * 0.28;
          t5 = (incomeInDouble - 208850.0) * 0.33;
          
        } else if (incomeInDouble >= 372951.0) {
          tax = ((incomeInDouble - 372950) * 0.35) + ((372950 - 208850) * 0.33) + ((208850 - 137050) * 0.28) + ((137050 - 67900) * 0.25) +  ((67900 - 16700) * 0.15) + (16700 * 0.10);
          t1 = 16700.0 * 0.10;
          t2 = (67900.0 - 16700.0) * 0.15;
          t3 = (137050.0 - 67900.0) * 0.25;
          t4 = (208850.0 - 137050.0) * 0.28;
          t5 = (372950.0 - 208850.0) * 0.33;
          t6 = (incomeInDouble - 372951.0) * 0.35;
          
        }
    } // End if Married
    
    System.out.println("t1 = " + t1);
    System.out.println("t2 = " + t2);
    System.out.println("t3 = " + t3);
    System.out.println("t4 = " + t4);
    System.out.println("t5 = " + t5);
    System.out.println("t6 = " + t6);
    double sum = t1 + t2 + t3 + t4 + t5 + t6;
    System.out.println("sum = " + sum);
    System.out.println("tax = " + tax);
    tax = sum;
    
    // Use JOptionPane to display the income, status, and the computed tax.
    // using the variable statusInString to display filing status instead of showing 0, or 1
    // Use \n to display each value on a new line.
    JOptionPane.showMessageDialog(null, "Income = "+ incomeInDouble + "\n"+
                    " Status = "+ statusInString  + "\n"+ 
                    "Tax= " + tax); 
    } //end while
  } //end main()
} //end class TaxCalculation
