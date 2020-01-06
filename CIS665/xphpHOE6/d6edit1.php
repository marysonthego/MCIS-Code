<?php
/*
    Purpose: Demo6 - CRUD Operations
    Author: LV
    Date: February 2019
    Uses: siteCommon.php, d6sql.php
    Action: d6edit1a.php
 */

require_once ("siteCommon.php");
require_once ("dbCRUDactions.php");

// declare and initialize Add/Edit flag variable

$editmode = false;

// if a numeric filmid was passed through the URL

if ((isset($_GET['actorpk'])) && (is_numeric($_GET['actorpk'])))
{
    // get the details for the movie to be edited
    
    $actordetails = getActorByPK((int)$_GET['actorpk']);
    
    // if movie details are returned for the filmid, set $editmode to true
    
    $editmode = (count($actordetails) == 1);
}

// if mode is $editmode is true

if ($editmode)
{
   extract ($actordetails[0]);

    $formtitle = 'Update an Actor';
    $buttontext = 'Update';
 }
else  //otherwise, set the column variables to ""
{
    $nameLast = '';
    $nameFirst = '';
    $age = '';
    $gender = '';
    $actorAgent = '';

    $formtitle = 'Add an Actor';
    $buttontext = 'Add';
}

// call the displayPageHeader method in siteCommon.php

displayPageHeader($formtitle);
?>

<script src="d6jsLibrary.js" type="text/javascript"></script>

<form name ="addEditForm" id="addEditForm" action="d6edit1a.php" method="post" onsubmit="return checkForm(this)">

<?php
    if ($editmode)  //put the filmpk in a hidden field
    {
        echo '<input type="hidden" name="actorpk" value="' . $actorpk . '" />';
    }
?>

<label for="nameFirst">First Name:</label>   
   <input type="text" name="nameFirst" id="nameFirst" maxlength="20" value="<?php echo $nameFirst; ?>" autofocus required pattern="^[A-Z][a-z]{1,19}$" title="Invalid characters. Only a to z are allowed with first character capitalized." />
   <label for="nameLast">Last Name:</label>         
   <input type="text" name="nameLast" id="nameLast" maxlength="20" value="<?php echo $nameLast; ?>" required pattern="^[A-Z][a-z]{1,19}$" title="Invalid characters. Only a to z are allowed with first character capitalized." />
   <label for="age">Age:</label>
   <input type="number" name="age" id="age" maxlength="3" value="<?php echo $age; ?>" required min="0" max="130" title="Age is invalid" />
  
   <label for="gender">Gender:</label>
   <input name="gender" id="gender" maxlength="1" value="<?php echo $gender; ?>" required pattern="^[MF]$" title="Gender must be M or F" />
   <label for="actorAgent">Agent:</label>        
   <input type="text" name="actorAgent" id="actorAgent" maxlength="40" value="<?php echo $actorAgent; ?>" required pattern="^[A-Z][a-z]{1,19} [A-Z][a-z]{1,19}$" title="Actor Agent contains invalid characters. Capitalize First and Last names with one space between." />
   <p>
   <input type="submit" value="<?php echo $buttontext ?>" />
   <a href="index.php">Cancel</a>
   </p>
</form>

<?php
//if (isset($_POST['submit'])) {
//if (addEditForm) {
//  displayAddResult($nameFirst, $nameLast);
//}

// call the displayPageFooter method in siteCommon.php

displayPageFooter();
?>