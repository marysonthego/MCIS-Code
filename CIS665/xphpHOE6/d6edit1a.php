<?php
/* 
    Purpose: Demo6 - CRUD Operations
    Author: LV
    Date: February 2019
    Action for: d6edit1.php
    Uses: d6Sql.php
 */

require_once ("dbCRUDactions.php");

// if $_POST has a filmpk element, call the update method

if (isset($_POST['actorpk']))
{
    updateActor((int)$_POST['actorpk'], $_POST['nameFirst'], $_POST['nameLast'], (int)$_POST['age'], $_POST['gender'],
             $_POST['actorAgent']);
}
else 
{
    addActor($_POST['nameLast'], $_POST['nameFirst'], (int)$_POST['age'],$_POST['gender'], 
             $_POST['actorAgent']); 

}

header("Location: index.php");
exit;

?>
