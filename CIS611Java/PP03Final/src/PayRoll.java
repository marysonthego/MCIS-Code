package PP03;

import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;
import java.text.DateFormat;
import java.text.NumberFormat;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.HashMap;
import java.util.Map;
import java.util.concurrent.TimeUnit;

import javax.swing.JFrame;
import javax.swing.JOptionPane;

public class PayRoll {

	private String fileName;
	private PayRecord[] payRecords;
	private Map<String, Employee> employees;
	private int maxNum;

	private double totalNetPay;
	private double avgNetPay;

	private BufferedReader buff;
	private static int pNum = 0;

	public PayRoll(String fileName, int n) {

		this.fileName = fileName;
		this.payRecords = new PayRecord[n];
		this.maxNum = n;

		try {
			this.readFromFile();
		} catch (IOException e) {
			e.printStackTrace();
		}

	}

	public void readFromFile() throws IOException {

		// [x] read the initial data from PayRoll file to create the full
		// pay records with gross pay, taxes, and net pay,
		// and then store it in PayRecord.txt file <- DO YOU ACTUALLY MEAN THIS?
		employees = new HashMap<String, Employee>();
		BufferedReader buff = new BufferedReader(new FileReader(fileName));
		try {
			String line = buff.readLine();
			while (line != null) {
				String[] temp = line.split(", ");
				if (temp[0].matches("employee")) {
					// create employee
					Address tempAdd = new Address(temp[5], temp[6], temp[7], temp[8], Integer.parseInt(temp[9].trim()));
					Status tempStat = null;
					if (temp[4].matches("FULLTIME")) {
						tempStat = Status.FullTime;
					} else if (temp[4].matches("HOURLY")) {
						tempStat = Status.Hourly;
					} else {
						System.out.println("error line 63");
						System.exit(0);
					}
					createEmployee(temp[2], temp[3], tempAdd, Integer.parseInt(temp[1]), tempStat);
				} else {
					// create pay period
					DateFormat formatter = new SimpleDateFormat("MM/dd/yy");
					Date begin = (Date) formatter.parse(temp[6]);
					Date end = (Date) formatter.parse(temp[7]);
					PayPeriod payP = new PayPeriod(Integer.parseInt(temp[5]), begin, end);

					// create pay record
					int type;
					if (temp[3].matches("(.*)<m>(.*)")) {
						// use full time (double int)
						type = 0;
					} else {
						// use part time constructor (double double)
						type = 1;
					}
					createPayRecord(type, Integer.parseInt(temp[1]), employees.get(temp[2]), payP,
							temp[3].replaceAll("[^\\d.]", ""), temp[4].replaceAll("[^\\d.]", ""));
				}
				line = buff.readLine();
			}

		} catch (FileNotFoundException | ParseException e) {
			e.printStackTrace();
		}
		buff.close();

		writeToFile();

	}

	public void writeToFile() throws IOException {

		// [ ] write employees' pay records to the PayRecord.txt file,
		// it should add employee pay record to the current file data

		String fileName = "PayRecord.txt";
		String output = "";
		for (int i = 0; i < pNum; i++) {
			output += payRecords[i].toString();
			output += System.lineSeparator();
		}
		BufferedWriter buff = new BufferedWriter(new FileWriter(fileName, true));
		buff.append(output);
		buff.close();
	}

	public void createEmployee(String firstName, String lastName, Address address, int eID, Status empStatus) {
		// [x] creates a new Employee object and add it to the employees array,
		// you need to pass parameters to this method
		Employee tempEmp = new Employee(firstName, lastName, address, eID, empStatus);
		employees.put(String.valueOf(eID), tempEmp);
	}

	public void createPayRecord(int type, int id, Employee emp, PayPeriod pay, String str1, String str2) {
		// [x] creates a new PayRecord for an Employee object and add it to the
		// payRecords array, you need to pass parameters to this method
		PayRecord tempRec = null;
		if (type == 0) {
			tempRec = new PayRecord(id, emp, pay, Double.parseDouble(str1), Integer.parseInt(str2));
		} else {
			tempRec = new PayRecord(id, emp, pay, Double.parseDouble(str1), Double.parseDouble(str2));
		}
		payRecords[pNum] = tempRec;
		pNum++;

	}

	public void createPayRecord(int type, int rID, int eID, int pID, Date pStart, Date pStop, String str1,
			String str2) {
		// test to find employee
		PayRecord tempRec = null;
		Employee emp = null;
		try {
			emp = employees.get(Integer.toString(eID));
			if (emp == null) {
				throw new Exception();
			}
		} catch (Exception e) {
			JOptionPane.showMessageDialog(null, "Invalid eID. Has the employee been created?");
			return;
		}

		// create pay period
		PayPeriod pay = new PayPeriod(pID, pStart, pStop);

		// add record
		if (type == 0) {
			tempRec = new PayRecord(rID, emp, pay, Double.parseDouble(str1), Integer.parseInt(str2));
		} else {
			tempRec = new PayRecord(rID, emp, pay, Double.parseDouble(str1), Double.parseDouble(str2));
		}
		payRecords[pNum] = tempRec;
		pNum++;
		// Update the text field and output with the new record
		UserGUI.updateTextArea(tempRec.toString());
		updateGUITotals();

		// test if max number of employees has been reached, terminate if true
		if (pNum >= payRecords.length) {
			JOptionPane.showMessageDialog(null,
					"The program must terminate after calculating " + (payRecords.length - 3) + " additional pay records");
			UserGUI.close();
		}
	}

	public void displayPayRecord() {

		// [x] it shows all payroll records for all currently added employee and the
		// total net pay and average net pay in the GUI text area should append data to
		// text area, it must not overwrite data in the GUI text area
		String output = "";
		for (int i = 0; i < pNum; i++) {
			output += payRecords[i].toString();
			output += System.lineSeparator() + System.lineSeparator();
		}
		output = output.substring(0, output.length() - 4);
		UserGUI.updateTextArea(output);
		updateGUITotals();
	}

	public double avgNetPay() {
		// [x] returns the average of the total net pay of all added employees
		double total = 0;
		for (int i = 0; i < pNum; i++) {
			total += payRecords[i].netPay();
		}
		return total / (pNum - 1);
	}
	
	public void updateGUITotals() {
		double total = 0;
		NumberFormat formatter = NumberFormat.getCurrencyInstance();
		for (int i = 0; i < pNum; i++) {
			total += payRecords[i].netPay();
		}
		String totString = formatter.format(total);
		String avgString = formatter.format(total/pNum);
		UserGUI.updateTotals(totString, avgString);
	}

	public long getDateDiff(Date date1, Date date2) {
		long diffInMillies = date2.getTime() - date1.getTime();
		return TimeUnit.DAYS.convert(diffInMillies, TimeUnit.MILLISECONDS);
	}

}
