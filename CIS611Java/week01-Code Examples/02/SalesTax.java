
public class SalesTax {
  public static void main(String[] args) {
    

    // Purchase amount
    double purchaseAmount = 4500;
    
    double tax = purchaseAmount * 0.06;
    System.out.println("Sales tax is " + (int)(tax * 100) / 100.0);
  }
}
