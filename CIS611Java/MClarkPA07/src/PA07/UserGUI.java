package PA07;

//Mary Clark CIS611 PA07
// 4/3/2019

import java.awt.Color;
import static java.awt.Color.red;
import static java.awt.Color.white;
import java.awt.Dimension;
import java.awt.GridLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.io.FileNotFoundException;
import javax.swing.BoxLayout;
import static javax.swing.BoxLayout.Y_AXIS;
import javax.swing.ButtonGroup;
import javax.swing.DefaultListModel;
import javax.swing.JButton;
import javax.swing.JComboBox;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JList;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.JRadioButton;
import javax.swing.JScrollPane;
import javax.swing.JTextArea;
import javax.swing.JTextField;
import javax.swing.border.Border;
import javax.swing.border.CompoundBorder;
import javax.swing.border.EmptyBorder;
import javax.swing.border.LineBorder;
import javax.swing.event.*;

public class UserGUI extends JFrame implements ActionListener, ListDataListener{

	static Person[] personArray;
    private int personCount = 0;
    private int personSize = 0;
    private int numberOfPersons = 0;

    private JScrollPane scrollPane;
    private JTextArea textArea;
    private JList<Person> list;
    private DefaultListModel<Person> model;

    private JTextField txtFName;
    private JLabel lblFname;
    private JTextField txtLName;
    private JLabel lblLname;
    private JTextField txtHnum;
    private JLabel lblHnum;
    private JTextField txtStreet;
    private JLabel lblStreet;
    private JTextField txtCity;
    private JLabel lblCity;
    private JTextField txtState;
    private JLabel lblState;
    private JTextField txtZip;
    private JLabel lblZip;
    private JTextField txtPhone;
    private JLabel lblPhone;
    private JTextField txtEmail;
    private JLabel lblEmail;

    private JRadioButton btnFaculty;
    private JRadioButton btnStudent;
    private ButtonGroup rBtnGroup;

    private JComboBox<String> cBoxFaculty;
    private JComboBox<String> cBoxStudent;

    private String selected = "Lecturer";
    private char selectedType = 'F';

    private JButton btnAdd;
    private JButton btnSort;
    private JButton btnList;

    private JPanel personPanel;
    private JPanel radioPanel;
    private JPanel ddListPanel;
    private JPanel btnPanel;
    private JPanel topPanel;

    private JPanel rightPanel;
    private JPanel phantomPanel1;
    private JPanel listPanel;
    private Border emptyBorder;
    private LineBorder lineBorder;
    private CompoundBorder compoundBorder;
    private Color color;


    // constructor
    UserGUI(int nPersons){
        // create person array of size nPersons
        personSize = nPersons;
        this.numberOfPersons = nPersons;
        if (personSize > 0)
            personArray = new Person[nPersons];

        //Initialize the components
        initComponents();

        //Organize the GUI components
        doTheLayout();
    }//End of constructor

    private void initComponents(){
        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setTitle("Mary Clark PA07");
        setResizable(false);
        setLayout(new GridLayout(2,0,5,5));
        color = Color.black;

        emptyBorder = new EmptyBorder(10,20,10,20); //top,left,bottom,right counterclockwise
        lineBorder = new LineBorder(color, 2);
        compoundBorder = new CompoundBorder(lineBorder,emptyBorder);

        txtFName = new JTextField(10);
        lblFname = new JLabel("First Name");
        lblFname.setLabelFor(txtFName);

        txtLName = new JTextField(10);
        lblLname = new JLabel("Last Name");
        lblLname.setLabelFor(txtLName);

        txtHnum = new JTextField(5);
        lblHnum = new JLabel("House Number");
        lblHnum.setLabelFor(txtHnum);

        txtStreet = new JTextField(10);
        lblStreet = new JLabel("Street Name");
        lblStreet.setLabelFor(txtStreet);

        txtCity = new JTextField(10);
        lblCity = new JLabel("City");
        lblCity.setLabelFor(txtCity);

        txtState = new JTextField(2);
        lblState = new JLabel("State");
        lblState.setLabelFor(txtState);

        txtZip = new JTextField(5);
        lblZip = new JLabel("Zip Code");
        lblZip.setLabelFor(txtZip);

        txtPhone = new JTextField(15);
        lblPhone = new JLabel("Phone");
        lblPhone.setLabelFor(txtPhone);

        txtEmail = new JTextField(15);
        lblEmail = new JLabel("Email");
        lblEmail.setLabelFor(txtEmail);

        btnFaculty = new JRadioButton("Faculty", true);
        btnFaculty.setActionCommand("faculty");
        btnFaculty.addActionListener(this);

        btnStudent = new JRadioButton("Student");
        btnStudent.setActionCommand("student");
        btnStudent.addActionListener(this);

        rBtnGroup = new ButtonGroup();
        rBtnGroup.add(btnFaculty);
        rBtnGroup.add(btnStudent);

        cBoxFaculty = new JComboBox<String> (Faculty.RANKLIST);
        cBoxFaculty.setEditable(false);
        cBoxFaculty.setSelectedItem(0);
        cBoxFaculty.addActionListener(this);

        cBoxStudent = new JComboBox<String> (Student.STATUSLIST);
        cBoxStudent.setEditable(false);
        cBoxStudent.setSelectedItem(0);
        cBoxStudent.addActionListener(this);

        model = new DefaultListModel<Person>();
        list = new JList<Person>(model);
        model.addListDataListener(this);
        scrollPane = new JScrollPane(list); //Create JScrollPane to contain the view
        scrollPane.setPreferredSize(new Dimension(300,300));
        textArea = new JTextArea(10,50);

        btnAdd = new JButton("Add");
        btnAdd.setActionCommand("add");
        btnAdd.addActionListener(this);

        btnSort = new JButton("Sort");
        btnSort.setActionCommand("sort");
        btnSort.addActionListener(this);

        btnList = new JButton("List");
        btnList.setActionCommand("list");
        btnList.addActionListener(this);

        topPanel = new JPanel();

        personPanel = new JPanel();
        personPanel.setLayout(new GridLayout(0, 2, 1, 10));
        personPanel.setPreferredSize(new Dimension(300,350));

        personPanel.setBorder(compoundBorder);

        rightPanel = new JPanel();
        rightPanel.setLayout(new BoxLayout(rightPanel, Y_AXIS));
        rightPanel.setPreferredSize(new Dimension(300, 350));

        radioPanel = new JPanel();
        radioPanel.setPreferredSize(new Dimension(150, 50));

        ddListPanel = new JPanel();
        ddListPanel.setPreferredSize(new Dimension(150, 100));

        phantomPanel1 = new JPanel();
        phantomPanel1.setPreferredSize(new Dimension(150,200));

        btnPanel = new JPanel();
        btnPanel.setPreferredSize(new Dimension(150, 50));

        listPanel = new JPanel();
        listPanel.setBorder(compoundBorder);
        listPanel.setPreferredSize(new Dimension(400, 400));
    }

   private void doTheLayout(){
        // Organize the components into GUI windo

        personPanel.add(lblFname);
        personPanel.add(txtFName);
        personPanel.add(lblLname);
        personPanel.add(txtLName);
        personPanel.add(lblHnum);
        personPanel.add(txtHnum);
        personPanel.add(lblStreet);
        personPanel.add(txtStreet);
        personPanel.add(lblCity);
        personPanel.add(txtCity);
        personPanel.add(lblState);
        personPanel.add(txtState);
        personPanel.add(lblZip);
        personPanel.add(txtZip);
        personPanel.add(lblPhone);
        personPanel.add(txtPhone);
        personPanel.add(lblEmail);
        personPanel.add(txtEmail);

        radioPanel.add(btnFaculty);
        radioPanel.add(btnStudent);

        ddListPanel.add(cBoxFaculty);

        btnPanel.add(btnAdd);
        btnPanel.add(btnSort);
        btnPanel.add(btnList);

        rightPanel.add(radioPanel);
        rightPanel.add(ddListPanel);
        rightPanel.add(phantomPanel1);
        rightPanel.add(btnPanel);

        topPanel.add(personPanel);
        topPanel.add(rightPanel);

        add(topPanel);

        listPanel.add(scrollPane);

        add(listPanel);
    }


    @Override
    public void actionPerformed(ActionEvent e) {
        // Call the required button action method according to the action event
        if ("faculty".equals(e.getActionCommand())) {
            ddListPanel.remove(cBoxStudent);
            ddListPanel.revalidate();
            ddListPanel.repaint();
            ddListPanel.add(cBoxFaculty);
            ddListPanel.revalidate();
            ddListPanel.repaint();

        }else if ("student".equals(e.getActionCommand())) {
            ddListPanel.remove(cBoxFaculty);
            ddListPanel.revalidate();
            ddListPanel.repaint();
            ddListPanel.add(cBoxStudent);
            ddListPanel.revalidate();
            ddListPanel.repaint();

        }else if("add".equals(e.getActionCommand())) {
            txtFName.setBackground(white);
            txtLName.setBackground(white);
            txtStreet.setBackground(white);
            txtCity.setBackground(white);
            txtState.setBackground(white);
            txtHnum.setBackground(white);
            txtZip.setBackground(white);
            txtPhone.setBackground(white);
            txtEmail.setBackground(white);
            addButtonClicked();

        }else if("list".equals(e.getActionCommand())) {
            listButtonClicked();

        }else if("sort".equals(e.getActionCommand())) {
            sortButtonClicked();

        }else if(cBoxStudent == e.getSource()) {
            selected = (String)cBoxStudent.getSelectedItem();
            selectedType = 'S';
        }else if(cBoxFaculty == e.getSource()) {
            selected = (String)cBoxFaculty.getSelectedItem();
            selectedType = 'F';
        }else
            return;
    }

    private void addButtonClicked() {

        //Method to implement add button action
        int hnum = 0;
        int zip = 0;
        boolean badData = false;

        if (txtFName.getText().isEmpty()) {
            txtFName.setBackground(red);
            badData = true;
        }
        if (txtLName.getText().isEmpty()) {
            txtLName.setBackground(red);
            badData = true;
        }
        if (txtStreet.getText().isEmpty()) {
            txtStreet.setBackground(red);
            badData = true;
        }
        if (txtCity.getText().isEmpty()) {
            txtCity.setBackground(red);
            badData = true;
        }
        if (txtState.getText().isEmpty()) {
            txtState.setBackground(red);
            badData = true;
        }
        if (txtPhone.getText().isEmpty()) {
            txtPhone.setBackground(red);
            badData = true;
        }
        if (txtEmail.getText().isEmpty()) {
            txtEmail.setBackground(red);
            badData = true;
        }
        try {
            hnum = Integer.parseInt(txtHnum.getText());
        } catch (NumberFormatException ev) {
            txtHnum.setBackground(red);
            badData = true;
        }
        try {
            zip = Integer.parseInt(txtZip.getText());
        } catch (NumberFormatException ex) {
            txtZip.setBackground(red);
            badData = true;
        }
        if (badData) {
            return;
        }

        txtFName.setBackground(white);
        txtLName.setBackground(white);
        txtStreet.setBackground(white);
        txtCity.setBackground(white);
        txtState.setBackground(white);
        txtHnum.setBackground(white);
        txtZip.setBackground(white);
        txtPhone.setBackground(white);
        txtEmail.setBackground(white);

            Address addr = new Address(txtStreet.getText(), hnum, txtCity.getText(), txtState.getText(), zip);
            if (selectedType == 'S') {
            Student newStudent = new Student(txtFName.getText(), txtLName.getText(), addr, txtPhone.getText(), txtEmail.getText(), selected);
            personArray[personCount] = newStudent;
            model.addElement(newStudent);
            personCount++;
            } else if (selectedType == 'F') {
                Faculty newFaculty = new Faculty(txtFName.getText(), txtLName.getText(), addr, txtPhone.getText(), txtEmail.getText(), selected);
                personArray[personCount] = newFaculty;
                model.addElement(newFaculty);
                personCount++;
            }

        if (personCount >= numberOfPersons) {
            btnAdd.setEnabled(false);
        }
    }

    private void sortButtonClicked() {
        //Method to implement sort button action
        selectionSort();
        //scrollPane = new JScrollPane(list); //Create JScrollPane to contain the view
        //scrollPane.setPreferredSize(new Dimension(300,300));
        listPanel.remove(textArea);
        listPanel.remove(scrollPane);
            listPanel.revalidate();
            listPanel.repaint();
            listPanel.add(scrollPane);
            listPanel.revalidate();
            listPanel.repaint();
    }

    private void listButtonClicked() {
        // Method to implement display button action
        // calls the selection sort to sort the personArray
        // displays the array in the text area after sorting

        listPanel.remove(textArea);
        textArea = new JTextArea(10,50);
        textArea.setLineWrap(true);
        textArea.setWrapStyleWord(true);
        textArea.setEditable(false);

        for (Person personArray1 : personArray) {
            textArea.append(personArray1.toString());
            textArea.append("\n");
        }

        listPanel.remove(scrollPane);
            listPanel.revalidate();
            listPanel.repaint();
            listPanel.add(textArea);
            listPanel.revalidate();
            listPanel.repaint();
    }


    private void selectionSort() {
    //Method to sort person objects based on last name
    String lowestName = "";
    Person lowestPerson ;
    int lowestIndex = 0;

        for (int i = 0; i < personArray.length-1; i++) {
            lowestPerson = personArray[i];
            lowestIndex = i;
            lowestName = lowestPerson.getLastName();

            for (int j = i+1; j < personArray.length; j++) {
                //if j is lower than i
                //int comp = lowestName.compareToIgnoreCase(personArray[j].getLastName());
                //System.out.println("comp = " + comp + " lowestName = " + lowestName + " j = " + j + " " + personArray[j].getLastName() + " i = " + i);
                if (lowestName.compareToIgnoreCase(personArray[j].getLastName()) > 0) {
                    lowestName = personArray[j].getLastName();
                    lowestPerson = personArray[j];
                    lowestIndex = j;

                }
            } // end for j
            // if lowestIndex isn't i,
                // copy i to lowest
                // copy lowest to i
            if (lowestIndex != i) {
                personArray[lowestIndex] = personArray[i];
                personArray[i] = lowestPerson;
            }
        } // end for i
        model.clear();
        for (int k=0;k<personArray.length;k++) {
            model.add(k, personArray[k]);
        }
        //System.out.println("ARRAY:" + Arrays.toString(personArray));
        //System.out.println("MODEL:" + model.toString());
    }

    @Override
    public void contentsChanged(ListDataEvent e) {

    }
    @Override
    public void intervalAdded(ListDataEvent e) {

    }
    @Override
    public void intervalRemoved(ListDataEvent e) {

    }


public static void main(String[] args) throws FileNotFoundException {

    int numberOfPersons = 0;


    String result = JOptionPane.showInputDialog(null, "Enter number of persons to add");
    try {
        numberOfPersons = Integer.parseInt(result);
    } catch (NumberFormatException e) {
        return;
    }
    UserGUI frame = new UserGUI(numberOfPersons);
    //Create a new GUI
    //UserGUI frame = new UserGUI(numberOfPersons);
    frame.pack();
    frame.setVisible(true);

    //Set GUI frame settings

}// end main


	}
