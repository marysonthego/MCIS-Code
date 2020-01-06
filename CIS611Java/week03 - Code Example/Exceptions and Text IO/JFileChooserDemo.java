import javax.swing.JFileChooser;
import javax.swing.JOptionPane;

public class JFileChooserDemo {

	 public static void main(String s[]) {
	    JFileChooser chooser = new JFileChooser();
	    chooser.setCurrentDirectory(new java.io.File("."));
	    chooser.setDialogTitle("Choose a File");
	    //chooser.setFileSelectionMode(JFileChooser.DIRECTORIES_ONLY);
	    chooser.setAcceptAllFileFilterUsed(false);

	    if (chooser.showOpenDialog(null) == JFileChooser.APPROVE_OPTION) {
	    	String message = "getCurrentDirectory(): " + chooser.getCurrentDirectory() +"\n"
	    			+ "getSelectedFile() : " + chooser.getSelectedFile();
	      JOptionPane.showMessageDialog(null,message);
	     } else {
	    	JOptionPane.showMessageDialog(null,"No Selection ");
	    }
	  }


}
