package sets;

/* 
 * cmd line: java FindDups i came i saw i left
 * output: 4 distinct words: [left, came, saw, i]
*/

import java.util.*;
import java.util.stream.*;

public class FindDups {
	
    public static void main(String[] args) {
        Set<String> distinctWords = Arrays.asList(args).stream()
		.collect(Collectors.toSet()); 
        System.out.println(distinctWords.size()+ 
                           " distinct words: " + distinctWords);
    }
    
/* Suppose you have a Collection, c, and you want to create another Collection containing the same elements but with all duplicates eliminated. 
*/
    public void noDups() {
    	//Collection<Type> noDups = new HashSet<Type>(c);
    	/* It works by creating a Set (which, by definition, cannot contain duplicates), initially containing all the elements in c. It uses the standard conversion constructor

Or, if using JDK 8 or later, you could easily collect into a Set using aggregate operations:

c.stream().collect(Collectors.toSet()); // no duplicates
Here's a slightly longer example that accumulates a Collection of names into a TreeSet:

Set<String> set = people.stream().map(Person::getName).collect(Collectors.toCollection(TreeSet::new));

And the following is a minor variant of the first idiom that preserves the order of the original collection while removing duplicate elements:

Collection<Type> noDups = new LinkedHashSet<Type>(c);

The following is a generic method that encapsulates the preceding idiom, returning a Set of the same generic type as the one passed.

public static <E> Set<E> removeDups(Collection<E> c) {
    return new LinkedHashSet<E>(c);
}
*/
    }
}

/*

A Set is a Collection that cannot contain duplicate elements.

Set also adds a stronger contract on the behavior of the equals and hashCode operations, allowing Set instances to be compared meaningfully even if their implementation types differ. Two Set instances are equal if they contain the same elements.

The Java platform contains three general-purpose Set implementations: HashSet, TreeSet, and LinkedHashSet. 

HashSet, which stores its elements in a hash table, is the best-performing implementation; however it makes no guarantees concerning the order of iteration. 

TreeSet, which stores its elements in a red-black tree, orders its elements based on their values; it is substantially slower than HashSet. 

LinkedHashSet, which is implemented as a hash table with a linked list running through it, orders its elements based on the order in which they were inserted into the set (insertion-order). 

LinkedHashSet spares its clients from the unspecified, generally chaotic ordering provided by HashSet at a cost that is only slightly higher.
*/