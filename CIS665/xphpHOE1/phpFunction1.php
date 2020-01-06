<?php
/*
 * CIS665 phpHOE1 
 * 
 * By: Mary Clark
 * 
 * Date: 2/19/2019
 *
 * Filename: phpFunction1.php
 *
 * URL: http://cisweb.biz.colostate.edu/cis665/sp19clark.mclark59/phpHOE1/index.php
 * 
 * accept a string as a parameter.
 * If the length of the string parameter is an even number, 
 *   concatenate your last name to the first three characters of the string parameter, 
 * else, 
 *   if the length of the string parameter is odd, 
 * concatenate your first name to the last three characters of the string parameter
 * return the concatenated string.
 * 
 * if the length of the string parameter is an even number, concatenate your 
 * last name to the first three characters of the string parameter
 */

function phpFunction1($inputString) {
  $first = "Mary";
  $last = "Clark";
  $var1 = strlen($inputString);
  echo "String Length is: ".$var1;
  echo "<br>";
  
  If ($var1 % 2)  { //length is odd
    return $var2=$first.substr($inputString,$var1-3,3);
  }
  else {  //length is even
    return $var2=$last.substr($inputString,0,3);
  }
}
?>

