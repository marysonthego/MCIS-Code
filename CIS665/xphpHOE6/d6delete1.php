
<?php
/* 
    Purpose: Demo6 - CRUD Operations
    Author: LV
    Date: February 2019
*/

 include_once ("dbCRUDactions.php");

if ((isset($_GET['actorpk'])) && (is_numeric($_GET['actorpk'])))
{
    deleteActor((int)$_GET['actorpk']);
}

header("Location: index.php");
exit;

?>
