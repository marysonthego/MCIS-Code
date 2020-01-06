
import javax.swing.JOptionPane;

public class NestedForWhile {

	public static void main(String[] args) {

		String output = "";
		int i = 9;
		while (i > 0){
            for(int j = i; j > 0; j--){
                output+=i;
            }
            output+="\n";
            i--;
        }

		JOptionPane.showMessageDialog(null,output,"Result",JOptionPane.INFORMATION_MESSAGE);
    	System.exit(0);

	}

}
