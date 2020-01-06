
import javax.swing.JOptionPane;

public class FutureTuition {

	public static void main(String[] args) {
    double tuition = 10000;   // Year 1
    int year = 1;
    while (tuition < 20000) {
      tuition = tuition * 1.07;
      year++;
    }

    JOptionPane.showMessageDialog(null,"Tuition will be doubled in "
      + year + " years");
  }
}
