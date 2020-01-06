package arraySelectionSort;

public class ArraySelectionSort {

    public static void main(String[] args) {

        int[] list = new int[10];
        int smallest, smallestIndex;
        
        
        // initialize list with random numbers
        for (int y = 0; y < list.length-1; y++)
            list[y] = (int)(Math.random() * 100); 
        
        // set initial smallest
        
        // print the list
        for(int x=0; x<list.length-1;++x)
            System.out.print("[" + x + "] = " + list[x] + " ");
        System.out.println();
        
        for (int i = 0; i < list.length-1; i++) {
            smallest = list[i];
            smallestIndex = i;
            //select the smallest element in list[i..listSize-1];
            for (int j = i+1; j < list.length-1; ++j) {
                if (list[j] < smallest) {
                    smallest = list[j];
                    smallestIndex = j;
                }
            } // end for j
            // if index of smallest isn't i, 
                // value at smallestIndex = value at i
                // value at i = saved value of smallest
            if (smallestIndex != i) {
                list[smallestIndex] = list[i];
                list[i] = smallest;
            }
        } // end for i
        
        // print the list
        for(int x=0; x<list.length-1;++x)
            System.out.print("[" + x + "] = " + list[x] + " ");
        System.out.println();
        
        System.out.println(java.util.Arrays.toString(list));
                
    } // end main

} // end class  
