
public class MyClass {

/*    public static void main(String[] args) {
 
            Count myCount = new Count(); 
            int times = 0;
            
            for (int i=0; i<100; i++) 
                increment(myCount, times);
            System.out.println ("myCount.count = " + myCount.count);
            System.out.println("times = "+ times);
        }
        public static void increment(Count c, int times) { 
            c.count++; times++;
        }
}
        
    class Count {
        int count ;
        Count(int c) {
            count = c;
        }
        Count () { 
            count = 1;
        }
}
  */  
        int i;
        static int s;
        
        public static void main (String [] args) {
        
            MyClass fl = new MyClass();

        System.out.println("fl.i is " + fl.i + " f1.s is " + fl.s); 
        MyClass f2 = new MyClass();
        System.out.println("f2.i is " + f2.i + " f2.s is " + f2.s); 
        MyClass f3 = new MyClass();
        System.out.println("f3.i is " + f3.i + " f3.s is " + f3.s);
        }
        
        public MyClass() { 
            i++; 
            s++;
        }
}