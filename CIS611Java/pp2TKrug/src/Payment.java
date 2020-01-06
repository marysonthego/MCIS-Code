import java.io.FileNotFoundException;
import java.io.PrintWriter;
import java.io.UnsupportedEncodingException;
import java.text.NumberFormat;

import javax.swing.JOptionPane;

public class Payment {

	public static Validation validating;
	public static HashCode hashing;
	public static Customer[] customers;
	private static int it = 0;

	// DONE | this will check whether a card is valid
	public static Boolean isValidCard(String number) {
		Validation v = new Validation();
		return v.aValidNumber(number);

	}// end of the isValidCard method

	// DONE | creates a hash code for the credit card number to be stored in file
	public static String createHashCode(String number) {
		HashCode h = new HashCode();
		return h.getHashCode(number);

	}// end of the createHashCode method

	// DONE | adds a new customer to the array of customers once the payment is
	// successful
	public static void addCustomer(Customer customer) {
		customers[it] = customer;
		it++;
	} // end of the addCustomer method

	// displays the payments AVG, MAX payment, and MIN payment,
	// only for accepted payments with valid cards
	public static void displayStat() {
		double tot = 0;
		int max = 0;
		int min = 0;
		double temp = 0;
		for (int i = 0; i < customers.length; i++) {
			temp = customers[i].getAmount();
			if (temp > customers[max].getAmount()) {
				max = i;
			} else if (temp < customers[min].getAmount()) {
				min = i;
			}
			tot += temp;
		}
		NumberFormat formatter = NumberFormat.getCurrencyInstance();
		double avg = tot / customers.length;
		String moneyTemp = formatter.format(avg);
		String output = "";
		output += "The average transaction amount is " + moneyTemp + "\n";
		double doubleTemp = customers[max].getAmount();
		moneyTemp = formatter.format(doubleTemp);
		output += "The largest transaction was made by " + customers[max].getName() + " for " + moneyTemp + "\n";
		doubleTemp = customers[min].getAmount();
		moneyTemp = formatter.format(doubleTemp);
		output += "The smallest transaction was made by " + customers[min].getName() + " for " + moneyTemp + "\n";
		JOptionPane.showMessageDialog(null, output);

	}// end of the displayStat method

	// write data to file, the credit card number should be encrypted
	// using one-way hash method in the Hashing class
	public static void writeToFile() {
		try {
			PrintWriter w = new PrintWriter("output.txt", "UTF-8");
//			w.println("id, First Name, Last Name, Amount, Credit Card Number (hashed), Exp");
			if (it > 0) {
				for (Customer cust : customers) {
					w.println(cust.toString());
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
		// input the number of customers and store it into variable n
		// must hold the number of customers based on the user input
		int n = Input.readInt("Enter the number of customers to be added");
		customers = new Customer[n];

		// initialize a whole bunch of variables for user input
		int id = 0;
		String fName = "";
		String lName = "";
		String fullName = "";
		double amount = 0;
		long number = 0;
		String expDate = "";
		CreditCard tempCard;
		Customer tempCustomer;

		// loop through each customer
		boolean stop = false;
		int i = 1;
		while (!stop) {
			// read customer id
			id = Input.readInt("Enter the customers ID or 0 to exit.");
			if (id == 0) {
				Customer[] tempArr = new Customer[i - 1];
				for (int j = 0; j < i - 1; j++) {
					tempArr[j] = customers[j];
				}
				customers = tempArr;
				tempArr = null;
				stop = !stop;
				break;
			}
			fName = Input.readStr("Enter the First Name for customer " + i);
			lName = Input.readStr("Enter " + fName + "'s last name");
			fullName = fName + " " + lName;
			amount = Input.readDouble("Enter " + fullName + "'s transaction amount");
			number = Input.readLong("Enter " + fullName + "'s credit card number");
			if (number != 0L) {
				expDate = Input.readStr("Enter the expiration date for " + fullName + "'s credit card");
			} else {
				expDate = "N/A";
			}
			tempCard = new CreditCard(number, expDate);
			tempCustomer = new Customer(fName, lName, id, amount, tempCard);
			if (number != 0l) {
				addCustomer(tempCustomer);
				i++;
				if (i == n + 1) {
					stop = true;
					JOptionPane.showMessageDialog(null,
							n + " customer transactions have been added. The program will now stop.");
				}
			}
		}
		displayStat();
		writeToFile();
	}

}
