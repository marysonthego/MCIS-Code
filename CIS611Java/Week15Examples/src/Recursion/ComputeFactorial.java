
public class ComputeFactorial {
  /** Main method */
  public static void main(String[] args) {

    int n = 10;

    // Display factorial
    System.out.println("Factorial of " + n + " is " + factorial(n));
  }

  /** Return the factorial for a specified number */
  public static long factorial(int n) {
    if (n == 0) // Base case
      return 1;
    else {
        System.out.println("n= " + n);
      return n * factorial(n - 1); // Recursive call
    }
  }
}
