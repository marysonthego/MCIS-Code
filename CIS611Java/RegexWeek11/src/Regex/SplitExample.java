package Regex;

public class SplitExample {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		String input = "55.5 77.7 88.9 90.2";
		String[] splitStr = input.split(" ");
		double[] scores = new double[splitStr.length];
		for (int i =0; i<splitStr.length; i++){
			scores[i] = Double.parseDouble(splitStr[i]);
			System.out.println(scores[i]);
		}
	}
}
