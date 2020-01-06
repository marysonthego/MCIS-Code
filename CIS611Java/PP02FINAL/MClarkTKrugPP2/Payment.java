import java.awt.Color;
import java.awt.HeadlessException;
import java.io.FileNotFoundException;
import java.io.PrintWriter;
import java.io.UnsupportedEncodingException;

import javax.swing.*;
import java.text.*;
import java.time.*;

public class Payment {

	public static Validation validating;
	public static HashCode hashing;
	public static Customer[] customers;
	private static int it = 0;

	// this will check whether a card is valid
	public static Boolean isValidCard(String number) {
		boolean goodCard = false;
        
        try {
                goodCard = validating.aValidNumber(number);
            } catch (NumberFormatException e) {
            goodCard = false;   
            } 
        return goodCard;
	}// end of the isValidCard method

	// creates a hash code for the credit card number to be stored in file
	public static String createHashCode(String number) {
		return hashing.getHashCode(number);
	}// end of the createHashCode method

	// it adds a new customer to the array of customers once the payment was
	// successful
	public static void addCustomer(Customer customer) {
		customers[it] = customer;
		it++;
	} // end of the addCustomer method

	// it displays the payments AVG, MAX payment, and MIN payment,
	// only for accepted payments with valid cards
	public static void displayStat() {
		double tot = 0;
		int max = 0;
		int min = 0;
		double temp = 0;
		for (int i = 0; i < it; i++) {
			temp = customers[i].getAmount();
			if (temp > customers[max].getAmount()) {
				max = i;
			} else if (temp < customers[min].getAmount()) {
				min = i;
			}
			tot += temp;
		}
		String output = "";
		if (it > 0) {
			NumberFormat formatter = NumberFormat.getCurrencyInstance();
			double avg = tot / it;
			String moneyTemp = formatter.format(avg);
			output += "The average transaction amount is " + moneyTemp + "\n";
			double doubleTemp = customers[max].getAmount();
			moneyTemp = formatter.format(doubleTemp);
			output += "The largest transaction was made by " + customers[max].getfName() + " "
					+ customers[max].getlName() + " for " + moneyTemp + "\n";
			doubleTemp = customers[min].getAmount();
			moneyTemp = formatter.format(doubleTemp);
			output += "The smallest transaction was made by " + customers[min].getfName() + " "
					+ customers[min].getlName() + " for " + moneyTemp + "\n";
		} else {
			output = "No customer data. The program will now exit.";
		}
		JOptionPane.showMessageDialog(null, output);

	}// end of the displayStat method

	// write data to file, the credit card number should be encrypted
	// using one-way hash method in the Hashing class
	public static void writeToFile() {
		try {
			PrintWriter w = new PrintWriter("output.txt", "UTF-8");
//			w.println("id, First Name, Last Name, Amount, Credit Card Number (hashed), Exp");
			if (it > 0) {
				for (int i = 0; i < it; i++) {
					w.println(customers[i].toString());
				}
			}
			w.close();
		} catch (FileNotFoundException e) {
			e.printStackTrace();
		} catch (UnsupportedEncodingException e) {
			e.printStackTrace();
		}
	} // end of the writeToFile method

	// the main entry method of the program that will get data from user and
	// perform the business logic
	public static void main(String[] args) {

		hashing = new HashCode();
		validating = new Validation();
		String input = null; // input the number of customers and store it into variable n
		int n = 0; // must hold the number of customers based on the user input
		boolean goodInput = false;

		// Get and validate user input for number of customers. Loop until a positive
		// integer is entered.
		input = JOptionPane.showInputDialog(null, "Enter the number of customers", "Number of Customers",
				JOptionPane.PLAIN_MESSAGE);
        if (input == null) { //cancel button pressed
            System.exit(0);
        }
		while (!goodInput) {
			try {
				n = Integer.parseInt(input);
				if (n > 0) {
					goodInput = true;
				}
			} catch (NumberFormatException e) {
				goodInput = false;
			} finally {
				if (!goodInput)
					input = JOptionPane.showInputDialog(null,
							"Number of Customers must be greater than 0. Please re-enter number of customers.",
							JOptionPane.ERROR_MESSAGE);
                if (input == null) {  //cancel button pressed
                    System.exit(0);
                }
			}
		}
		// Valid number of customers received

		// Create the array of customers with the size entered by the user.
		customers = new Customer[n];
		goodInput = false;
		boolean stop = false;
		CreditCard tempCard;
		Customer tempCustomer;
         
		while (!stop) {
			// Prompt for a credit card number. Display whether it is a valid or invalid
			// number
            String inputMsg = "Please enter your credit card number.";
            int msgType = JOptionPane.PLAIN_MESSAGE;
            if (input == null) { //cancel button pressed
               System.exit(0);
            }
            
			try {
				input = JOptionPane.showInputDialog(null, inputMsg, "Credit Card Number", msgType);
                } catch (HeadlessException e) {
                     continue;
                    }
            if (input == null) { //cancel button pressed
               System.exit(0);
            }
				while (!isValidCard(input)) {
                    inputMsg = "Invalid Credit Card Number. Please re-enter Credit Card Number.";
                    msgType = JOptionPane.ERROR_MESSAGE;
					input = JOptionPane.showInputDialog(null, inputMsg, "Credit Card Number", msgType);
                    if (input == null) { //cancel button pressed
                        System.exit(0);
                    }
                }

			JOptionPane.showMessageDialog(null, "Card number " + input + " is valid");

			// Prompt for and validate card expiration date
			goodInput = false;
			String aDate = " ";
            inputMsg = "Enter the card expiration date as mm-dd-yyyy: ";
            msgType = JOptionPane.PLAIN_MESSAGE;
			while (!goodInput) {

                aDate = JOptionPane.showInputDialog(null, inputMsg, "Expiration Date", msgType);
                if (aDate == null)  //cancel button pressed
                    System.exit(0);
                
				String[] splitDate = aDate.split("-");
				if (splitDate.length < 3) {
					goodInput = false;
                    inputMsg = "Invalid date. Enter expiration date as mm-dd-yyyy: ";
                    msgType = JOptionPane.ERROR_MESSAGE;
					continue;
				}
                int year = 0;
                int mo = 0;
                int day = 0;
                
                try {
				year = Integer.parseInt(splitDate[2]);
				mo = Integer.parseInt(splitDate[0]);
				day = Integer.parseInt(splitDate[1]);
                } catch (NumberFormatException e) {
                    goodInput = false;
                    inputMsg = "Invalid date format. Enter expiration date as mm-dd-yyyy: ";
                    msgType = JOptionPane.ERROR_MESSAGE;
                    continue;
                }
                LocalDate cDate;
				try {
					cDate = LocalDate.of(year, mo, day);
				} catch (DateTimeException e) {
                    goodInput = false;
                    inputMsg = "Invalid date. Date is nonexistent. Enter expiration date as mm-dd-yyyy: ";
                    msgType = JOptionPane.ERROR_MESSAGE;
					continue;
				}
                LocalDate now = LocalDate.now();
                
				if (cDate.isBefore(now)) {
                    goodInput = false;
                    inputMsg = "Invalid date. The expiration date you entered is in the past. ";
                    msgType = JOptionPane.ERROR_MESSAGE;
                    continue;
                }
				if (cDate.isAfter(now.plusYears(3L))) {
                    goodInput = false;
                    inputMsg = "Invalid date. The expiration date you entered is more than 3 years in the future. ";
                    msgType = JOptionPane.ERROR_MESSAGE;
                    continue;
                }
                goodInput = true;
                
			}
			// create the card object
			tempCard = new CreditCard(Long.parseLong(input), aDate);

			// Prompt for id, fName, lName, amount in one dialog
			int id = 0;
			String fName = null, lName = null, amt = null;
			Double amount = 0.0;

			JTextField idField = new JTextField(5);
			JTextField fNameField = new JTextField(10);
			JTextField lNameField = new JTextField(10);
			JTextField amountField = new JTextField(9);

			JPanel myPanel = new JPanel();
			myPanel.add(new JLabel("ID:"));
			myPanel.add(idField);
			myPanel.add(new JLabel("First Name:"));
			myPanel.add(fNameField);
			myPanel.add(new JLabel("Last Name:"));
			myPanel.add(lNameField);
			myPanel.add(new JLabel("Amount:"));
			myPanel.add(amountField);

			goodInput = false;
			while (!goodInput) {
                goodInput = true;
				int result = JOptionPane.showConfirmDialog(null, myPanel,
						"Please enter the customer information or enter 0 into the ID field to quit ",
						JOptionPane.OK_CANCEL_OPTION);
                if (result == JOptionPane.CANCEL_OPTION) { //cancel button pressed
                    System.exit(0);
                }
				if (result == JOptionPane.OK_OPTION) {
                    try {
						id = Integer.parseInt(idField.getText());
						if (id == 0) {
							stop = !stop;
							break;
						} else if (id > 0 && id < 1000)
							goodInput = true;
						else
							idField.setBackground(Color.YELLOW);
					} catch (NumberFormatException e) {
						goodInput = false;
						idField.setBackground(Color.YELLOW);
					}

					fName = fNameField.getText();
					if (fName.length() <= 0) {
						goodInput = false;
						fNameField.setBackground(Color.YELLOW);
					}

					lName = lNameField.getText();
					if (lName.length() <= 0) {
						goodInput = false;
						lNameField.setBackground(Color.YELLOW);
					}

					amt = amountField.getText();
					try {
						amount = Double.parseDouble(amt);
                        if (amount <= 0.0) {
                            goodInput = false;
                            amountField.setBackground(Color.YELLOW);
                        }
					} catch (NumberFormatException e) {
						goodInput = false;
						amountField.setBackground(Color.YELLOW);
					}
				}
            }
            
            tempCustomer = new Customer(fName, lName, id, amount, tempCard);
            
            int result = JOptionPane.showConfirmDialog(null, tempCustomer.toString(), "Press OK to Make Your Payment or Cancel to quit.", JOptionPane.OK_CANCEL_OPTION);
            
            if (result == JOptionPane.OK_OPTION) {
                customers[it] = tempCustomer;
                    it += 1;
                if (it >= n)
                    stop = !stop;
            }
            else {
                JOptionPane.showMessageDialog(null, "Transaction was Cancelled","Cancel" , JOptionPane.OK_CANCEL_OPTION);
            }
            
		}
        displayStat();
		writeToFile();
    }	
	
}
