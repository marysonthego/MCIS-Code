package maps;
import java.util.*;

/*
 * generates a frequency table of the words found in its argument list. The frequency table maps each word to the number of times it occurs in the argument list.
 * 
 * cmd line: java Freq if it is to be it is up to me to delegate
 * Output: 
 * 8 distinct words:
   {to=3, delegate=1, be=1, it=2, up=1, if=1, me=1, is=2}
   
    to see the frequency table in alphabetical order. All you have to do is change the implementation type of the Map from HashMap to TreeMap.
    
    to make the program print the frequency table in the order the words first appear on the command line simply change the implementation type of the map to LinkedHashMap. 
 */

public class Frequency {
    public static void main(String[] args) {
        Map<String, Integer> m = new HashMap<String, Integer>();

        // Initialize frequency table from command line
        for (String a : args) {
            Integer freq = m.get(a);
            m.put(a, (freq == null) ? 1 : freq + 1);
        }

        System.out.println(m.size() + " distinct words:");
        System.out.println(m);
    }
}