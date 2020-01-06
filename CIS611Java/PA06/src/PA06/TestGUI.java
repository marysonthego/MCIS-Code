package PA06;

import java.awt.Component;
import java.awt.Dimension;
import java.awt.GridLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import javax.swing.BorderFactory;
import javax.swing.Box;
import javax.swing.BoxLayout;
import javax.swing.ButtonGroup;
import javax.swing.JButton;
import javax.swing.JComboBox;
import javax.swing.JFormattedTextField;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.JRadioButton;
import javax.swing.JTextField;
import javax.swing.text.BadLocationException;
import javax.swing.text.MaskFormatter;

class TestGUI  implements ActionListener {

    private JFrame frame;
    private JPanel basePanel;
    private JPanel labelPanel;
    private JPanel fieldPanel;
    private JPanel radioPanel;
    private JPanel facultyPanel;
    private JPanel studentPanel;
    private JPanel buttonPanel;

    private static final String BTNSTRING1 = "Enter";
    private static final String BTNSTRING2 = "Cancel";

    private JButton btnOK;
    private JButton btnCancel;
    private JButton btnList;

    //Field Labels
    public JLabel fNameLabel = new JLabel("First Name:");
    private JLabel lNameLabel = new JLabel("Last Name:");
    private JLabel phoneLabel = new JLabel("Phone:");
    private JLabel emailLabel = new JLabel("Email Address:");
    private JLabel houseLabel = new JLabel("House Number:");
    private JLabel streetLabel = new JLabel("Street Name:");
    private JLabel cityLabel = new JLabel("City:");
    private JLabel stateLabel = new JLabel("State:");
    private JLabel zipLabel = new JLabel("Zip Code:");
    private JLabel rankLabel = new JLabel("Select Faculty Position:");
    private JLabel apptDateLabel = new JLabel("Appointment Date:");
    private JLabel statusLabel = new JLabel("Select Student Class:");

      //Fields for data entry
    private JTextField fNameField;
    private JTextField lNameField;
    private JFormattedTextField phoneField;
    private JFormattedTextField emailField;
    private JFormattedTextField houseField;
    private JTextField streetField;
    private JTextField cityField;
    private JTextField stateField;
    private JFormattedTextField zipField;
    private JComboBox<String> rankCBox;
    private JFormattedTextField apptDateField;
    private JComboBox<String> statusCBox;

    //Masks and Formats to format and parse fields
    private MaskFormatter phoneFormat;
    private MaskFormatter emailFormat;
    private MaskFormatter zipFormat;
    private SimpleDateFormat apptDateFormat;
    private MaskFormatter stateFormat;
    private MaskFormatter textFormat;
    private MaskFormatter houseFormat;

    private Dimension horizontal;
    private Dimension vertical;

    private JRadioButton rBtnFaculty;
    private JRadioButton rBtnStudent;

    private String selected;
    private String personType;
    private TestWithInput testWithInput;



TestGUI (TestWithInput testWithInput) {
        this.testWithInput = testWithInput;
        horizontal = new Dimension(100,50);
        vertical = new Dimension(20,200);

         frame = new JFrame("Mary Clark PA06");
         frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
         frame.setLayout(new BoxLayout(frame.getContentPane(), BoxLayout.LINE_AXIS));

         basePanel = new JPanel();
         basePanel.setLayout(new BoxLayout(basePanel, BoxLayout.LINE_AXIS));
         basePanel.setBorder(BorderFactory.createEtchedBorder());

         labelPanel = new JPanel(new GridLayout(0,1));
         fieldPanel = new JPanel(new GridLayout(0,1));

         radioPanel = new JPanel();
         radioPanel.setLayout(new BoxLayout(radioPanel, BoxLayout.LINE_AXIS));
         radioPanel.setBorder(BorderFactory.createTitledBorder("Faculty or Student?"));
         radioPanel.setAlignmentX(Component.CENTER_ALIGNMENT);

         facultyPanel = new JPanel();
         facultyPanel.setLayout(new BoxLayout(facultyPanel, BoxLayout.PAGE_AXIS));

         studentPanel = new JPanel();
         studentPanel.setLayout(new BoxLayout(studentPanel,BoxLayout.PAGE_AXIS));

         buttonPanel = new JPanel();
         buttonPanel.setLayout(new BoxLayout(buttonPanel, BoxLayout.LINE_AXIS));


        buildComponents();
         //Display the window.
        frame.pack();
        frame.setVisible(true);
}

private void buildComponents() {

         fNameField = new JFormattedTextField();
         fNameField.setColumns(15);
         fNameField.setMaximumSize(new Dimension(100,50));
         lNameField = new JFormattedTextField();
         lNameField.setColumns(15);
         lNameField.setMaximumSize(new Dimension(100,50));
         phoneField = new JFormattedTextField();
         phoneField.setColumns(12);
         phoneField.setMaximumSize(new Dimension(100,50));
         emailField = new JFormattedTextField();
         emailField.setColumns(20);
         emailField.setMaximumSize(new Dimension(100,50));
         houseField = new JFormattedTextField();
         houseField.setColumns(5);
         houseField.setMaximumSize(new Dimension(100,50));
         streetField = new JFormattedTextField();
         streetField.setColumns(20);
         streetField.setMaximumSize(new Dimension(100,50));
         cityField = new JFormattedTextField();
         cityField.setColumns(15);
         cityField.setMaximumSize(new Dimension(100,50));
         stateField = new JFormattedTextField();
         stateField.setColumns(2);
         stateField.setMaximumSize(new Dimension(100,50));
         zipField = new JFormattedTextField();
         zipField.setColumns(5);
         zipField.setMaximumSize(new Dimension(100,50));

         rBtnFaculty = new JRadioButton("Faculty", true);
         rBtnFaculty.setActionCommand("faculty");
         rBtnFaculty.addActionListener(this);

         rBtnStudent = new JRadioButton("Student", false);
         rBtnStudent.setActionCommand("student");
         rBtnStudent.addActionListener(this);

         ButtonGroup rBtnGroup = new ButtonGroup();
         rBtnGroup.add(rBtnFaculty);
         rBtnGroup.add(rBtnStudent);


         apptDateLabel.setAlignmentX(Component.CENTER_ALIGNMENT);
         apptDateFormat = new SimpleDateFormat("MM/dd/yyyy");
         apptDateField = new JFormattedTextField(apptDateFormat);
         apptDateField.setColumns(10);
         apptDateField.setMaximumSize(new Dimension(150,50));

         rankLabel.setAlignmentX(Component.CENTER_ALIGNMENT);
         rankCBox = new JComboBox<>(new Faculty().getRankList());
         rankCBox.addActionListener(this);
         rankCBox.setActionCommand((String)rankCBox.getSelectedItem());

         statusLabel.setAlignmentX(Component.CENTER_ALIGNMENT);
         statusCBox = new JComboBox<>(new Student().getStatusList());
         statusCBox.addActionListener(this);
         statusCBox.setActionCommand((String)statusCBox.getSelectedItem());
         //statusCBox.setActionCommand("status");
         statusCBox.setEnabled(false);

         btnOK = new JButton(BTNSTRING1);
         btnOK.addActionListener(this);
         btnOK.setActionCommand("btnOK");

         btnList = new JButton("List");
         btnList.addActionListener(this);
         btnList.setActionCommand("btnList");

         btnCancel = new JButton(BTNSTRING2);
         btnCancel.addActionListener(this);
         btnCancel.setActionCommand("btnCancel");

        try {
                phoneFormat = new MaskFormatter("###-###-####");
                phoneFormat.install(phoneField);
                emailFormat = new MaskFormatter("LLLLLLL@LLLLL.LLL");
                emailFormat.setPlaceholderCharacter(' ');
                emailFormat.install(emailField);
                zipFormat = new MaskFormatter("#####");
                zipFormat.install(zipField);
                textFormat = new MaskFormatter("ULLLLLLLLLLLLLLLLLLLLLLLLL");
                textFormat.setPlaceholderCharacter(' ');
                houseFormat = new MaskFormatter("#####");
                houseFormat.install(houseField);
                stateFormat = new MaskFormatter("UU");
        } catch (ParseException ex) {
                System.out.println("Error creating MaskFormatter" + ex);
        } catch (NullPointerException | NumberFormatException ex) {
                System.out.println("Error in format" + ex);
        }

        //Add Label Panel Components
        labelPanel.add(fNameLabel);
        labelPanel.add(lNameLabel);
        labelPanel.add(phoneLabel);
        labelPanel.add(emailLabel);
        labelPanel.add(houseLabel);
        labelPanel.add(streetLabel);
        labelPanel.add(cityLabel);
        labelPanel.add(stateLabel);
        labelPanel.add(zipLabel);

        //Add Field Panel Components
        fieldPanel.add(fNameField);
        fieldPanel.add(lNameField);
        fieldPanel.add(phoneField);
        fieldPanel.add(emailField);
        fieldPanel.add(houseField);
        fieldPanel.add(streetField);
        fieldPanel.add(cityField);
        fieldPanel.add(stateField);
        fieldPanel.add(zipField);

        //Add buttons to radioPanel
        radioPanel.add(rBtnFaculty);
        radioPanel.add(rBtnStudent);
        facultyPanel.add(radioPanel);
        facultyPanel.add(Box.createRigidArea(horizontal));

        //Add facultyPanel components
        facultyPanel.add(rankLabel);
        facultyPanel.add(rankCBox);
        facultyPanel.add(Box.createRigidArea(horizontal));
        facultyPanel.add(apptDateLabel);
        facultyPanel.add(apptDateField);
        facultyPanel.add(Box.createRigidArea(horizontal));

        //Add studentPanel components
        studentPanel.add(statusLabel);
        studentPanel.add(statusCBox);
        facultyPanel.add(studentPanel);

        //Add buttons to buttonPanel
        buttonPanel.add(btnOK);
        buttonPanel.add(Box.createRigidArea(new Dimension(50,50)));
        buttonPanel.add(btnList);
        buttonPanel.add(Box.createRigidArea(new Dimension(50,50)));
        buttonPanel.add(btnCancel);
        facultyPanel.add(Box.createRigidArea(horizontal));
        facultyPanel.add(buttonPanel);


        basePanel.add(Box.createRigidArea(vertical));
        basePanel.add(labelPanel);
        basePanel.add(Box.createRigidArea(vertical));
        basePanel.add(fieldPanel);
        basePanel.add(Box.createRigidArea(vertical));
        basePanel.add(facultyPanel);
        basePanel.add(Box.createRigidArea(vertical));
        frame.add(basePanel);
    }

public void showList() {
    JOptionPane.showMessageDialog(frame, testWithInput.getList());
}

        @Override
    public void actionPerformed(ActionEvent e) {
        Object source = e.getSource();
        String command = e.getActionCommand();

        System.out.println("actionCommand = " + command);

        if (command.equals("status")) {
            selected = (String)statusCBox.getSelectedItem();
        }
        if (command.equals("rank")) {
            selected = (String) rankCBox.getSelectedItem();
        }
        if (command.equals("faculty")) {
            rankCBox.setEnabled(true);
            apptDateField.setEnabled(true);
            statusCBox.setEnabled(false);
        }
        if (command.equals("student")) {
            rankCBox.setEnabled(false);
            apptDateField.setEnabled(false);
            statusCBox.setEnabled(true);
        }
        if (command.equals("btnCancel")) {
            System.exit(0);
        }
        if (rBtnFaculty.isSelected()) {
            rankCBox.setEnabled(true);
            apptDateField.setEnabled(true);
            statusCBox.setEnabled(false);
            personType = "faculty";
        }
        if(rBtnStudent.isSelected()) {
            rankCBox.setEnabled(false);
            apptDateField.setEnabled(false);
            statusCBox.setEnabled(true);
            personType = "student";
        }
        if (command.equals("btnOK")) {
            Address anAddress = new Address(streetField.getText(), Integer.parseInt(houseField.getText()), cityField.getText(), stateField.getText(), Integer.parseInt(zipField.getText()));
           MyDate aDate = new MyDate();

           try {
            aDate = new MyDate(Integer.parseInt(apptDateField.getText(0,2)), Integer.parseInt(apptDateField.getText(3,2)), Integer.parseInt(apptDateField.getText(4,4)));
            } catch (BadLocationException | NumberFormatException ex)  {
                System.out.println("Bad Date");
            }

            if ("faculty".equals(personType)) {
                selected = (String) rankCBox.getSelectedItem();
                Faculty aFaculty = new Faculty(fNameField.getText(), lNameField.getText(), anAddress, phoneField.getText(), emailField.getText(), selected, aDate);
                testWithInput.addFacultyToList(aFaculty);

            }else if ("student".equals(personType)) {
                selected = (String)statusCBox.getSelectedItem();
                Student aStudent = new Student(fNameField.getText(), lNameField.getText(), anAddress, phoneField.getText(), emailField.getText(), selected);
                testWithInput.addStudentToList(aStudent);
            }

        }
        System.out.println("selected = " + selected);
        if (command.equals("btnList")) {
            showList();
        }
    }
}

