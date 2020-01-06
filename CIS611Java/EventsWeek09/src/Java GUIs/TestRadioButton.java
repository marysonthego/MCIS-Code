import java.awt.FlowLayout;
import java.awt.GridLayout;
import java.awt.event.KeyEvent;

import javax.swing.*;

public class TestRadioButton {
	
	private JRadioButton radDog = new JRadioButton("Dog", true);
    private JRadioButton radCat = new JRadioButton("Cat");
    private JRadioButton radMouse = new JRadioButton("Mouse");
   
    private JFrame mainFrame;
	private JLabel headerLabel;
	private JLabel statusLabel;
	private JPanel controlPanel;

	public TestRadioButton(){
	      prepareGUI();
	   }

	    

	   private void prepareGUI(){
		   
	      mainFrame = new JFrame("Java Radio Button Sample");
	      mainFrame.setSize(400,150);
	      mainFrame.setLayout(new GridLayout(3, 1));
	      
	      headerLabel = new JLabel("", JLabel.CENTER);        
	      statusLabel = new JLabel("",JLabel.CENTER);    

	      statusLabel.setSize(350,100);

	      controlPanel = new JPanel();
	      controlPanel.setLayout(new FlowLayout());
	      

	      mainFrame.add(headerLabel);
	      mainFrame.add(controlPanel);
	      mainFrame.add(statusLabel);
	      mainFrame.setVisible(true);  
	   }

	   private void showRadioButtonDemo(){
	      headerLabel.setText("RadioButton Group:"); 

	      radDog.setMnemonic(KeyEvent.VK_C);
	      radCat.setMnemonic(KeyEvent.VK_M);
	      radMouse.setMnemonic(KeyEvent.VK_P);

	     

	      //Group the radio buttons.
	      ButtonGroup group = new ButtonGroup();
	      group.add(radDog);
	      group.add(radCat);
	      group.add(radMouse);

	      controlPanel.add(radDog);
	      controlPanel.add(radCat);
	      controlPanel.add(radMouse);       

	      mainFrame.setVisible(true);  
	   }
	   
	   public static void main(String[] args){
		   TestRadioButton  swingControlDemo = new TestRadioButton();      
	      swingControlDemo.showRadioButtonDemo();
	   }
	}
