package programmingquiz9;

public class ProgrammingQuiz9 {

    public static void main(String[] args) {
        new ProgrammingQuiz9();
    }

    public ProgrammingQuiz9() {
        PrintChar printA = new PrintChar('x',10);
        PrintChar printB = new PrintChar('y',10);

        printB.run();
        printA.run();
    }

    class PrintChar implements Runnable {
        private char charToPrint;
        private int times;

        public PrintChar (char c, int t) {
            charToPrint = c;
            times = t;
        }

    public void run() {
        for (int i=0; i<5; i++) {
            System.out.println(charToPrint);
        }
    }
    }
}