package PP03;

import java.awt.BorderLayout;
import java.awt.Color;
import java.awt.Container;
import java.awt.Dimension;
import java.awt.FlowLayout;
import java.awt.GridLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import javax.swing.ButtonGroup;
import javax.swing.JButton;
import javax.swing.JComboBox;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.JRadioButton;
import javax.swing.JScrollPane;
import javax.swing.JTextArea;
import javax.swing.JTextField;

public class UserGUI extends JPanel {

	private JLabel lblEmpID;
    private JLabel lblFname;
    private JLabel lblLname;
    private JLabel lblEmpStatus;
    private JLabel lblStreet;
    private JLabel lblHnumber;
    private JLabel lblCity;
    private JLabel lblState;
    private JLabel lblZip;
    private JTextField txtEmpID;
    private JTextField txtFname;
    private JTextField txtLname;
    private JTextField txtStreet;
    private JTextField txtHnumber;
    private JTextField txtCity;
    private JTextField txtState;
    private JTextField txtZip;
    private JButton btnAddEmp;
    private JRadioButton rBtnFullTime;
    private JRadioButton rBtnHourly;
    private ButtonGroup rBtnGroup;
    private JComboBox<String> cBoxState;
    private JPanel pnlEmp;

    private JLabel lblPpID;
    private JLabel lblPpStart;
    private JLabel lblPpEnd;
    private JTextField txtPpID;
    private JTextField txtPpStart;
    private JTextField txtPpEnd;
    private JPanel pnlPp;

    private JLabel lblPrID;
    private JLabel lblPrMonthlyInc;
    private JLabel lblPrNumMonths;
    private JLabel lblPrPayHours;
    private JLabel lblPrPayRate;
    private JTextArea txtPrID;
    private JTextArea txtPrMonthlyInc;
    private JTextArea txtPrNumMonths;
    private JTextArea txtPrPayHours;
    private JTextArea txtPrPayRate;
    private JButton btnPrAddPayRecord;
    private JPanel pnlPr;

    private JTextArea jtaEmpList;
    private JButton btnClose;
    private JPanel pnlList;

    private PayRoll[] payRollList;
    private int empID, hNum, zip;
    private static int n;
    private String fName, lName, street, city, state;
    private Status status;

    public UserGUI() {
        String fileName = "PayRoll.txt";
        PayRoll payRoll = new PayRoll(fileName, n);

        initGUI();
        doTheLayout();

	    btnAddEmp.addActionListener(new ActionListener() {
            @Override
	        public void actionPerformed(ActionEvent e){
                if (validateEmployee()) {
                   payRoll.createEmployee(fName, lName, street, hNum, city, state, zip, empID, status);
                   btnAddEmp.setEnabled(false);
                   btnPrAddPayRecord.setEnabled(true);
                }
                else
                   return;
	            }
	    });

        btnPrAddPayRecord.addActionListener( new ActionListener() {
        @Override
        public void actionPerformed(ActionEvent e){
            if (validatePayPeriod()) { //need to do
                if (validatePayRecord()) {
                   //if status = fulltime
                   //new PayRecord(id, employee, period, mIncome, mNum);
                   //if status = hourly
                   //new PayRecord(id, employee, period, hours, rate);
                   //show jtaEmpList
                    btnAddEmp.setEnabled(true);
                    btnPrAddPayRecord.setEnabled(false);
                } else return;
            } else return;
        }
        });

	    btnClose.addActionListener( new ActionListener() {
            @Override
	        public void actionPerformed(ActionEvent e){
	            close();
	            }
	    });

	    cBoxState.addActionListener( new ActionListener() {
	        public void actionPerformed(ActionEvent e){
	            updateTextarea();

	            }
	    });

	} // end of constructor

	  private void initGUI(){

		  label1 = new JLabel("Type some text here:");
	      label2 = new JLabel("Your text will appear here:");
	      field1 = new JTextField("This is the default text", 30);
	      field2 = new JTextField(30);
	      textArea = new JTextArea(5, 15);
	      textArea.setEditable(false);
	      textArea.setLineWrap(true);
	      textArea.setWrapStyleWord(true);

	      // testing
	      textArea.append("This is an editable JTextArea. " +
	    		    "A text area is a \"plain\" text component, " +
	    		    "which means that although it can display text " +
	    		    "in any font, all of the text is in the same font.");

	      jp = new JScrollPane(textArea);

	      String[] listStrings = { "","Laptops", "Tablets", "Cell Phones" };
	      combList = new JComboBox<String>(listStrings);

	      TransferButton = new JButton("Transfer");
	      CloseButton = new JButton("Close");

	      field2.setEditable(false);

	  }// end of creating objects method

	  private void doTheLayout(){

	      JPanel top = new JPanel();
	      JPanel center = new JPanel();
	      JPanel bottom = new JPanel();

	      top.setLayout( new FlowLayout());
	      top.add(label1);
	      top.add(field1);
	      top.add(combList);

	      center.setPreferredSize( new Dimension( 10, 155 ) );
	      center.setLayout( new GridLayout(2,2));
	      center.add(label2);
	      center.add(field2);
	      center.add(new JLabel(""));
	      center.add(jp);

	      bottom.setLayout( new FlowLayout());
	      bottom.add(TransferButton);
	      bottom.add(CloseButton);

	      setLayout( new BorderLayout());
	      add(top, "North");
	      add(center, "Center");
	      add(bottom, "South");

	  }// end of Layout method

    private boolean validateEmployee() {
        boolean valid = true;
        try {
            empID = Integer.parseInt(txtEmpID.getText());
              if (empID <= 0) {
                txtEmpID.setBackground(Color.red);
                valid = false;
            }
        } catch (NumberFormatException en) {
            txtEmpID.setBackground(Color.red);
            valid = false;
        }
        try {
            fName = txtFname.getText();
            fName = fName.trim();
            if (fName.isEmpty()) {
                txtFname.setBackground(Color.red);
                valid = false;
            }
        } catch (NullPointerException np) {
            txtFname.setBackground(Color.red);
            valid = false;
        }
        try {
            lName = txtLname.getText();
            lName = lName.trim();
            if (lName.isEmpty()) {
              txtLname.setBackground(Color.red);
              valid = false;
            }
        } catch (NullPointerException np) {
            txtLname.setBackground(Color.red);
            valid = false;
        }
        try {
            street = txtStreet.getText();
            street = street.trim();
            if (street.isEmpty()) {
                txtStreet.setBackground(Color.red);
                valid = false;
            }
        } catch (NullPointerException np) {
            txtStreet.setBackground(Color.red);
            valid = false;
        }
        try {
            hNum = Integer.parseInt(txtHnumber.getText());
            if (hNum <= 0) {
                txtHnumber.setBackground(Color.red);
                valid = false;
            }
        } catch (NumberFormatException nf) {
            txtHnumber.setBackground(Color.red);
            valid = false;
        }
        try {
            city = txtCity.getText();
            city = city.trim();
            if (city.isEmpty()) {
                txtCity.setBackground(Color.red);
                valid = false;
            }
        } catch (NullPointerException np) {
                txtCity.setBackground(Color.red);
                valid = false;
        }
        try {
            state = txtState.getText();
            state = state.trim();
            if (state.isEmpty()) {
                txtState.setBackground(Color.red);
                valid = false;
            }
        } catch (NullPointerException np) {
            txtState.setBackground(Color.red);
            valid = false;
        }
        try {
            zip = Integer.parseInt(txtZip.getText());
            if (zip < 10000 || zip > 99999) {
                txtZip.setBackground(Color.red);
                valid = false;
            }
        } catch (NumberFormatException nf) {
            txtZip.setBackground(Color.red);
            valid = false;
        }
        return valid;
    }






	  void close(){
          //save the file
	      System.exit(0);
	  }


	public static void main(String[] args) {

        boolean goodResult = true;
        int msgType;
        String msg, title;

        if (goodResult) {
            msg = "Enter number of employees to add";
            msgType = JOptionPane.QUESTION_MESSAGE;
            title = " ";
        }
        else {
            msg = "Enter a valid integer > 0";
            msgType = JOptionPane.ERROR_MESSAGE;
            title = "Invalid Data";
        }
        // prompt the user to input the number of pay records
        String result = JOptionPane.showInputDialog(null, msg, title, msgType);
        try {
            n = Integer.parseInt(result);
            if ( n <= 0)  {
                goodResult = false;
                return;
            }
        } catch (NumberFormatException nf) {
            goodResult = false;
            return;
        }


	   JFrame f = new JFrame("PayRoll");
        f.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        Container contentPane = f.getContentPane();
        f.add(new UserGUI());
       // contentPane.add( new UserGUI());
        f.pack();
        //setSize(200, 200);
        f.setVisible(true);


	}

}
