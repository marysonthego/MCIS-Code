import javax.swing.JOptionPane;

public class GuessBirthday {
  public static void main(String[] args) {
    String set1 =
      " 1  3  5  7\n" +
      " 9 11 13 15\n" +
      "17 19 21 23\n" +
      "25 27 29 31";

    String set2 =
      " 2  3  6  7\n" +
      "10 11 14 15\n" +
      "18 19 22 23\n" +
      "26 27 30 31";

    String set3 =
      " 4  5  6  7\n" +
      "12 13 14 15\n" +
      "20 21 22 23\n" +
      "28 29 30 31";

    String set4 =
      " 8  9 10 11\n" +
      "12 13 14 15\n" +
      "24 25 26 27\n" +
      "28 29 30 31";

    String set5 =
      "16 17 18 19\n" +
      "20 21 22 23\n" +
      "24 25 26 27\n" +
      "28 29 30 31";

    int day = 0;

    
    // Prompt the user to answer questions
    String message = "Is your birthday in Set1?\n" + set1 + "\nEnter 0 for No and 1 for Yes: ";
    /*System.out.print("Is your birthday in Set1?\n");
    System.out.print(set1);
    System.out.print("\nEnter 0 for No and 1 for Yes: ");*/
    String answerStr = JOptionPane.showInputDialog(message);
    int answer = Integer.parseInt(answerStr);

    if (answer == 1)
      day += 1;

    // Prompt the user to answer questions
    message = "\nIs your birthday in Set2?\n" + set2 + "\nEnter 0 for No and 1 for Yes: ";
   /* System.out.print("\nIs your birthday in Set2?\n");
    System.out.print(set2);
    System.out.print("\nEnter 0 for No and 1 for Yes: ");*/
    answerStr = JOptionPane.showInputDialog(message);
    answer = Integer.parseInt(answerStr);

    if (answer == 1)
      day += 2;

    // Prompt the user to answer questions
    message = "Is your birthday in Set3?\n" + set3 + "\nEnter 0 for No and 1 for Yes: ";
   /* System.out.print("Is your birthday in Set3?\n");
    System.out.print(set3);
    System.out.print("\nEnter 0 for No and 1 for Yes: ");*/
    answerStr = JOptionPane.showInputDialog(message);
    answer = Integer.parseInt(answerStr);


    if (answer == 1)
      day += 4;

    // Prompt the user to answer questions
    message = "\nIs your birthday in Set4?\n" + set4 + "\nEnter 0 for No and 1 for Yes: ";
   /* System.out.print("\nIs your birthday in Set4?\n");
    System.out.print(set4);
    System.out.print("\nEnter 0 for No and 1 for Yes: ");*/
    answerStr = JOptionPane.showInputDialog(message);
    answer = Integer.parseInt(answerStr);

    if (answer == 1)
      day += 8;

    // Prompt the user to answer questions
    message = "\nIs your birthday in Set5?\n" + set5 + "\nEnter 0 for No and 1 for Yes: ";
   /* System.out.print("\nIs your birthday in Set5?\n");
    System.out.print(set5);
    System.out.print("\nEnter 0 for No and 1 for Yes: ");*/
    answerStr = JOptionPane.showInputDialog(message);
    answer = Integer.parseInt(answerStr);

    if (answer == 1)
      day += 16;

    JOptionPane.showMessageDialog(null,"\nYour birthday is " + day + "!");
  }
}