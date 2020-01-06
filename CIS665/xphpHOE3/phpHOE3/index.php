<!DOCTYPE html>
<!--
http://cisweb.biz.colostate.edu/cis665/sp19clark.mclark59/phpHOE3/index.php
-->
<html>
    <head>
        <meta charset="UTF-8">
        <title>Mary Clark phpHOE3</title>
    </head>
    <body>
        <?php
        require_once "dbConnExec.php";
        require_once "siteCommon.php";


// call the displayPageHeader method in siteCommon.php

displayPageHeader('Actor List');

echo '<section>';

$actorList = getActorList();

echo "<pre>"; 
print_r($actorList); echo "<br />";
echo "</pre>";

function getActorList()
{
    // the SQL query to be executed on the database

    $query = "Select nameFirst, nameLast, age, gender
            From actor
            Order by nameLast";
   
   // call the executeQuery method (in dbConnExec.php)
   // and return the result

   return executeQuery($query);
} 
// use a loop to display the results
/*
foreach ($actorList as $actor)
{
    echo $actor['movietitle'] . '<br />' ;
}
*/
echo '</section>';

// call the displayPageFooter method in siteCommon.php

displayPageFooter();

?>
        
        ?>
    </body>
</html>
