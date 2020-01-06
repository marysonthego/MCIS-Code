import java.lang.*;

public class Test {
    public static void main(String[] args) {
        Tester aTest = new Test().new Tester();
        aTest.testStart();
    }

class Tester {
    public int x = 2;
    void testStart() {
        System.out.println("x = " + x);
        testInt(x);
        System.out.println("Pass x as an argument to a method in its own class. No Change! x = " + x);
        testIntClassVar();
        System.out.println("Change x directly in the class. x = " + x);
    }
    void testInt(int i) {
        i = 17;
        Math.abs(-7); //compiles and runs ok
    }
    void testIntClassVar() {
        x = 17;
    }
  }
}
/*        
        String s = "University";
        
        String t = s;
        System.out.println("(t = s): t = " + t + " s = " + s);
           
        testString(s);
        System.out.println("s is not changed by passing s to testString(s) " + s);
        
        testString(c);
        System.out.println("Class var c is not changed by passing c to testString(c) " + c);

        testString("");
        System.out.println("Class var c IS changed by testString() " + c);
        
        testInt(x);
  
        System.out.println("x = " + x);
    
    }
    
    void testString(String s) {
          s = s.replace("i","ABC");
          System.out.println("In testString passed argument changed to " + s);
          if (s.equals("")) {
              c = c.replace("i","ABC");
          }
    }
    

}
}

/*        
        String s1 = "Mary";
        String s2 = "Clark";
        
        //s1.charAt(0) = '5';
        //int i = sl.length;
        //String s1 = new String("new string s2");
        //s1 >= s2;
        s1 = s1 + s2;
        System.out.println(s11);
        
        s1 = s1 + s2;
        System.out.println(s1);
        
        //new Scanner(temp.txt);
        //new Scanner(new File("temp.txt"));
        //new Scanner(File("temp.txt"));
        new Scanner("temp.txt");
        //new PrintWriter(File("temp.txt"));
        new PrintWriter("temp.txt");
        new PrintWriter(new File("temp.txt"));
*/

