public class Validation {

	// DONE | HAD TO BE EDITTED TO INCLUDE CARDS STARTING WITH 34
	// Return true if the card number is valid, otherwise returns false,
	// this method is already implemented
	public boolean aValidNumber(String n) {

		long number = Long.parseLong(n);
		return (numLength(number) >= 13) && (numLength(number) <= 16)
				&& (prefixCheck(number, 4) || prefixCheck(number, 5) || prefixCheck(number, 6)
						|| prefixCheck(number, 37) || prefixCheck(number, 34))
				&& (totalEevenNumbers(number) + totalOddNumbers(number)) % 10 == 0;
	}// end of aValidNumber method

	// DONE | THIS DESCRIPTION IS WRONG. get the sum of even places numbers,
	// starting
	// from the second digit from right
	private int totalEevenNumbers(long number) {
		int output = 0;
		String temp = Long.toString(number);
		boolean toggle = false;
		for (int i = temp.length() - 1; i >= 0; i--) {
			if (toggle) {
				output += singleDigit(Integer.parseInt(temp.substring(i, i + 1)) * 2);
			}
			toggle = !toggle;
		}
		return output;
	}// end of totalEevenNumbers method

	// DONE | Return the sum of odd place digits in number
	private int totalOddNumbers(long number) {
		int output = 0;
		String temp = Long.toString(number);
		boolean toggle = true;
		for (int i = temp.length() - 1; i >= 0; i--) {
			if (toggle) {
				output += Integer.parseInt(temp.substring(i, i + 1));
			}
			toggle = !toggle;
		}
		return output;
	}// end of totalOddNumbers method

	// DONE | Return the same number if it is a single digit, otherwise, return the
	// sum of the two digits in this number
	private int singleDigit(int number) {
		String temp = Integer.toString(number);
		if (temp.length() > 1) {
			int output = 0;
			for (int i = 0; i < temp.length(); i++) {
				output += Integer.parseInt(temp.substring(i, i + 1));
			}
			number = output;
		}
		return number;
	} // end of singleDigit method

	// DONE | Return true if the digit d is a prefix for number
	private boolean prefixCheck(long number, int d) {
		int length = Integer.toString(d).length();
		int first = Integer.parseInt(Long.toString(number).substring(0, length));
		return first == d;
	}// end of prefixCheck method

	// DONE | Return the number of digits in this number parameter
	private int numLength(long number) {
		return Long.toString(number).length();
	}// end of numLength method

	// DONE | ALSO NOT NECESSARY - Return the first k number of digits from number,
	// which is either a first digit or first two digits depending on the card
	// type
	private long numPrefix(long number, int k) {
		int length = Integer.toString(k).length();
		long val = Long.parseLong(Long.toString(number).substring(0, length));
		return val;
	}// end of numPrefix method

}// end of the class
