// https://examples.javacodegeeks.com/desktop-java/swing/java-swing-checkbox-example/

import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.BorderFactory;
import javax.swing.JCheckBox;

import java.awt.GridLayout;
import java.awt.event.ItemEvent;
import java.awt.event.ItemListener;

public class CkeckBoxWithEventListener {
	// Create different checkbox
	public static JCheckBox checkbox1 = new JCheckBox("Alex");
	public static JCheckBox checkbox2 = new JCheckBox("Jessica");
	public static JCheckBox checkbox3 = new JCheckBox("Lily");
	public static JCheckBox checkbox4 = new JCheckBox("Steven");

	public static void main(String[] args) {
		// Create and set up a frame window
		JFrame.setDefaultLookAndFeelDecorated(true);
		JFrame frame = new JFrame("Checkbox with event listener");
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);

		// Define the panel to hold the checkbox
		JPanel panel1 = new JPanel();
		JPanel panel2 = new JPanel();
		JLabel msg = new JLabel("", JLabel.CENTER);

		// Set up the title for the panel
		panel1.setBorder(BorderFactory.createTitledBorder("Name"));
		panel2.setBorder(BorderFactory.createTitledBorder("Output"));

		// Add the checkbox into the panels
		panel1.add(checkbox1);
		panel1.add(checkbox2);
		panel1.add(checkbox3);
		panel1.add(checkbox4);

		panel2.add(msg);

		// Add action listener
		checkbox1.addItemListener(new ItemListener() {
			public void itemStateChanged(ItemEvent e) {
				if (e.getStateChange() == 1) {
					msg.setText("Alex is selected");
				} else {
					msg.setText("Alex is unselected");
				}
			}
		});

		checkbox2.addItemListener(new ItemListener() {
			public void itemStateChanged(ItemEvent e) {
				if (e.getStateChange() == 1) {
					msg.setText("Jessica is selected");
				} else {
					msg.setText("Jessica is unselected");
				}
			}
		});

		checkbox3.addItemListener(new ItemListener() {
			public void itemStateChanged(ItemEvent e) {
				if (e.getStateChange() == 1) {
					msg.setText("Lily is selected");
				} else {
					msg.setText("Lily is unselected");
				}
			}
		});

		checkbox4.addItemListener(new ItemListener() {
			public void itemStateChanged(ItemEvent e) {
				if (e.getStateChange() == 1) {
					msg.setText("Steven is selected");
				} else {
					msg.setText("Steven is unselected");
				}
			}
		});

		// Add the panel into the frame
		frame.setLayout(new GridLayout(2, 1));
		frame.add(panel1);
		frame.add(panel2);

		// Set the window to be visible as the default to be false
		frame.pack();
		frame.setVisible(true);
	}

}