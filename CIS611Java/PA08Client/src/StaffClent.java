/*
 * CIS 611 Programming Assignment PA08
 *
 * Class: StaffClient
 *
 * Purpose: User interface to the Staff database
 *
 * Date Created: 04/18/2019
 *
 * Author: Mary Clark
 */
import java.awt.*;
import java.awt.event.*;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.net.Socket;
import javax.swing.*;
import javax.swing.border.*;
import static javax.swing.border.LineBorder.createBlackLineBorder;

class StaffClient extends JFrame implements ActionListener {

    Socket conn;
	ObjectOutputStream clientOutputStream;
	ObjectInputStream clientInputStream;
	Message message;
	private String hostname;
	private int port;
    private final int 	CREATE = 1;
	private final int  	READ = 2;
	private final int 	UPDATE = 3;
	private final int  	DELETE= 4;
    private final int   NOTFOUND = 5;
    private final int   GETCOUNT = 6;
    private final int   LIST = 7;
	private static final String[] STATES = {"AR", "CO", "OK", "TX", "WY"};
    private static Dimension windowSize = new Dimension(700,600);
    private static Dimension buttonPanelSize = new Dimension(600,100);

// declare UI component objects
    private JPanel pnlStaffInfo;
    private TitledBorder bdrStaffInfo;
    private JPanel pnlId;
    private JLabel lblId;
    private JTextField txtId;
    private JPanel pnlName;
    private JLabel lblLastN;
    private JTextField txtLastN;
    private JLabel lblFirstN;
    private JTextField txtFirstN;
    private JLabel lblMi;
    private JTextField txtMi;
    private JPanel pnlAddr;
    private JLabel lblAddr;
    private JTextField txtAddr;
    private JPanel pnlCitySt;
    private JLabel lblCity;
    private JTextField txtCity;
    private JLabel lblSt;
    private JComboBox<String>cBoxSt;
    private JPanel pnlMobile;
    private JLabel lblMNum;
    private JTextField txtMNum;
    private JLabel lblMCarrier;
    private JTextField txtMCarrier;
    private JPanel pnlHPhone;
    private JLabel lblHNum;
    private JTextField txtHNum;
    private JLabel lblHCarrier;
    private JTextField txtHCarrier;
    private JPanel buttonPanel;
    private JButton btnView;
    private JButton btnList;
    private JButton btnInsert;
    private JButton btnUpdate;
    private JButton btnDelete;
    private JButton btnClear;
    private JButton btnClose;
    private JPanel statusPanel;
    private JLabel dbStatus;

//constructor
StaffClient(String hostname, int port) throws IOException {

	this.port = port;
	this.hostname = hostname;
    this.message = new Message();
    // Create a connection with the StaffServer on port 8000
    conn = new Socket(hostname, port);
	clientOutputStream = new ObjectOutputStream(conn.getOutputStream());
	clientInputStream = new ObjectInputStream(conn.getInputStream());
	// call these two methods to create user GUI
	initComponent();
	doTheLayout();
}

@Override
public void actionPerformed(ActionEvent e) {
    validationReset();
      Object source = e.getSource();
      try {
      if (source == btnClear) {
          clickedClearButton();
      } else if (source == btnClose) {
          clickedCloseButton();
      } else if (source == btnDelete){
          clickedDeleteButton();
      }else if (source == btnInsert) {
          clickedInsertButton();
      } else if (source == btnUpdate) {
          clickedUpdateButton();
      } else if (source == btnView) {
          clickedViewButton();
      } else if (source == btnList) {
          clickedListButton();
      } else if (source == cBoxSt) {
          if (cBoxSt.getSelectedIndex() > -1) {
              cBoxSt.setSelectedItem(STATES[cBoxSt.getSelectedIndex()]);
              message.setSt(STATES[cBoxSt.getSelectedIndex()]);
          }
      }
      } catch (IOException | ClassNotFoundException ex) {
          System.out.println("Exception occurred " + ex + " \n");
      }
}

//If the id entered by the user is valid and is found in the database,
//  do nothing. validID and found set the display results.
//If the id is invalid, display error message.
//If the id is not found, display error message and set id to red
private void clickedViewButton() throws IOException, ClassNotFoundException {
    if (!validID()) {
        dbStatus.setForeground(Color.red);
        dbStatus.setText("Error: ID " + txtId.getText() + " is invalid.");
        return;
    } else if (!found("View")) {
            dbStatus.setText("ID " + message.getId() + " not found.");
            dbStatus.setForeground(Color.red);
            txtId.setForeground(Color.red);
            }
  }

private void clickedInsertButton() throws IOException, ClassNotFoundException {
    boolean validPhone = true;
    boolean validText = true;
    if (!validID()) {
        dbStatus.setText("Error: ID " + txtId.getText() + " is invalid.");
        dbStatus.setForeground(Color.red);
        return;
    } else {
        txtId.setForeground(Color.BLACK);
    }

    if (found("Insert")) {
        dbStatus.setText("Error: ID " + message.getId() + " already exists.");
        dbStatus.setForeground(Color.red);
        txtId.setForeground(Color.red);
        return;
    } else {
        validPhone = validatePhoneNumber();
        validText = validateTextFields();
        }
    if (validPhone == true && validText == true) {
        message.setOp(CREATE);
        messageSend(message);
        System.out.println("Insert received msg = " + message.toString());
        btnView.setEnabled(true);
        btnList.setEnabled(true);
        btnUpdate.setEnabled(true);
        btnDelete.setEnabled(true);
        dbStatus.setText("Successfully created Staff ID " + message.getId());
    }
    else {
        dbStatus.setText("Unable to add Staff ID " + message.getId() + " Please fix your errors.");
        dbStatus.setForeground(Color.red);
      }
  }

//validate all fields. Update existing record for id
private void clickedUpdateButton() throws IOException, ClassNotFoundException {
    boolean validPhone = true;
    boolean validText = true;
    if (!validID()) {
        dbStatus.setText("Error: ID " + txtId.getText() + " is invalid.");
        dbStatus.setForeground(Color.red);
        return;
    } else {
        txtId.setForeground(Color.BLACK);
    }
    if (!found("Update")) {
        dbStatus.setText("Error: ID " + message.getId() + " not found.");
        dbStatus.setForeground(Color.red);
        txtId.setForeground(Color.red);
        return;
    } else {
        txtId.setForeground(Color.BLACK);
        validPhone = validatePhoneNumber();
        validText = validateTextFields();
        }
    if (validPhone == true && validText == true) {
        message.setOp(UPDATE);
        messageSend(message);
        System.out.println("Update received msg = " + message.toString());
        dbStatus.setText("Staff ID " + message.getId() + " successfully updated.");
    }
    else {
        dbStatus.setText("Unable to update Staff ID " + message.getId() + " Please fix your errors.");
        dbStatus.setForeground(Color.red);
      }
}

private void clickedDeleteButton() throws IOException, ClassNotFoundException {
    if (!validID()) {
        dbStatus.setText("Error: ID " + txtId.getText() + " is invalid.");
        dbStatus.setForeground(Color.red);
        return;
    } else {
        txtId.setForeground(Color.BLACK);
    }

    if (!found("Delete")) {
        dbStatus.setText("Error: ID " + message.getId() + " not found.");
        dbStatus.setForeground(Color.red);
        txtId.setForeground(Color.red);
        return;
    } else {
        txtId.setForeground(Color.BLACK);
    }
     int confirm = JOptionPane.showConfirmDialog(this, "WARNING: You are about to delete the selected staff member. Click Yes to Delete, No to Cancel.","Delete Warning", JOptionPane.YES_NO_OPTION, JOptionPane.WARNING_MESSAGE);
     if (confirm == JOptionPane.YES_OPTION) {
        message.setOp(DELETE);
        messageSend(message);
        clickedClearButton();
        dbStatus.setText("Deleted Staff ID " + message.getId());
     }
}

private void clickedListButton() throws IOException, ClassNotFoundException {
    String[] columnNames = {"Staff ID",
                        "Last Name",
                        "First Name",
                        "MI",
                        "Address",
                        "City",
                        "ST",
                        "Mobile \nPhone",
                        "Mobile \nCarrier",
                        "Home \nPhone",
                        "Home \nCarrier"};
    messageSend(GETCOUNT,0);
    int count = message.getCount();
    String[][] rowData = new String[message.getCount()][columnNames.length];
    messageSend(LIST,0);

    for (int i=0; i<count;i++) {
        //message = (Message)clientInputStream.readObject();
        rowData[i][0] = Integer.toString(message.getId());
        rowData[i][1] = message.getLastN();
        rowData[i][2] = message.getFirstN();
        rowData[i][3] = message.getMi();
        rowData[i][4] = message.getAddr();
        rowData[i][5] = message.getCity();
        rowData[i][6] = message.getSt();
        rowData[i][7] = Long.toString(message.getMNum());
        rowData[i][8] = message.getMCarrier();
        rowData[i][9] = Long.toString(message.getHNum());
        rowData[i][10] = message.getHCarrier();
        message = (Message)clientInputStream.readObject();
        System.out.println("Received message: " + message.toString());
    }

    JFrame listFrame = new JFrame();
    listFrame.setDefaultCloseOperation(javax.swing.WindowConstants.DISPOSE_ON_CLOSE);
    listFrame.setTitle("Mary Clark PA08");
    JTable listTable = new JTable(rowData, columnNames);
	JScrollPane listPane = new JScrollPane(listTable,JScrollPane.VERTICAL_SCROLLBAR_AS_NEEDED,
            JScrollPane.HORIZONTAL_SCROLLBAR_AS_NEEDED);
    listPane.setPreferredSize(new Dimension(900,200));
    listTable.setFillsViewportHeight(true);
        new SmartScroller(listPane);
		Container contentPane = listFrame.getContentPane();
		contentPane.add(listPane);
		listFrame.pack();
		listFrame.setVisible(true);
}

//reset all fields
  private void clickedClearButton(){

	txtId.setText("");
    txtId.setForeground(Color.BLACK);
    txtLastN.setText("");
    txtLastN.setForeground(Color.BLACK);
    txtFirstN.setText("");
    txtFirstN.setForeground(Color.BLACK);
    txtMi.setText("");
    txtMi.setForeground(Color.BLACK);
    txtAddr.setText("");
    txtAddr.setForeground(Color.BLACK);
    txtCity.setText("");
    txtCity.setForeground(Color.BLACK);
    cBoxSt.setSelectedItem(null);
    cBoxSt.setBackground(Color.WHITE);
    txtMNum.setText("");
    txtMNum.setForeground(Color.BLACK);
    txtHNum.setText("");
    txtHNum.setForeground(Color.BLACK);
    txtMCarrier.setText("");
    txtMCarrier.setForeground(Color.BLACK);
    txtHCarrier.setText("");
    txtHCarrier.setForeground(Color.BLACK);
    dbStatus.setText("Client " + conn.getLocalAddress() + ":" + conn.getLocalPort() + " is connected to " + conn.getRemoteSocketAddress());
    dbStatus.setForeground(Color.BLACK);
  }

  private void validationReset() {
    txtId.setForeground(Color.BLACK);
    txtLastN.setForeground(Color.BLACK);
    txtFirstN.setForeground(Color.BLACK);
    txtMi.setForeground(Color.BLACK);
    txtAddr.setForeground(Color.BLACK);
    txtCity.setForeground(Color.BLACK);
    cBoxSt.setBackground(Color.white);
    txtMNum.setForeground(Color.BLACK);
    txtHNum.setForeground(Color.BLACK);
    txtMCarrier.setForeground(Color.BLACK);
    txtHCarrier.setForeground(Color.BLACK);
    dbStatus.setText("Client " + conn.getLocalAddress() + ":" + conn.getLocalPort() + " is connected to " + conn.getRemoteSocketAddress());
    dbStatus.setForeground(Color.black);
  }

  private void clickedCloseButton() throws IOException {
    clientInputStream.close();
    clientOutputStream.close();
    conn.close();
	System.exit(0);
  }

  //Get record count from database
  //If > 0, enable view, update, and delete buttons
  private void checkDatabase() throws IOException, ClassNotFoundException {
      StaffClient.this.messageSend(GETCOUNT,0);
      if (message.getCount() > 0) {
          btnView.setEnabled(true);
          btnList.setEnabled(true);
          btnUpdate.setEnabled(true);
          btnDelete.setEnabled(true);
      }
      else {
          btnView.setEnabled(false);
          btnList.setEnabled(false);
          btnUpdate.setEnabled(false);
          btnDelete.setEnabled(false);
      }
  }

  //Send a READ request to the server for the current id
  //If id is not found, return false to all callers
  //If id is found, return true if caller is update
  //If id is found for all other callers,
  //    populate display with result values and return true
  //found() does not set colors
  private boolean found(String caller) throws IOException, ClassNotFoundException {
    StaffClient.this.messageSend(READ, message.getId());
        if(message.getOp() == NOTFOUND) {
          return false;
        } else  { if (caller == "Update") {
                    return true;
                    }
                else {
                    txtId.setText(Long.toString(message.getId()));
                    txtFirstN.setText(message.getFirstN());
                    txtLastN.setText(message.getLastN());
                    txtMi.setText(message.getMi());
                    txtAddr.setText(message.getAddr());
                    txtCity.setText(message.getCity());
                    cBoxSt.setSelectedItem(message.getSt());
                    txtHNum.setText(Long.toString(message.getHNum()));
                    txtHCarrier.setText(message.getHCarrier());
                    txtMNum.setText(Long.toString(message.getMNum()));
                    txtMCarrier.setText(message.getMCarrier());
                    return true;
                }
        }
}

  //Test the id entered by the user
  //If id is empty, too long, or not numeric,
  //    set id color to red
  //    return false
  //if id is valid,
  //    set id color to black
  //    set id in message object
  //    return true
  private boolean validID() throws IOException, ClassNotFoundException {
      //is it empty or too long?
      if (txtId.getText().isEmpty() || txtId.getText().length() > 11) {
          txtId.setForeground(Color.red);
          dbStatus.setText("ID " + txtId.getText() + " is invalid.");
          dbStatus.setForeground(Color.red);
          return false;
      }
      //is it numeric?
      else {
          try {
            message.setId(Integer.parseInt(txtId.getText()));
          } catch (NumberFormatException ex) {
                txtId.setForeground(Color.red);
                dbStatus.setText("ID " + message.getId() + " is invalid.");
                dbStatus.setForeground(Color.red);
                return false;
            }

      System.out.println("ValidID = " + message.getId());
      txtId.setForeground(Color.BLACK);
      }
      return true;
  }

  //validate phone numbers and set message fields
  private boolean validatePhoneNumber() {
      boolean valid = true;
    //is it empty?
    if (txtMNum.getText().isEmpty()) {
      txtMNum.setForeground(Color.red);
      txtMNum.setText("Required");
      valid = false;
    }
    //is it a number?
    else {
        try {
          message.setMNum(Long.parseLong(txtMNum.getText()));
        } catch (NumberFormatException ex) {
              txtMNum.setForeground(Color.red);
              valid = false;
          }
      }
    //repeat for home phone
    if (txtHNum.getText().isEmpty()) { //optional
        return valid;
    }
    else {
        try {
          message.setHNum(Long.parseLong(txtHNum.getText()));
        } catch (NumberFormatException ex) {
              txtHNum.setForeground(Color.red);
              valid = false;
          }
    }
    return valid;
  }

  //validate text fields & set valid message fields
  //set invalid fields to red
  private boolean validateTextFields() {
      boolean valid = true;
  if (txtLastN.getText().isEmpty() || txtLastN.getText().length() > 15) {
        txtLastN.setForeground(Color.red);
        valid = false;
    } else {
        message.setLastN(txtLastN.getText());
    }
    if (txtFirstN.getText().isEmpty() || txtFirstN.getText().length() > 15) {
        txtFirstN.setForeground(Color.red);
        valid = false;
    } else {
        message.setFirstN(txtFirstN.getText());
    }
    if (txtMi.getText().length() > 1) {
        txtMi.setForeground(Color.red);
        valid = false;
    } else
        message.setMi(txtMi.getText()); //optional

    if (txtAddr.getText().isEmpty() || txtAddr.getText().length() > 20) {
        txtAddr.setForeground(Color.red);
        valid = false;
    } else {
        message.setAddr(txtAddr.getText());
    }
    if (txtCity.getText().isEmpty() || txtCity.getText().length() > 20) {
        txtCity.setForeground(Color.red);
        valid = false;
    } else {
        message.setCity(txtCity.getText());
    }
    if (cBoxSt.getSelectedIndex() == -1) {
        cBoxSt.setBackground(Color.red);
        valid = false;
    } else {
        message.setSt(STATES[cBoxSt.getSelectedIndex()]);
    }
    if (!txtHCarrier.getText().isEmpty() && txtHCarrier.getText().length() < 21) {
        message.setHCarrier(txtHCarrier.getText()); //optional
    }
    if (!txtMCarrier.getText().isEmpty() && txtMCarrier.getText().length() < 21) {
        message.setMCarrier(txtMCarrier.getText()); //optional
    }

    System.out.println("validateTextFields message: " + message.toString());
    return valid;
  }

  //send op and id as short message and call messageReceive()
  public void messageSend(int op, int id) throws IOException, ClassNotFoundException {
      message = new Message (op, id);
      System.out.println("Sending message: " + message.toString());
      clientOutputStream.writeObject(message);
      messageReceive();
  }


  public void messageSend(Message message) throws IOException, ClassNotFoundException {
        System.out.println("Sending message: " + message.toString());
        clientOutputStream.writeObject(message);
       	messageReceive();
  }

  //always called by messageSend()
  //Read the message from inputstream & set message object
  //If the connection is closed, create a new connection
  private void messageReceive() throws IOException, ClassNotFoundException {

		message = (Message)clientInputStream.readObject();
        System.out.println("Received message: " + message.toString());
        /*if (conn.isClosed()) {
            conn = new Socket(hostname, port);
            clientOutputStream = new ObjectOutputStream(conn.getOutputStream());
            clientInputStream = new ObjectInputStream(conn.getInputStream());
            clickedClearButton();
            dbStatus.setText("Connection Error. New connection created " + conn.getLocalAddress() + ":" + conn.getLocalPort() + " is connected to " + conn.getRemoteSocketAddress());

        } */
  }

  //main
  public static void main(String[] args) {

	  // create the user GUI
      try {
          StaffClient client = new StaffClient("localhost", 8000);
          client.setPreferredSize(windowSize);
          client.pack();
          client.setVisible(true);
          client.dbStatus.setText("Client " + client.conn.getLocalAddress() + ":" + client.conn.getLocalPort() + " is connected to " + client.conn.getRemoteSocketAddress());
       }catch (IOException ex) {
              System.out.println("Server Down: " + ex + "\n");
              JOptionPane.showMessageDialog(null, "StaffServer is not responding. Click OK to exit.");
            }
  }

  private void initComponent(){
	// Initialize the GUI components
    setDefaultCloseOperation(javax.swing.WindowConstants.DISPOSE_ON_CLOSE);
    setTitle("Mary Clark PA08");
    setResizable(false);
    setLayout(new GridLayout(1,0,1,1));

    pnlStaffInfo = new JPanel();
    pnlStaffInfo.setPreferredSize(windowSize);
    bdrStaffInfo = new TitledBorder(createBlackLineBorder(),
            "Staff Information",TitledBorder.LEFT,TitledBorder.ABOVE_TOP);
    pnlStaffInfo.setBorder(bdrStaffInfo);
    pnlId = new JPanel();
    lblId = new JLabel("ID");
    txtId = new JTextField(11);
    txtId.setToolTipText("Required. IDs are numeric integers < 12 characters long.");

    pnlName = new JPanel();
    lblLastN = new JLabel("Last Name");
    txtLastN = new JTextField(15);
    txtLastN.setToolTipText("Required. Last Name is 15 characters maximum.");
    lblFirstN = new JLabel("First Name");
    txtFirstN = new JTextField(15);
    txtFirstN.setToolTipText("Required. First Name is 15 characters maximum.");
    lblMi = new JLabel("mi");
    txtMi = new JTextField(1);
    txtMi.setToolTipText("Optional. Middle Initial is 1 character maximum.");
    txtMi.setBackground(Color.LIGHT_GRAY);

    pnlAddr = new JPanel();
    lblAddr = new JLabel("Address");
    txtAddr = new JTextField(20);
    txtAddr.setToolTipText("Required. Address is 20 characters maximum.");

    pnlCitySt = new JPanel();
    lblCity = new JLabel("City");
    txtCity = new JTextField(20);
    txtCity.setToolTipText("Required. City is 20 characters maximum");
    lblSt = new JLabel("State");
    cBoxSt = new JComboBox<String>(STATES);
    cBoxSt.setToolTipText("Required. Select State.");
    cBoxSt.setEditable(false);
    cBoxSt.setSelectedItem(null);
    cBoxSt.setBackground(Color.WHITE);
    cBoxSt.addActionListener(this);

    pnlMobile = new JPanel();
    lblMNum = new JLabel("Mobile Phone Number");
    txtMNum = new JTextField(11);
    txtMNum.setToolTipText("Required. Enter mobile phone number as 11 digits. No spaces. No dashes.");
    lblMCarrier = new JLabel("Mobile Phone Carrier");
    txtMCarrier = new JTextField(20);
    txtMCarrier.setToolTipText("Optional. Enter the mobile phone carrier.");
    txtMCarrier.setBackground(Color.LIGHT_GRAY);

    pnlHPhone = new JPanel();
    lblHNum = new JLabel("Home Phone Number");
    txtHNum = new JTextField(11);
    txtHNum.setToolTipText("Optional. Enter home phone number as 11 digits. No spaces. No dashes.");
    txtHNum.setBackground(Color.LIGHT_GRAY);
    lblHCarrier = new JLabel("Home Phone Carrier");
    txtHCarrier = new JTextField(20);
    txtHCarrier.setToolTipText("Optional. Enter the home phone carrier.");
    txtHCarrier.setBackground(Color.LIGHT_GRAY);

    buttonPanel = new JPanel();
    buttonPanel.setPreferredSize(buttonPanelSize);
    btnView = new JButton("View");
    btnView.setToolTipText("Enter the staff ID number you wish to view.");

    btnView.setActionCommand("view");
    btnView.addActionListener(this);
    btnView.setEnabled(false);

    btnList = new JButton("List");
    btnList.setActionCommand("list");
    btnList.addActionListener(this);
    btnList.setEnabled(false);
    btnList.setToolTipText("List all Staff members.");

    btnInsert = new JButton("Insert");
    btnInsert.setActionCommand("insert");
    btnInsert.addActionListener(this);
    btnInsert.setToolTipText("Enter a unique staff ID and all required fields to add a new staff member.");

    btnUpdate = new JButton("Update");
    btnUpdate.setActionCommand("update");
    btnUpdate.addActionListener(this);
    btnUpdate.setEnabled(false);
    btnUpdate.setToolTipText("Enter the staff ID and the fields you wish to update.");

    btnDelete = new JButton("Delete");
    btnDelete.setActionCommand("delete");
    btnDelete.addActionListener(this);
    btnDelete.setEnabled(false);
    btnDelete.setToolTipText("Enter the staff ID of the staff member to delete.");

    btnClear = new JButton("Clear");
    btnClear.setActionCommand("clear");
    btnClear.addActionListener(this);
    btnClear.setToolTipText("Clear the Staff Information form.");

    btnClose = new JButton("Close");
    btnClose.setActionCommand("close");
    btnClose.addActionListener(this);
    btnClose.setToolTipText("Close the application.");

    statusPanel = new JPanel();
    dbStatus = new JLabel();

}

private void doTheLayout(){
	// Arrange the UI components into GUI window
    pnlId.setLayout(new FlowLayout(FlowLayout.LEFT, 5,5));
    pnlId.add(lblId);
    pnlId.add(txtId);

    pnlName.setLayout(new FlowLayout(FlowLayout.LEFT,10,5));
    pnlName.add(lblLastN);
    pnlName.add(txtLastN);
    pnlName.add(lblFirstN);
    pnlName.add(txtFirstN);
    pnlName.add(lblMi);
    pnlName.add(txtMi);

    pnlAddr.setLayout(new FlowLayout(FlowLayout.LEFT,10,5));
    pnlAddr.add(lblAddr);
    pnlAddr.add(txtAddr);

    pnlCitySt.setLayout(new FlowLayout(FlowLayout.LEFT,10,5));
    pnlCitySt.add(lblCity);
    pnlCitySt.add(txtCity);
    pnlCitySt.add(lblSt);
    pnlCitySt.add(cBoxSt);

    pnlMobile.setLayout(new FlowLayout(FlowLayout.LEFT,10,5));
    pnlMobile.add(lblMNum);
    pnlMobile.add(txtMNum);
    pnlMobile.add(lblMCarrier);
    pnlMobile.add(txtMCarrier);

    pnlHPhone.setLayout(new FlowLayout(FlowLayout.LEFT,10,5));
    pnlHPhone.add(lblHNum);
    pnlHPhone.add(txtHNum);
    pnlHPhone.add(lblHCarrier);
    pnlHPhone.add(txtHCarrier);

    buttonPanel.setLayout(new FlowLayout(FlowLayout.CENTER,10,5));
    buttonPanel.add(btnView);
    buttonPanel.add(btnList);
    buttonPanel.add(btnInsert);
    buttonPanel.add(btnUpdate);
    buttonPanel.add(btnDelete);
    buttonPanel.add(btnClear);
    buttonPanel.add(btnClose);

    statusPanel.add(dbStatus);

    pnlStaffInfo.setLayout(new GridLayout(8,0,5,5));
    pnlStaffInfo.add(pnlId);
    pnlStaffInfo.add(pnlName);
    pnlStaffInfo.add(pnlAddr);
    pnlStaffInfo.add(pnlCitySt);
    pnlStaffInfo.add(pnlMobile);
    pnlStaffInfo.add(pnlHPhone);
    pnlStaffInfo.add(buttonPanel);
    pnlStaffInfo.add(statusPanel);

    add(pnlStaffInfo);

    try {
        checkDatabase();
    } catch (ClassNotFoundException | IOException ex) {
        System.out.println("Check Database error: " + ex + "\n");
    }
}


}