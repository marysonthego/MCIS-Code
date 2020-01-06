

import javax.swing.JOptionPane;

public class TestBreak {
  public static void main(String[] args) {
    int sum = 0;
    int number = 0;

    while (number < 20) {
      number++;
      sum += number;
      if (sum >= 100) break;
    }

    JOptionPane.showMessageDialog(null,"The number is " + number);
    JOptionPane.showMessageDialog(null,"The sum is " + sum);
  }
}
