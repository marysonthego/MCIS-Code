public class ComputeLoan {
  public static void main(String[] args) {   
    
    // Yearly interest rate, for example 8.25
    double annualInterestRate = 2.8;
    
    // Obtain monthly interest rate
    double monthlyInterestRate = annualInterestRate / 1200;

    // number of years as an integer, for example 5
    int numberOfYears = 10;
    
    // Loan amount, for example 120000.95
    double loanAmount = 1270000;
    
    // Calculate payment
    double monthlyPayment = loanAmount * monthlyInterestRate / (1
      - 1 / Math.pow(1 + monthlyInterestRate, numberOfYears * 12));
    double totalPayment = monthlyPayment * numberOfYears * 12;

    // Display results
    System.out.println("The monthly payment is " + 
      (int)(monthlyPayment * 100) / 100.0);
    System.out.println("The total payment is " + 
      (int)(totalPayment * 100) / 100.0);
  }
}
