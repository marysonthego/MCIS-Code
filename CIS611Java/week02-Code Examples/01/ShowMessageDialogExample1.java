import javax.swing.ImageIcon;
import javax.swing.JFrame;
import javax.swing.JOptionPane;
 
public class ShowMessageDialogExample1
{
  public static void main(String[] args)
  {
    String filePath = "/Users/documents/data.txt";
     
    // create a jframe
    JFrame frame = new JFrame("JOptionPane showMessageDialog Example");
 
    // show a joptionpane dialog using showMessageDialog
    JOptionPane.showMessageDialog(frame,
        "Read data from this file path: '" + filePath + "'.",
        "File Path",
        JOptionPane.INFORMATION_MESSAGE);
    
  }
}