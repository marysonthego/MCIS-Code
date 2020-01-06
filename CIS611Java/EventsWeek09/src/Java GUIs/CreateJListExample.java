import java.awt.FlowLayout;

import javax.swing.JFrame;
import javax.swing.JList;

public class CreateJListExample  extends JFrame {

	private static final long serialVersionUID = 1L;

	public CreateJListExample() {

		// set flow layout for the frame
		this.getContentPane().setLayout(new FlowLayout());

		Object[] data = { "Value 1", "Value 2", "Value 3", "Value 4", "Value 5" };

		JList list = new JList(data);

		// add list to frame
		add(list);

	}

	private static void createAndShowGUI() {

  //Create and set up the window.

  JFrame frame = new CreateJListExample();

  //Display the window.

  frame.pack();

  frame.setVisible(true);

  frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);

    }

	public static void main(String[] args) {
		createAndShowGUI(); 
    }

 
  

}