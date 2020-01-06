import javax.swing.JOptionPane;

public class Input {

	public static void main(String[] args) {
		String num = "1";
		System.out.println(isLong(num));
	}

	public static int readInt(String msg) {
		String temp = "";
		int val;
		boolean endLoop = false;
		while (!endLoop) {
			temp = JOptionPane.showInputDialog(msg);
			if (temp == null) {
				if (JOptionPane.showConfirmDialog(null, "Input cancelled. Exit program?", null,
						JOptionPane.YES_NO_OPTION) == 0) {
					System.exit(0);
				}
			} else if (temp.trim().isEmpty()) {
				JOptionPane.showMessageDialog(null, "Value cannot be blank. Please enter a new value.");
			}  else if (!Input.isInt(temp)) {
				JOptionPane.showMessageDialog(null, "Value must be an integer. Please enter a new value.");
			} else {
				endLoop = true;
			}
		}
		val = Integer.parseInt(temp);
		return val;
	}

	public static double readDouble(String msg) {
		String temp = "";
		double val;
		boolean endLoop = false;
		while (!endLoop) {
			temp = JOptionPane.showInputDialog(msg);
			if (temp == null) {
				if (JOptionPane.showConfirmDialog(null, "Input cancelled. Exit program?", null,
						JOptionPane.YES_NO_OPTION) == 0) {
					System.exit(0);
				}
			} else if (temp.trim().isEmpty()) {
				JOptionPane.showMessageDialog(null, "Value cannot be blank. Please enter a new value.");
			}
//			else if (temp.equals("0")) {
//				JOptionPane.showMessageDialog(null, "Value cannot be 0. Please enter a new value.");
//			} 
			else if (!Input.isDouble(temp)) {
				JOptionPane.showMessageDialog(null, "Value must be numeric. Please enter a new value.");
			} else {
				endLoop = true;
			}
		}
		val = Double.parseDouble(temp);
		return val;
	}

	public static long readLong(String msg) {
		String temp = "";
		long val;
		boolean endLoop = false;
		Validation v = new Validation();
		while (!endLoop) {
			temp = JOptionPane.showInputDialog(msg);
			if (temp == null) {
				if (JOptionPane.showConfirmDialog(null, "Input cancelled. Exit program?", null,
						JOptionPane.YES_NO_OPTION) == 0) {
					System.exit(0);
				}
			} else if (temp.trim().isEmpty()) {
				JOptionPane.showMessageDialog(null, "Value cannot be blank. Please enter a new value.");
			} else if (!Input.isLong(temp)) {
				JOptionPane.showMessageDialog(null, "Value must be an number. Please enter a new value.");
			} else if (!v.aValidNumber(temp)) {
				if (JOptionPane.showConfirmDialog(null, "The number entered is not a valid credit card number.\nYes: Enter a new number\nNo: Cancel this customer's transaction.", null,
						JOptionPane.YES_NO_OPTION) == 1) {
					endLoop = true;
					temp = "0";
				}
			} else {
				endLoop = true;
			}
		}
		val = Long.parseLong(temp);
		return val;
	}

	public static String readStr(String msg) {
		String temp = "";
		boolean endLoop = false;
		while (!endLoop) {
			temp = JOptionPane.showInputDialog(msg);
			if (temp == null) {
				if (JOptionPane.showConfirmDialog(null, "Input cancelled. Exit program?", null,
						JOptionPane.YES_NO_OPTION) == 0) {
					System.exit(0);
				}
			} else if (temp.trim().isEmpty()) {
				JOptionPane.showMessageDialog(null, "Value cannot be blank. Please enter a new value.");
			} else {
				endLoop = true;
			}
		}
		return temp;
	}

	public static boolean isDouble(String str) {
		try {
			Double.parseDouble(str);
		} catch (Exception e) {
			return false;
		}
		return true;
	}

	public static boolean isInt(String str) {
		try {
			Integer.parseInt(str);
		} catch (Exception e) {
			return false;
		}
		return true;
	}

	public static boolean isLong(String str) {
		try {
			Long.parseLong(str);
		} catch (Exception e) {
			return false;
		}
		return true;
	}

}