
import javax.swing.JOptionPane;

public class TestFileClass {
  public static void main(String[] args) {
    java.io.File file = new java.io.File("image/us.gif");
    JOptionPane.showMessageDialog(null,"Does it exist? " + file.exists());
    JOptionPane.showMessageDialog(null,"The file has " + file.length() + " bytes");
    JOptionPane.showMessageDialog(null,"Can it be read? " + file.canRead());
    JOptionPane.showMessageDialog(null,"Can it be written? " + file.canWrite());
    JOptionPane.showMessageDialog(null,"Is it a directory? " + file.isDirectory());
    JOptionPane.showMessageDialog(null,"Is it a file? " + file.isFile());
    JOptionPane.showMessageDialog(null,"Is it absolute? " + file.isAbsolute());
    JOptionPane.showMessageDialog(null,"Is it hidden? " + file.isHidden());
    JOptionPane.showMessageDialog(null,"Absolute path is " +
      file.getAbsolutePath());
    JOptionPane.showMessageDialog(null,"Last modified on " +
      new java.util.Date(file.lastModified()));
  }
}
