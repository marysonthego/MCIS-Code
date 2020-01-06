
public class ComputeFibonacci {
  /** Main method */
  public static void main(String args[]) {

    int index = 5;

    // Find and display the Fibonacci number
    System.out.println(
      "Fibonacci number at index " + index + " is " + fib(index));
  }

  /** The method for finding the Fibonacci number */
  public static long fib(long index) {
    if (index == 0) // Base case
      return 0;
    else if (index == 1) // Base case
      return 1;
    else  // Reduction and recursive calls
    {
        System.out.println("index= " + index + " fib= " + fib(index-1) + fib(index-2));
        return fib(index - 1) + fib(index - 2);
    }

  }
}
