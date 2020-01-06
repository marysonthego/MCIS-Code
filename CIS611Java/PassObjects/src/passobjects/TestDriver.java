package passobjects;

class TestDriver {
    
    public static void main(String args[]) {
        PassObjects ob1 = new PassObjects(100, 22);
        PassObjects ob2 = new PassObjects(100, 22);
        PassObjects ob3 = new PassObjects(-1, -1);
        System.out.println("ob1 == ob2: " + ob1.equals(ob2));
        System.out.println("ob1 == ob3: " + ob1.equals(ob3));
    }
    
 
}
