
public class FahrenheitToCelsius {
  public static void main(String[] args) {
    

    // A degree in Fahrenheit
    double fahrenheit = 25.05; 

    // Convert Fahrenheit to Celsius
    double celsius = (5.0 / 9) * (fahrenheit - 32);
    System.out.println("Fahrenheit " + fahrenheit + " is " + 
      celsius + " in Celsius");  
  }
}
