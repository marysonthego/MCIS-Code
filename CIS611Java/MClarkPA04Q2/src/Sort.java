//*********************************************************************
//*                                                                   *
//*  CIS611                  Spring, 2019             Mary Clark      *
//*                                                                   *
//*                     Program Assignment PA04Q2                     *
//*                                                                   *
//*                     Class Description                             *
//* Class Sort                                                        *
//*                                                                   *
//* The Sort class has only one static selectionSort() method that    *
//* receives two arrays in its parameter list (pName and pPrice) and  *
//* sorts the arrays by using the selection sort algorithm. It        *
//* basically sorts the pPrice array in an ascending order, so that   *
//* any change in pPrice array results in a change in the pName array *
//* in order to keep the product name and price elements in both      *
//* arrays in the same order (having the same index values for each   *
//* name and price in both pName and pPrice arrays)                   *
//*                                                                   *
//*  Date Created: 02/25/2019                                         *
//*                                                                   *
//*  Saved in: Sort.java                                              *
//*                                                                   *
//*********************************************************************/
/**
 * @author Mary Clark
 *
 */
public class Sort {
    
    public static void selectionSort(String[] pName, Double[] pPrice) {
        
        double smallest;
        String smallestName = new String();
        int smallestIndex;
        
        for (int i = 0; i < pPrice.length; i++) {
            smallest = pPrice[i];
            smallestIndex = i;
            //select the smallest element 
            for (int j = i+1; j < pPrice.length; ++j) {
                if (pPrice[j] < smallest) {
                    smallest = pPrice[j];
                    smallestName = pName[j];
                    smallestIndex = j;
                }
            } // end for j
            // if index of smallest isn't i, 
                // value at smallestIndex = value at i
                // value at i = saved value of smallest
            if (smallestIndex != i) {
                pPrice[smallestIndex] = pPrice[i];
                pName[smallestIndex] = pName[i];
                pPrice[i] = smallest;
                pName[i] = smallestName;
            }
        } // end for i
    }
}
