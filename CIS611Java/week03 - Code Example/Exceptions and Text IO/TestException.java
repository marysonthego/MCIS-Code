
import javax.swing.JOptionPane;

public class TestException  {
  public static void main(String[] args) {
    try {
    	JOptionPane.showMessageDialog(null, sum(new int[] {1, 2, 3, 4, 5}));
    }
    catch (Exception ex) {
      ex.printStackTrace();
      JOptionPane.showMessageDialog(null,"\n" + ex.getMessage());
      JOptionPane.showMessageDialog(null,"\n" + ex.toString());

      JOptionPane.showMessageDialog(null,"\nTrace Info Obtained from getStackTrace");
      StackTraceElement[] traceElements = ex.getStackTrace();
      
      for (int i = 0; i < traceElements.length; i++) {
    	  JOptionPane.showMessageDialog(null,"method " + traceElements[i].getMethodName());
    	  JOptionPane.showMessageDialog(null,"(" + traceElements[i].getClassName() + ":");
    	  JOptionPane.showMessageDialog(null,traceElements[i].getLineNumber() + ")");
      }
    }
  }

  private static int sum(int[] list) {
    int result = 0;
    for (int i = 0; i <= list.length; i++)
      result += list[i];
    return result;
  }
}
