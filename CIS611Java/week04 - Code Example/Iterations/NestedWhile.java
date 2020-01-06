

import javax.swing.JOptionPane;

public class NestedWhile {

public static void main (String [] args) {

	String output="";
	int x=0;
	int y=0;

	while (x <= 10) 	{
		   y = 0;
		    while (y <= x){
		        y++;
		        output += " * ";

		    }
		    x++;
		    output += "\n";
		}

	JOptionPane.showMessageDialog(null,output,"Result",JOptionPane.INFORMATION_MESSAGE);
	System.exit(0);

}
}
