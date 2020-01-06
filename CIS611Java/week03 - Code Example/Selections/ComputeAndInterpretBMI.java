
import javax.swing.JOptionPane;


public class ComputeAndInterpretBMI {
  public static void main(String[] args) {
    	  
    
    // Prompt the user to enter weight in pounds
	    String message; 
	    message= "Enter weight in pounds: ";
	        
	    // get the answer from user
	    String input = JOptionPane.showInputDialog(message);
	    
	    // convert answers to double
	    double  weight =   Double.parseDouble(input);
	    
       
    // Prompt the user to enter height in inches
	    message= "Enter height in inches: ";
        
	    // get the answer from user
	    input = JOptionPane.showInputDialog(message);
	    
	    // convert answers to double
	    double  height =   Double.parseDouble(input);
    
    
    final double KILOGRAMS_PER_POUND = 0.45359237; // Constant
    final double METERS_PER_INCH = 0.0254; // Constant 
    
    // Compute BMI
    double weightInKilograms = weight * KILOGRAMS_PER_POUND; 
    double heightInMeters = height * METERS_PER_INCH; 
    double bmi = weightInKilograms / 
      (heightInMeters * heightInMeters);

    // Display result
    JOptionPane.showMessageDialog(null,"BMI is " + bmi);
    if (bmi < 18.5)
    	 JOptionPane.showMessageDialog(null,"Underweight");
    else if (bmi < 25)
    	 JOptionPane.showMessageDialog(null,"Normal");
    else if (bmi < 30)
    	 JOptionPane.showMessageDialog(null,"Overweight");
    else
    	 JOptionPane.showMessageDialog(null,"Obese");
  }
}
