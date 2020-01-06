<!DOCTYPE html>
<!--

CIS665 phpHOE1 

By: Mary Clark

Date: 2/19/2019

Filename: index.php

This php file uses phpFunction1.php to manipulate strings.

URL: http://cisweb.biz.colostate.edu/cis665/sp19clark.mclark59/phpHOE1/index.php
-->
<html>
    <head>
        <meta charset="UTF-8"/>
        <title>phpHOE1</title>
     </head>
     <body>
          <?php
            include 'phpFunction1.php';
            
            // Assign a string literal (that has a minimum of 10 characters) 
            // to a variable ($var1)
            
            $var1="This is a string literal longer than 10 characters";
            echo 'var1 = '.$var1;
            echo "<br>";
        
            //Concatenate the first three characters and the last three characters of $var1 
            //(use the substr() function) and assign to another variable ($var2)
                
            $varLength = strlen($var1);
            $var2=substr($var1,0,3).substr($var1,$varLength-3,3);
            echo '$var2 = '.$var2;
            echo"<br>";
            
            $evenVar = "Is  even";
            $oddVar = "Is  odd";
            
            echo '$oddVar returned: '.phpFunction1($oddVar);
            echo "<br>";
            echo '$evenVar returned: '.phpFunction1($evenVar);
            echo "<br>";
            
            /* Assign a string literal with 10 characters to a variable ($var3)
             * Display $var3 */
            $var3 = "0123456789";
            echo '$var3 = '.$var3;
            echo "<br>";
             
            /* Call the function (that you created for step 2), passing $var3 
             * as the argument. Display the returned result. */
            echo '$var3 returned: '.phpFunction1($var3);
            echo "<br>";
            
             /* Assign a string literal with 13 characters to a variable ($var4)
             * Display $var4 */
             $var4 = "0123456789ABC";
             echo '$var4 = '.$var4;
             echo "<br>";
             
             /* Call the function (that you created for step 2), passing $var4 
             * as the argument. 
             * Display the returned result. */
             echo '$var4 returned: '.phpFunction1($var4);
             echo "<br>";
        ?>      
    </body>
</html>