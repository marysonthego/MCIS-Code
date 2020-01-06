package arrayplay;
import java.util.*;



public class ArrayPlay {

  
    public static void main(String[] args) {

    int[] intArray = new int[10];
    intArray[0] = 12;
    String myString = "1234567890";
    
    System.out.println("intArray.length =  " + intArray.length);
    System.out.println("myString.length() =  " + myString.length());
    
    for (int i : intArray) {
        System.out.println("intArray.length = " + intArray.length);
    }
    
    }

}
