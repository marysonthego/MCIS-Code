
//*********************************************************************
//*                                                                   *
//*  CIS611                  Spring, 2019             Mary Clark      *
//*                                                                   *
//*                     Program Assignment PA04                       *
//*                                                                   *
//*                     Class Description                             *
//* Java class Password                                               *
//*                                                                   *
//* main() prompts the user to enter a password in a dialog box.      *
//* main() calls isValidPassword() to validate the password based on  *                                         *
//* the following rules:                                              *
//* A password must have at least eight characters.                   *
//* A password consists of any sequence of letters and digits,        *
//* as well as at least one special characters. Test for only         *
//* these three special characters, %, &, #.                          *
//* You are not required to code to account for any other special     *
//* character.                                                        *
//* A password must contain at least two digits.                      *
//* isValidPassword() returns true if the password is valid,          *
//* false if the password is invalid                                  *
//* based on the return value of isValidPassword, main() displays the *
//* result in another dialog box.                                     *
//* The program continues to prompt the user for a password until     *
//* the user clicks the Cancel button in the password prompt box.     *
//*                                                                   *
//*  Date Created: 02/25/2019                                         *
//*                                                                   *
//*  Saved in: Password.java                                          *
//*                                                                   *
//*********************************************************************

import javax.swing.JOptionPane;

/**
* @author Mary Clark
*
*/

public class Password {

    public static void main(String[] args) {

        JOptionPane myPane = new JOptionPane();
        String newPass = "          ";
        
        // Exit when user presses Cancel
        while (newPass != null) {
            newPass = JOptionPane.showInputDialog(myPane, "Enter a string for password", 
                    "Password", JOptionPane.OK_CANCEL_OPTION);
            
            if (newPass == null) { // User pressed Cancel
                break;
            } else {
                if (isValidPassword(newPass)) //Test password
                    JOptionPane.showMessageDialog(myPane.getTopLevelAncestor(),"Valid Password");
                else
                    JOptionPane.showMessageDialog(myPane.getTopLevelAncestor(),"Invalid Password");
            }
        }
        System.exit(0);
    }

    public static boolean isValidPassword(String s) {
        int digitCount = 0;
        
        if (s.length() < 8) { // too short
            return false;
        } else {
            if (s.contains("%") || s.contains("&") || s.contains("#")) { // must contain at least one % & #
                for (int i=0; i < s.length(); i++)
                {
                    if (Character.isDigit(s.charAt(i)))  // must contain at least 2 digits
                            digitCount++;
                }
                if ( digitCount > 1)
                    return true;
            } 
        } 
        return false;
    }
}
