package binarySearch;

public class BinarySearch {

    public static void main(String[] args) {
        int[] list = {10,20,30, 40, 50, 60, 70, 80, 90, 100};
        int key = 0;

        for (key = 0; key < 100; key+=10) {
            int low = 0;
            int high = list.length - 1;
            int index = -1;
           
            while (high >= low) {
                int mid = (low + high) / 2;
                System.out.println("index = " + index + " key = " + key + " low = " + low + " mid = " + mid + " high = " + high);
                if (key < list[mid])
                    high = mid - 1;
                else { if (key == list[mid]) {
                    index = mid;
                    System.out.println("FOUND KEY index = " + index + " key = " + key + " low = " + low + " mid = " + mid + " high = " + high);
                    break;
                    }
                    else
                        low = mid + 1;
                }
            } // end while
        } // end for
    } // end main
} // end BinarySearch
