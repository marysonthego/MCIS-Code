//*********************************************************************
//*                                                                   *
//*  CIS611                  Spring, 2019             Mary Clark      *
//*                                                                   *
//*               Program Assignment PA01 Question 2                  *
//*                                                                   *
//*                     Class Description                             *
//*                                                                   *
//*  This class computes the United States federal personal income    *
//*  for N persons. The United States federal personal income tax is  * 
//*  calculated based on filing status and taxable income. There are  * 
//*  four filing statuses: single filers, married filing jointly,     *
//*  married filing separately, and head of household. The tax rates  *
//*  vary every year. The table below shows the rates for 2009.       * 
//*  If you are, say, single with a taxable income of $10,000, the    *
//*  first $8,350 is taxed at 10% and the other $1,650 is taxed at    *
//*  15%. So, your tax is $1,082.5.                                   * 
//*                                                                   *
//*  This class contains an algorithm to compute personal income tax. *
//*  The algorithm prompts the user to enter the filing status and    * 
//*  taxable income and compute the tax. Users enter 0 for single     *
//*  filers, 1 for married filing jointly, 2 for married filing       *
//*  separately, and 3 for head of household. The algorithm           *
//*  terminates when all N person's taxes are calculated.             *
//*                                                                   *
//*  Date Created: 01/29/2019                                         *
//*                                                                   *
//*  Saved in: MaryClarkPA01Q2.java                                   *
//*                                                                   *
//*********************************************************************

import javax.swing.JOptionPane;

public class MaryClarkPA01 {

	public static void main(String[] args){
	  
	  //Initialize variables to default values
	  int filingStatus = 0;
	  double taxableIncome = 0.0, tax = 0.0;
	  int maxFilingStatus = 4, maxRateBracket = 6;
	  
	  //Array of tax rates for tax brackets
	  double[] taxRateForBracket = {.10, .15, .25, .28, .33, .35 };
	  
	  // Build a tax table array by tax bracket
	  int[][] taxTables = new int[4][6];
	  
	  for (int i = 0; i < maxFilingStatus; ++i) {
	    //Single filing status max for brackets in 2009
	    if (i == 0) {
	      taxTables[i][0] = 8350;
	      taxTables[i][1] = 33950;
	      taxTables[i][2] = 82250;
	      taxTables[i][3] = 171550;
	      taxTables[i][4] = 372950;
	      taxTables[i][5] = 372951;
	    }
	    //Married Filing Jointly max for brackets in 2009
	    if (i == 1) {
	      taxTables[i][0] = 16700;
	      taxTables[i][1] = 67900;
	      taxTables[i][2] = 137050;
	      taxTables[i][3] = 208850;
	      taxTables[i][4] = 372950;
	      taxTables[i][5] = 372951;
	    }
	    //Married Filing Separately max for brackets in 2009
	    if ( i == 2) {
	      taxTables[i][0] = 8350;
	      taxTables[i][1] = 33950;
	      taxTables[i][2] = 68525;
	      taxTables[i][3] = 104425;
	      taxTables[i][4] = 186475;
	      taxTables[i][5] = 186476;
	    }
	    //Head Of Household max for brackets in 2009
	    if ( i == 3) {
	      taxTables[i][0] = 11950;
	      taxTables[i][1] = 45500;
	      taxTables[i][2] = 117450;
	      taxTables[i][3] = 190200;
	      taxTables[i][4] = 372950;
	      taxTables[i][5] = 372951;
	    }
	  }  //end for
	  
	  filingStatus = Integer.parseInt(JOptionPane.showInputDialog("Type your filing status number as shown, or 4 to quit\r\n" + 
	      "0: Single Filer\r\n" + 
	      "1: Married Filing Jointly\r\n" + 
	      "2: Married Filing Separately\r\n" + 
	      "3: Head of Household\r\n" + 
	      "4: QUIT\r\n"));
	  if (filingStatus == 4) {
	    //4 = quit, so exit program
	    return;
	  }
	  //Get taxableIncome from user
	  taxableIncome = Double.parseDouble(JOptionPane.showInputDialog("Enter your taxable income"));
	  tax = 0.0;
	  
	  for (int j = maxRateBracket - 1; j > -1; --j) {
	    if (taxTables[filingStatus][j] > taxableIncome && j > 0) { //top tax bracket found
	      while ( j > 0)
	        tax += taxableIncome - taxTables[filingStatus][j-1] * taxRateForBracket[j]; //accumulate tax due
	    } //end if top tax bracket was found
	  else {  //taxableIncome is > top tax bracket
	      for (int k = 0; k < maxRateBracket - 1; k++) {
	        tax += taxRateForBracket[k] * taxTables[filingStatus][k];
	      } //end for
	    } //end else
	  } //end for
	}  //end main
}  //end class MaryClarkPA01Q2
