package PP03;

public class TaxIncome implements Taxable {
	
	// [x] 1- this class implements the Taxable interface
	// [x] 2- implement all the unimplemented abstract methods in the Taxable Interface, income tax is computed based on state and federal taxes   

	@Override
	public double compStateTax(double grossPay) {
		// TODO Auto-generated method stub
		return grossPay * STATE_TAX;
	}

	@Override
	public double compFederalTax(double grossPay) {
		// TODO Auto-generated method stub
		return grossPay * FEDERAL_TAX;
	}

	@Override
	public double compIncomeTax(double grossPay) {
		// TODO Auto-generated method stub
		return this.compFederalTax(grossPay) + this.compStateTax(grossPay);
	}


	

}
