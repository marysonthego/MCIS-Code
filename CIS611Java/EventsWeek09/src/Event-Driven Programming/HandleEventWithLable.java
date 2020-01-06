
import javax.swing.*;
import java.awt.event.*;

public class HandleEventWithLable extends JFrame {
	
	JLabel headerLabel;
  
	public HandleEventWithLable() {
    // Create two buttons 
    JButton jbtOK = new JButton("OK");
    JButton jbtCancel = new JButton("Cancel");
    
    headerLabel = new JLabel("Hello I am here");

    // Create a panel to hold buttons
    JPanel panel = new JPanel();
    panel.add(jbtOK);
    panel.add(jbtCancel);
    panel.add(headerLabel);

    add(panel); // Add panel to the frame

    // Register listeners
    ActionListener listener1 = new OKListenerClass(this);
    CancelListenerClass listener2 = new CancelListenerClass(this);
    jbtOK.addActionListener(listener1);
    jbtCancel.addActionListener(listener2);
  }
  
  public static void main(String[] args) {
    JFrame frame = new HandleEventWithLable();
    frame.setTitle("Handle Event");
    frame.setSize(200, 150);
    frame.setLocation(200, 100);
    frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    frame.setVisible(true);
  }
}

class OKListenerClass implements ActionListener {
	
	HandleEventWithLable handle;
	
	OKListenerClass(HandleEventWithLable handle){
		
		this.handle = handle;
	}
	
  @Override 
  public void actionPerformed(ActionEvent e) {
    handle.headerLabel.setText("OK button clicked");
  }
}

class CancelListenerClass implements ActionListener {
	
HandleEventWithLable handle;
	
CancelListenerClass(HandleEventWithLable handle){
		
		this.handle = handle;
	}
	
  @Override 
  public void actionPerformed(ActionEvent e) {
	  handle.headerLabel.setText("Cancel button clicked");
  }
}
