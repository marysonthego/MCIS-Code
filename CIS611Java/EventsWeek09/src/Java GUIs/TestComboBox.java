
import javax.swing.JComboBox;
import javax.swing.JFrame;

/*
 * A basic swing example with JComboBox
 */

public class TestComboBox {

	public static void main(String[] args) {
		JFrame frame = new JFrame("Hello Swing");
		
		// Set data in the drop-down list
		String[] country = {"Australia", "China", "England", "Russia", "United States"};
		
		// Create combobox
		JComboBox cb = new JComboBox(country);
		
		frame.add(cb);
		frame.pack();
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.setVisible(true);
	}

}