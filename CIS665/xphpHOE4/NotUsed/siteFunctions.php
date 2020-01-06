<?php
    require_once "dbConnExec.php";
    
    if(isset($_POST['lastName'])) {
        $lastName = ($_POST['lastName']);
        //if(!is_string('lastName')) {
            $actorList = getActorList();

    }
 
/*
 * echo "<pre>"; 
print_r($actorList); echo "<br />";
echo "</pre>";
    
function sanitizeString($var) {
    $var = stripslashes($var);
    $var = strip_tags($var);$var;
    $var = htmlentities($var);
    return $var;
}
*/
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

?>
 