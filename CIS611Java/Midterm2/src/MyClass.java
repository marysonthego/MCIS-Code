
public class MyClass {
    
    int i;
    static int s;

    public static void main(String[] args) {
        int number = 9;
        MyClass f1 = new MyClass();
        System.out.println("f1.i is " + f1.i + "f1.s is " + f1.s);
        
        MyClass f2 = new MyClass();
        System.out.println("f2.i is " + f2.i + "f2.s is " + f2.s);

        MyClass f3 = new MyClass();
        System.out.println("f3.i is " + f3.i + "f3.s is " + f3.s);
        
        int sum = 0;
        int item = 0;
        do {
        item++;
        sum += item;
        if (sum > 4) break;
        }
        
        while (item < 5);
        System.out.println("sum " + sum);
        
        try {
            System.out.println("Welcome");
            int i = 0;
            int y = 2/i;
            System.out.println("Welcome");
        } catch (RuntimeException e) {
            System.out.println("Welcome");
        }
        finally {
            System.out.println("Block");
        }
        
        
    }

    public MyClass() {
        i++;
        s++;
        
        MyClass A = new MyClass(null);
    }
}
