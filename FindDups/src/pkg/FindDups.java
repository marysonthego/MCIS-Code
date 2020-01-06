package pkg;

import java.util.*;
import java.util.stream.*;

public class FindDups {
    public static void main(String[] args) {
        Set<String> distinctWords = Arrays.asList(args).stream().collect(Collectors.toSet()); 
        System.out.println(distinctWords.size() + " distinct words: " + distinctWords);
    }
}

/*Note that the code always refers to the Collection by its interface type (Set) rather than by its implementation type. This is a strongly recommended programming practice because it gives you the flexibility to change implementations merely by changing the constructor.

Referring to collections only by their interface prevents you from using any nonstandard operations.

Using the for-each Construct:

import java.util.*;

public class FindDups {
    public static void main(String[] args) {
        Set<String> s = new HashSet<String>();
        for (String a : args)
               s.add(a);
               System.out.println(s.size() + " distinct words: " + s);
    }
}

The implementation type of the Set in the preceding example is HashSet, which makes no guarantees as to the order of the elements in the Set. If you want the program to print the word list in alphabetical order, merely change the Set's implementation type from HashSet to TreeSet.

To calculate the union, intersection, or set difference of two sets nondestructively (without modifying either set), the caller must copy one set before calling the appropriate bulk operation. The following are the resulting idioms.

Set<Type> union = new HashSet<Type>(s1);
union.addAll(s2);

Set<Type> intersection = new HashSet<Type>(s1);
intersection.retainAll(s2);

Set<Type> difference = new HashSet<Type>(s1);
difference.removeAll(s2);
 *
 */
