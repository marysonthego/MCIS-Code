
public class DisplayTime {
  public static void main(String[] args) {
    
    // An integer for seconds
    int seconds = 45;
 
    int minutes = seconds / 60; // Find minutes in seconds
    int remainingSeconds = seconds % 60; // Seconds remaining
    System.out.println(seconds + " seconds is " + minutes + 
      " minutes and " + remainingSeconds + " seconds");  
  }
}
