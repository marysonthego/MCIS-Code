
public class Validation {

  // Return true if the card number is valid, otherwise returns false, this method is already implemented
  public boolean aValidNumber(String n) {

	long number = Long.parseLong(n);
	return (numLength(number) >= 13) && (numLength(number) <= 16)
			&& (prefixCheck(number, 4) || prefixCheck(number, 5) || prefixCheck(number, 6)
					|| prefixCheck(number, 37) || prefixCheck(number, 34))
			&& (totalEevenNumbers(number) + totalOddNumbers(number)) % 10 == 0;
  }// end of aValidNumber method

  //get the sum of even places numbers, Starting from the second digit from right
  private int totalEevenNumbers(long number) {
      String strNum = Long.toUnsignedString(number);
      int sum = 0;
      int length = strNum.length();
      
      for (int i = length-2; i>=0; i-=2) {
          char c = strNum.charAt(i);
          int digit = Character.digit(c,10);
          sum += singleDigit(digit);
          if (i == 1)
              break;
      }
	  return sum;
  }// end of totalEevenNumbers method

  // Return the same number if it is a single digit, otherwise, return the sum of
  // the two digits in this number
  private int singleDigit(int digit) {
      int dbl = 0;
      if ((dbl = digit * 2) > 9) //subtract 9 from 2 digit number to get their digit sum
          dbl -=9;
    return dbl;
  } // end of singleDigit method

  // Return the sum of odd place digits in number
  private int totalOddNumbers(long number) {
      String strNum = Long.toUnsignedString(number);
      int sum = 0;
      int length = strNum.length();
      
      for (int i = length-1; i>=0; i-=2) {
          char c = strNum.charAt(i);
          sum += Character.digit(c,10);
          if (i == 1)
              break;
      }
      return sum;
  }// end of totalOddNumbers method

  // Return true if the digit d is a prefix for number
  private boolean prefixCheck(long number, int d) {
		int length = Integer.toString(d).length();
		int first = Integer.parseInt(Long.toString(number).substring(0, length));
		return first == d;
  }// end of prefixCheck method

  // Return the number of digits in this number parameter
  private int numLength(long number) {
    return ("" + number).length();
  }// end of numLength method

  // Return the first k number of digits from number, which is either a first digit or first two digits
  // Depending on the card type
  private long numPrefix(long number, int k) {
      String strNum = Long.toUnsignedString(number);
      strNum = strNum.substring(0,k-1);
      return Long.parseLong(strNum);
  }// end of numPrefix method

}// end of the class
