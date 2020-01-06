package PP03;

import java.awt.BorderLayout;
import java.awt.Container;
import java.awt.FlowLayout;
import java.awt.GridLayout;
import java.awt.event.ActionEvent;
import java.awt.event.FocusAdapter;
import java.awt.event.FocusEvent;

import javax.swing.JButton;
import javax.swing.JComboBox;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.JScrollPane;
import javax.swing.JTextArea;
import javax.swing.JTextField;

public class UserGUI extends JPanel {

	private JButton TransferButton;
	private JButton CloseButton, addEmployeeButton, addRecordButton;
	private static JTextArea textArea;
	private JScrollPane jp;
	private PayRoll payRoll;
	private String fileName = "PayRoll.txt";
	private boolean loop = true;
	private static final String[] dayOpt = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14",
			"15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31" };
	private static final String[] monthOpt = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" };
	private static final String[] yearOpt = { "2019", "2018", "2017", "2016", "2015", "2014", "2013", "2012", "2011",
			"2010" };
	private static final String[] empOpt = { "Full Time", "Hourly" };
	private static JPanel employeePane, addressPaneMaster, addressPane1, addressPane2, datePane1, datePane2,
			payPeriodPane, payRecordPane, payRecordSub, employeeSub, payPeriodMaster, payMaster, employeeHeader,
			payHeader, outputPane, textPane, controlPane;
	private static JComboBox<String> dayList1, monthList1, yearList1, dayList2, monthList2, yearList2, empList;
	private static JTextField street, houseNum, city, state, zip, rID, pID, multi1, multi2, eID, firstName, lastName;
	public static JLabel multiLabel1, multiLabel2;
	JScrollPane scroll;

	public UserGUI() {
		int n = 0;

		// prompt the user to input the number of pay records
		while (loop) {
			String temp = JOptionPane.showInputDialog(null, "Number of employees to add");
			if (temp == null)
				System.exit(0);
			try {
				n = Integer.parseInt(temp);
				if (n < 1)
					throw new Exception();
				loop = false;
				n += 3;
			} catch (Exception e) {
				JOptionPane.showMessageDialog(null, "Invalid input. Please enter an integer greater than 0.");
			}
		}

		// create payroll
		payRoll = new PayRoll(fileName, n);
		initGUI();
		doTheLayout();
		payRoll.displayPayRecord();

		addRecordButton.addActionListener(new java.awt.event.ActionListener() {
			public void actionPerformed(ActionEvent e) {
				transfer();
			}
		});
		
		addEmployeeButton.addActionListener(new java.awt.event.ActionListener() {
			public void actionPerformed(ActionEvent e) {
				transfer();
			}
		});

		CloseButton.addActionListener(new java.awt.event.ActionListener() {
			public void actionPerformed(ActionEvent e) {
				close();
			}
		});

		empList.addActionListener(new java.awt.event.ActionListener() {

			public void actionPerformed(ActionEvent e) {
				String trigger = empList.getSelectedItem().toString();
				if (trigger == "Hourly") {
					multiLabel1.setText("Pay Hours");
					multiLabel2.setText("Pay Rate");
				} else {
					multiLabel1.setText("Monthly Income");
					multiLabel2.setText("Number of Months");
				}
				multi1.setText("");
				multi2.setText("");
			}
		});

		zip.addFocusListener(new FocusAdapter() {
			// checks to see if the value entered for zipcode is an integer
			public void focusLost(FocusEvent e) {
				if (!zip.getText().isEmpty()) {
					try {
						int tempNum = Integer.parseInt(zip.getText());
					} catch (Exception ex) {
						JOptionPane.showMessageDialog(null, "Please enter an integer for Zip Code");
						zip.setText("");
					}
				}
			}
		});

		eID.addFocusListener(new FocusAdapter() {
			// checks to see if the value entered for eID is an integer
			public void focusLost(FocusEvent e) {
				if (!eID.getText().isEmpty()) {
					try {
						int tempNum = Integer.parseInt(eID.getText());
					} catch (Exception ex) {
						JOptionPane.showMessageDialog(null, "Please enter an integer for ID");
						eID.setText("");
					}
				}
			}
		});

		rID.addFocusListener(new FocusAdapter() {
			// checks to see if the value entered for rID is an integer
			public void focusLost(FocusEvent e) {
				if (!rID.getText().isEmpty()) {
					try {
						int tempNum = Integer.parseInt(rID.getText());
					} catch (Exception ex) {
						JOptionPane.showMessageDialog(null, "Please enter an integer for ID");
						rID.setText("");
					}
				}
			}
		});

		pID.addFocusListener(new FocusAdapter() {
			// checks to see if the value entered for rID is an integer
			public void focusLost(FocusEvent e) {
				if (!pID.getText().isEmpty()) {
					try {
						int tempNum = Integer.parseInt(pID.getText());
					} catch (Exception ex) {
						JOptionPane.showMessageDialog(null, "Please enter an integer for ID");
						pID.setText("");
					}
				}
			}
		});
		
		multi1.addFocusListener(new FocusAdapter() {
			// checks to see if the value entered for rID is an integer
			public void focusLost(FocusEvent e) {
				if (!multi1.getText().isEmpty()) {
					try {
						double tempNum = Double.parseDouble(multi1.getText());
					} catch (Exception ex) {
						JOptionPane.showMessageDialog(null, "Please enter a number for " + multiLabel1.getText());
						multi1.setText("");
					}
				}
			}
		});

		multi2.addFocusListener(new FocusAdapter() {
			// checks to see if the value entered for rID is an integer
			public void focusLost(FocusEvent e) {
				if (!multi2.getText().isEmpty()) {
					if (empList.getSelectedItem().toString() == "Full Time") {
						try {
							double tempNum = Integer.parseInt(multi2.getText());
						} catch (Exception ex) {
							JOptionPane.showMessageDialog(null, "Please enter an integer for " + multiLabel2.getText());
							multi2.setText("");
						}
					} else {
						try {
							double tempNum = Double.parseDouble(multi2.getText());
						} catch (Exception ex) {
							JOptionPane.showMessageDialog(null, "Please enter a number for " + multiLabel2.getText());
							multi2.setText("");
						}
					}
				}
			}
		});

	} // end of constructor

	private void initGUI() {
		// output pane
		outputPane = new JPanel();
		textPane = new JPanel();
		controlPane = new JPanel();
		controlPane.setLayout(new GridLayout(1, 2));
		outputPane.setLayout(new BorderLayout());

		// address
		addressPane1 = new JPanel(new FlowLayout(FlowLayout.LEFT));
		addressPane2 = new JPanel(new FlowLayout(FlowLayout.LEFT));
		addressPaneMaster = new JPanel(new GridLayout(2, 1));

		street = new JTextField(25);
		houseNum = new JTextField(15);
		city = new JTextField(15);
		state = new JTextField(10);
		zip = new JTextField(10);

		// pay period
		payPeriodPane = new JPanel(new FlowLayout(FlowLayout.LEFT));
		rID = new JTextField(3);
		datePane1 = new JPanel(new GridLayout(1, 3));
		dayList1 = new JComboBox<String>(dayOpt);
		monthList1 = new JComboBox<String>(monthOpt);
		yearList1 = new JComboBox<String>(yearOpt);
		datePane2 = new JPanel(new GridLayout(1, 3));
		dayList2 = new JComboBox<String>(dayOpt);
		monthList2 = new JComboBox<String>(monthOpt);
		yearList2 = new JComboBox<String>(yearOpt);
		payPeriodMaster = new JPanel(new BorderLayout());

		// employee
		employeeHeader = new JPanel(new FlowLayout(FlowLayout.LEFT));
		employeeSub = new JPanel(new FlowLayout(FlowLayout.LEFT));
		employeePane = new JPanel(new BorderLayout());
		eID = new JTextField(3);
		firstName = new JTextField(9);
		lastName = new JTextField(10);
		empList = new JComboBox<String>(empOpt);

		// payrecord
		payHeader = new JPanel(new FlowLayout(FlowLayout.LEFT));
		payRecordSub = new JPanel(new FlowLayout(FlowLayout.LEFT));
		pID = new JTextField(3);
		multi1 = new JTextField(10);
		multi2 = new JTextField(10);
		payRecordPane = new JPanel(new BorderLayout());
		payMaster = new JPanel(new BorderLayout());
		multiLabel1 = new JLabel("Monthly Income");
		multiLabel2 = new JLabel("Number of Months");

		//output pane
		textArea = new JTextArea(20, 50);
		textArea.setEditable(false);
		textArea.setLineWrap(true);
		textArea.setWrapStyleWord(true);
		scroll = new JScrollPane(textArea);

		addEmployeeButton = new JButton("Add Employee");
		addRecordButton = new JButton("Add Record");
		CloseButton = new JButton("Close");

	}// end of creating objects method

	private void doTheLayout() {

		// output pane
		textPane.add(scroll);
		controlPane.add(CloseButton);
		controlPane.add(addRecordButton);
		controlPane.add(addEmployeeButton);
		outputPane.add(controlPane, "Center");
		outputPane.add(textPane, "South");

		// address pane
		addressPane1.add(new JLabel("Street"));
		addressPane1.add(street);
		addressPane1.add(new JLabel("House #"));
		addressPane1.add(houseNum);

		addressPane2.add(new JLabel("City     "));
		addressPane2.add(city);
		addressPane2.add(new JLabel("State"));
		addressPane2.add(state);
		addressPane2.add(new JLabel(" Zip Code "));
		addressPane2.add(zip);
		addressPaneMaster.add(addressPane1);
		addressPaneMaster.add(addressPane2);

		// PAY PERIOD PANE
		payPeriodPane.add(new JLabel("ID"));
		payPeriodPane.add(rID);
		// Dates
		payPeriodPane.add(new JLabel("Start Date  "));
		datePane1.add(monthList1);
		datePane1.add(dayList1);
		datePane1.add(yearList1);
		payPeriodPane.add(datePane1);
		payPeriodPane.add(new JLabel("   End Date  "));
		datePane2.add(monthList2);
		datePane2.add(dayList2);
		datePane2.add(yearList2);
		payPeriodPane.add(datePane2);
		payPeriodMaster.add(new JLabel("  Pay Period"), "North");
		payPeriodMaster.add(payPeriodPane, "Center");

		// Employee
		employeeHeader.add(new JLabel("Employee"));
		employeeSub.add(new JLabel("ID"));
		employeeSub.add(eID);
		employeeSub.add(new JLabel("First Name"));
		employeeSub.add(firstName);
		employeeSub.add(new JLabel("Last Name"));
		employeeSub.add(lastName);
		employeeSub.add(new JLabel("Status"));
		employeeSub.add(empList);
		employeePane.add(employeeHeader, "North");
		employeePane.add(employeeSub, "Center");
		employeePane.add(addressPaneMaster, "South");

		// Pay Record
		payHeader.add(new JLabel("Pay Record"));
		payRecordSub.add(new JLabel("ID"));
		payRecordSub.add(pID);
		payRecordSub.add(multiLabel1);
		payRecordSub.add(multi1);
		payRecordSub.add(multiLabel2);
		payRecordSub.add(multi2);
		payRecordPane.add(payHeader, "North");
		payRecordPane.add(payRecordSub, "Center");
		payMaster.add(payRecordPane, "North");
		payMaster.add(payPeriodMaster, "Center");

		// LAYOUT
		setLayout(new BorderLayout());
		add(employeePane, "North");
		add(payMaster, "Center");
		add(outputPane, "South");

	}// end of Layout method

	void transfer() {
		if (eID.getText().trim().isEmpty() || firstName.getText().trim().isEmpty()
				|| lastName.getText().trim().isEmpty() || street.getText().trim().isEmpty()
				|| houseNum.getText().trim().isEmpty() || city.getText().trim().isEmpty()
				|| state.getText().trim().isEmpty() || zip.getText().trim().isEmpty() || pID.getText().trim().isEmpty()
				|| multi1.getText().trim().isEmpty() || multi2.getText().trim().isEmpty()
				|| rID.getText().trim().isEmpty()) {
			JOptionPane.showMessageDialog(null, "Please fill all fields");
		}
		payRoll.displayPayRecord();
	}// end of transfer action event method

	void close() {
		System.exit(0);
	}// end of transfer action event method

	public static void main(String[] args) {
		JFrame f = new JFrame("Pay Roll");
		f.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		Container contentPane = f.getContentPane();
		contentPane.add(new UserGUI());
		f.pack();
		f.setVisible(true);

	}

	public static void updateTextArea(String output) {
		if (textArea.getText().trim().isEmpty()) {
			textArea.setText(output);
		} else {
			textArea.setText(textArea.getText() + output);
		}	
	}

}
