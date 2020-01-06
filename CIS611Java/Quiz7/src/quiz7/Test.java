
package quiz7;

interface A {
    
}

class C {
    
}

class B extends D implements A {
    
}

public class Test {
    public static void main(String[] args) {
        B b = new B();
        
        if (b instanceof A) {
            System.out.println("b is an instance of A");
        }
        if (b instanceof C) {
            System.out.println("b is an instance of C");
        }
    }
}

class D extends C {

}
