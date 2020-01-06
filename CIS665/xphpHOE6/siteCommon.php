<?php
   /* 
    Purpose: Methods to render Common Site Header and Footer
    Author: LV
    Date: January 2019
     */

function displayPageHeader($pageTitle)
{
   $output = <<<ABC
<!DOCTYPE html>
<html>
   <head>
      <meta charset="UTF-8" />
      <title>Mary Clark</title>
      <link rel="stylesheet" href="stylesCommon.css" type="text/css" />
   </head>

   <body>
      <header>
         <h2>$pageTitle</h2>
      </header>
ABC;
   echo $output;
}
   
function displayPageFooter()
{
   $year = date('Y');
   $output = <<<ABC
   <footer>
      <address>
         &copy; $year Mary Clark
      </address>
   </footer>  
  </body>
</html>
ABC;
   echo $output;
}

function displayAddResult ($nameFirst, $nameLast) {
    $output = <<<HTML
    <br /> <h3>$nameFirst $nameLast was successfully added.</h3>
HTML;
    echo $output;
}
?>