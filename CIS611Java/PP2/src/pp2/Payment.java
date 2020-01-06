package pp2;

import javax.swing.*;

public class Payment {

	public static Validation validating;
	public static HashCode hashing;
	public static Customer[] customers;

	// this will check whether a card is valid
	public static Boolean isValidCard(String number){

		return true;

	}// end of the isValidCard method

	// creates a hash code for the credit card number to be stored in file
    public static String createHashCode(String number){

		return null;

	}// end of the createHashCode method


     // it adds a new customer to the array of customers once the payment was successful
 	 public static void addCustomer(Customer customer){

 	 } // end of the addCustomer method


	// it displays the payments AVG, MAX payment, and MIN payment,
	// only for accepted payments with valid cards
	public static void displayStat(){

	}// end of the displayStat method


	// write data to file, the credit card number should be encrypted
	// using one-way hash method in the Hashing class
    public static void writeToFile(){

    } // end of the writeToFile method


	// the main entry method of the program that will get data from user and
	// perform the business logic
	public static void main(String[] args) {

		hashing = new HashCode();
		validating = new  Validation();
		String input = null;       // input the number of customers and store it into variable n
        int n = 0; // must hold the number of customers based on the user input
        boolean goodInput = false;
               
        //Get and validate user input for number of customers. Loop until a positive integer is entered.       
        input = JOptionPane.showInputDialog(null,"Enter the number of customers","Number of Customers", JOptionPane.PLAIN_MESSAGE);
        while (!goodInput) {
        try {
            n = Integer.parseInt(input);
            if ( n > 0) {
                goodInput = true;
            }
        } catch (NumberFormatException e) {
            goodInput = false;
            } finally {
                if (!goodInput)
                    input = JOptionPane.showInputDialog(null, "Number of Customers must be greater than 0. Please re-enter number of customers.", JOptionPane.ERROR_MESSAGE);
            }
        }
        //Valid number of customers received

        //Create the array of customers with the size entered by the user.
        customers = new Customer[n];
        
        goodInput = false;
        //Prompt for a credit card number. Display whether it is a valid or invalid number
        input = JOptionPane.showInputDialog(null,"Enter Credit Card Number", "Credit Card Number", JOptionPane.PLAIN_MESSAGE);
        while (!goodInput) {
        try {
            goodInput = validating.aValidNumber(input);
        } catch (NumberFormatException e) {
            goodInput = false;   
            } finally {
                if (!goodInput)
                    input = JOptionPane.showInputDialog(null, "Invalid Credit Card Number. Please re-enter Credit Card Number.", JOptionPane.ERROR_MESSAGE);
            }
        }
        System.out.println("You entered valid card number " + input);     
        System.exit(0);
	}

}
