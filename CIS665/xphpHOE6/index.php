<?php

// http://cisweb.biz.colostate.edu/cis665/sp19clark.mclark59/phpHOE6/index.php
    
require_once ("siteCommon.php");
require_once ("dbCRUDactions.php");

displayPageHeader("Add/Edit/Delete an Actor");

$actorList = getActorsForAgent($actorAgent = "Mary Clark");  //get the list of actors

$output = <<<HTML
<section><table id="allActors">
    <table>
        <tr>
            <th>First Name</th>
            <th>Last Name</th>
            <th>Gender</th>
            <th>Age</th>
            <th>Agent</th>
            <th> </th>
            <th> </th>
        </tr>
HTML;

// display each actor whose last name is longer than 0 characters

foreach ($actorList as $actor)
{
    extract($actor, EXTR_PREFIX_ALL, "actorList");
    $output .= <<<HTML
    <tr>
        <td>
            $actorList_nameFirst 
        </td>
        <td>
            $actorList_nameLast
        </td>
        <td>
            $actorList_gender
        </td>
        <td>
            $actorList_age
        </td>
        <td>
            $actorList_actorAgent
        </td>
        <td>
            <a href="d6edit1.php?actorpk=$actorList_actorpk">[Edit]</a>
        </td>
        <td>
            <a href="d6delete1.php?actorpk=$actorList_actorpk">[Delete]</a>
        </td>
    </tr>
HTML;
}

$output .= <<<HTML
    <tr>
        <td colspan="7" align="center">
            <a href="d6edit1.php">[Add an Actor]</a>
        </td>
    </tr>
</table></section>
HTML;

echo $output;

// call the displayPageFooter method in siteCommon.php

displayPageFooter();
?>

