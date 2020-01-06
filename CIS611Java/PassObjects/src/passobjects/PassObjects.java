
package passobjects;

public class PassObjects {

            // Objects may be passed to methods.
        int a, b;
        
        PassObjects(int i, int j) {
            a = i;
            b = j;
        }
        
   // return true if o is equal to the invoking object
        boolean equals(PassObjects o) {
            if(o.a == a && o.b == b) return true;
             else return false;
        }

}
