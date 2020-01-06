package PP03;

public class PayRoll {

	private String fileName;
	private PayRecord[] payRecords;
    private static int numEmployees = 0;

	private  double totalNetPay;
	private  double avgNetPay;

	public PayRoll(String fileName, int n) {

		this.fileName = fileName;
                //this.payRecords = new PayRecord[n];
                this.payRecords = new PayRecord[n];
	}


   public void readFromFile(){

		// read the initial data from PayRoll file to create the full
	   // pay records with gross pay, taxes, and net pay, and then store it in PayRecord.txt file

	}


   public void writeToFile(){

		// write employees' pay records to the PayRecord.txt file, it should add employee pay record to the current file data

	}

	public void createEmployee(String fName, String lName, String street, int hNum, String city, String state, int zip, int empID, Status status) {
		// creates a new Employee object and add it to the employees array, you need to pass parameters to this method
       if (numEmployees < payRecords.length) {
        Employee employee = new Employee(fName, lName, street, hNum, city, state, zip, empID, status);
        numEmployees++;

        }
    }

    public void createPayRecord() {

		// creates a new PayRecord for an Employee object and add it to  the payRecords array, you need to pass parameters to this method

    }


    public  void displayPayRecord() {

		// it shows all payroll records for all currently added employee and the total net pay and average net pay in the GUI text area
    	// at should append data to text area, it must not overwrite data in the GUI text area

	}


   public double avgNetPay() {

		  	// returns the average of the total net pay of all added employees

	   return 0;

	}


}
