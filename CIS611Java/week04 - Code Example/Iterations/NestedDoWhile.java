

import javax.swing.JOptionPane;

public class NestedDoWhile {

	public static void main(String[] args) {
		String output="";
		int x=1;
		int y=1;

        do {

            do {

		        output += " " + y + " ";
                y++;

            } while (y <= x);
            y = 1;
            x++;
            output += "\n";

        } while (x <= 10);

        JOptionPane.showMessageDialog(null,output,"Result",JOptionPane.INFORMATION_MESSAGE);
    	System.exit(0);

	}

}
