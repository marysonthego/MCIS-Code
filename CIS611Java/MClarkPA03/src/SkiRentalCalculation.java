
import javax.swing.JOptionPane;
import java.util.regex.PatternSyntaxException;

//*********************************************************************
//*                                                                   *
//*  CIS611                  Spring, 2019             Mary Clark      *
//*                                                                   *
//*                     Program Assignment PA03                       *
//*                                                                   *
//*                     Class Description                             *
//* Java class SkiRentalCalulation.java has one method (main).        *
//* The class employs iterations, Single Dimensional Arrays, and      *
//* Try-Catch blocks for Input Validation.                            *
//* JOptionPanes are used to collect the following information:       *
//* 1. the total number of ski customers                              *
//* 2. First and Last name of each customer - f/Ex:"John Doe" is valid*
//*    Customer name is stored in nameArr[] - one per customer.       *
//* 3. Number of Days.                                                *
//* 4. The number of the rental units per customer. (0, 1, 2, or 3)   *
//* 5. Ski customer is a first time user (Yes or No)                  *
//* 6. Ski customer has a discount coupon (Yes or No)                 *
//* 7. Ski customer has a membership (Yes or No)                      *
//* 8. A rate table is used to calculate the total charge for each    *
//*    customer including 7.5% tax less any discounts.                *
//* 9. The total charge for one customer at a time is calculated and  *
//*    stored in valuesArr[] for each customer.                       *
//*10. The First and Last Name and total charge for each ski customer *
//*    is displayed, one per line, in a single JOptionPane.           *
//*                                                                   *
//* Console output is for debugging purposes.                         *
//*********************************************************************
//*  Date Created: 02/07/2019                                         *
//*  Date Re-Created (due to specification changes below) 2/14/2019   *
//*!!UPDATE 2/12/2019!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!*
//* PA03 - Another Note/Clarification                                 *
//* Sam Ghosh                                                         *
//* TO: All Sections                                                  *
//*                                                                   *
//* For PA03, certain fields (e.g. name,  number of ski customers,    *
//* number of days) must allow for freeform JOptionPane text entry.   *
//* Every freeform entry filed should be validated so that the program* 
//* does not crash (meaning handles the error and terminates          *
//* gracefully) if the field is kept empty, or if space is entered,   * 
//* or if invalid value is entered.                                   *
//*                                                                   *
//* For name, we cannot identify what could be a valid name           *
//* (value of abc could be a valid name, value of a1c could be a      *
//* valid name). I will test the name entry field in your submitted   *
//* code by entering no data, or empty string. The program should     * 
//* not crash.                                                        *
//*                                                                   *
//* I will test number of ski customers by entering no data,          *
//* empty data, and alphabetic value (e.g. abc) and the program       *
//* should not crash.                                                 *
//*                                                                   *
//* I will test number of days by entering no data, empty space,      *
//* and alphabetic value (e.g. abc) and the program should not crash. * 
//*                                                                   *
//* But for the input entry such as the ski membership, discount      *
//* coupon, and first time users, which are Yes/No value; they        *
//* can be designed using the combo box/drop-down selection.          *
//*                                                                   *
//*  Saved in: SkiRentalCalulation.java                               *
//*                                                                   *
//*********************************************************************

/**
 * @author Mary Clark
 *
 */
public class SkiRentalCalculation {
  
  public static void main(String[] args) {
    
    final double SALES_TAX_PERCENTAGE = 0.075;
    int numberOfDays = 0, numberOfCustomers = -1, numberOfRentalUnits = -1;
    int firstTimeUser = 0, hasCoupon = 0, hasMembership = 0;
    boolean goodName = false;
    String customerName = null;
    
    // Remove validSelections to comply with new specifications dated 2/12
    //Object[] validSelections = {0, 1, 2, 3};  
        
    /* Prompt for total number of customers > 0 */
    while (numberOfCustomers <= 0) {
      int retry = 0;
      String numberOfSkiCustomers = JOptionPane.showInputDialog("Enter the total number of ski "
          + "customers as a whole number greater than 0, e.g., 3");
      try {
          numberOfCustomers = Integer.parseUnsignedInt(numberOfSkiCustomers);
          
      } catch (NumberFormatException ex) {
        retry=JOptionPane.showConfirmDialog(null, "The number of customers must be an integer > 0. Press OK to retry or Cancel to quit.", "Retry?", JOptionPane.OK_CANCEL_OPTION);
      }
      finally {
        if(numberOfCustomers = 0)
          retry=JOptionPane.showConfirmDialog(null, "The number of customers must be an integer > 0. Press OK to retry or Cancel to quit.", "Retry?", JOptionPane.OK_CANCEL_OPTION);
          
         if (retry == 2)
          System.exit(0);
      }
    }
    
    /* create two arrays sized to the number of customers entered. */
    String[] namesArr = new String[numberOfCustomers];
    double[] valuesArr = new double[numberOfCustomers];
        
    for (int i=0; i<numberOfCustomers; ++i) {
      
      /* Removed this section to comply with new specifications dated 2/12 */
      /* Prompt for customer name
       * Valid form is: "Firstname<space>LastName"
       * First letter of each must be capitalized.
       * \A[A-Z][a-z]+ [A-Z][a-z][A-Z]?[a-z]*\Z
       * start at the beginning of the string «\A»
       * Match a single character in the range between “A” and “Z” (case sensitive) «[A-Z]»
       * Match a single character in the range between “a” and “z” (case sensitive) «[a-z]+»
       * Between one and unlimited times, as many times as possible, (greedy) «+»
       * Match the character “ ” literally « »
       * Match a single character in the range between “A” and “Z” (case sensitive) «[A-Z]»
       * Match a single character in the range between “a” and “z” (case sensitive) «[a-z]»
       * Match a single character in the range between “A” and “Z” (case sensitive) «[A-Z]?»
       * Between zero and one times, as many times as possible, (greedy) «?»
       * Match a single character in the range between “a” and “z” (case sensitive) «[a-z]*»
       * Between zero and unlimited times, as many times as possible, (greedy) «*»
       * Stop at the end of the string, or before the line break at the end of the string. «\Z»
       */
       /*
       while (!goodName) {
         // Prompt for customer's first and last name 
         customerName = JOptionPane.showInputDialog("Enter customer first and last name as: First Last");
         try {
           goodName = customerName.matches("\\A[A-Z][a-z]+ [A-Z][a-z][A-Z]?[a-z]*\\Z");
         } catch (PatternSyntaxException ex) {
           System.out.println("Invalid customer name entered. " + "\"" + customerName + "\"");
         } 
       } // end while
       */
      
       /* Per new specification, a name can:
        * - consist of a single word. Two names are not required.
        * - contain numeric characters such as "a1c" "222" "a27"
        */
      while (!goodName) {
        customerName = JOptionPane.showInputDialog("Enter customer name");
        if (customerName.isEmpty()) {
           JOptionPane.showMessageDialog(null, "Customer Name cannot be blank", "Error",JOptionPane.ERROR_MESSAGE);
        }
        else 
          goodName = true;
      }
       namesArr[i] = customerName;
       goodName = false;
       numberOfDays = 0;
       numberOfRentalUnits = -1;
       
       /* Prompt for number of ski days */
       while (numberOfDays <= 0) {
         String numberOfSkiDays = JOptionPane.showInputDialog("Enter the total number of ski "
             + "days as a whole number greater than 0, e.g., 3");
         try {
           numberOfDays = Integer.parseUnsignedInt(numberOfSkiDays);
             
         } catch (NumberFormatException ex) {
           JOptionPane.showMessageDialog(null,"Ski days must be an integer greater than zero.", "Error",JOptionPane.ERROR_MESSAGE);
           }
       }
       /* Removed this section to comply with new specifications dated 2/12 */
       /* Prompt for number of rental units (0 - 3) for current customer */
       /*
       numberOfRentalUnits = Integer.parseInt((JOptionPane.showInputDialog(null,  
            "Select the number of Rental Units:", "ShowInputDialog",  
            JOptionPane.PLAIN_MESSAGE, null, validSelections, validSelections[0])).toString());
       */
       
       while(numberOfRentalUnits < 0 || numberOfRentalUnits > 3) {
         String stringUnits = JOptionPane.showInputDialog("Enter the number of rental units between 0 and 3 for this customer");
         try {
           numberOfRentalUnits = Integer.parseUnsignedInt(stringUnits);
         } catch (NumberFormatException ex) {
             JOptionPane.showMessageDialog(null, "Number of rental units must be an integer between 0 and 3", "Error",JOptionPane.ERROR_MESSAGE);
         } finally {
           if (numberOfRentalUnits < 0 || numberOfRentalUnits > 3)
           {
             JOptionPane.showMessageDialog(null,"Number of rental units must be between 0 and 3", "Error",JOptionPane.ERROR_MESSAGE);
           }
         } 
       }
       firstTimeUser = JOptionPane.showConfirmDialog(null,"Is this customer a first time user?", "Choose One", JOptionPane.YES_NO_OPTION);
       
       hasCoupon = JOptionPane.showConfirmDialog(null,"Customer has a coupon?", "Choose One", JOptionPane.YES_NO_OPTION);
       
       hasMembership = JOptionPane.showConfirmDialog(null,"Customer is a member?", "Choose One", JOptionPane.YES_NO_OPTION);
       
       /* Calculate total charges for current customer */
       double baseRate = 0.0, membershipDiscount = 0.0, 
              firstTimeDiscount = 0.0, couponAmount = 0.0;
       
       switch (numberOfRentalUnits) {
         case 0: baseRate = 60.0;
                 if (firstTimeUser == 0) //yes == 0
                   firstTimeDiscount = 0.10;
                 if (hasMembership == 0) //yes == 0
                   membershipDiscount = 0.05;
                 if (hasCoupon == 0) //yes == 0
                   couponAmount = 5.0;
               break;
         case 1: baseRate = 110.0;
                 if (firstTimeUser == 0) //yes == 0
                   firstTimeDiscount = 0.12;
                 if (hasMembership == 0) //yes == 0
                   membershipDiscount = 0.08;
                 if (hasCoupon == 0) //yes == 0
                   couponAmount = 10.0;
                break;
         case 2: baseRate = 155.0;
                 if (firstTimeUser == 0) //yes == 0
                   firstTimeDiscount = 0.12;
                 if (hasMembership == 0) //yes == 0
                   membershipDiscount = 0.08;
                 if (hasCoupon == 0) //yes == 0
                   couponAmount = 10.0;
                break;
         case 3: baseRate = 190.0;
                 if (firstTimeUser == 0) //yes == 0
                   firstTimeDiscount = 0.12;
                 if (hasMembership == 0) //yes == 0
                   membershipDiscount = 0.08;
                 if (hasCoupon == 0) //yes == 0
                   couponAmount = 10.0;
                break;
         default:
                break;
       }
       
       baseRate *= numberOfDays;
       double taxableAmount = baseRate - (baseRate * firstTimeDiscount)
                            - (baseRate * membershipDiscount) - couponAmount;
       valuesArr[i] = taxableAmount + (taxableAmount * SALES_TAX_PERCENTAGE);
    } // end for
    
    String customerSummary = null;
    for (int i=0; i< numberOfCustomers; ++i) {
      if (i==0)
        customerSummary = String.format("%-20s %20.2f\n",namesArr[i],valuesArr[i]);
      else
        customerSummary = customerSummary.concat(String.format("%-20s %20.2f\n",namesArr[i],valuesArr[i]));
    }
    /* Display a list of all customer's names and total due */
    JOptionPane.showMessageDialog(null,
        customerSummary,
        "Customer Summary List",
        JOptionPane.INFORMATION_MESSAGE);
    System.exit(0);
  }
}
