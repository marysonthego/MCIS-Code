<?php
/*
    Purpose: Demo6 - Sql methods to access and update the RWStudios Database
    Author: LV
    Date: February 2019
    Uses: dbConnExec.php
 */

require_once 'dbConnExec.php';

function addActor($nameLast, $nameFirst, $age, $gender, $actorAgent)
{
    // escape single quotes within the string (e.g., "Schindler's List" is escaped as "Schindler''s List" 
    
    $nameLast = str_replace('\'', '\'\'', trim($nameLast));
    $nameFirst = str_replace('\'', '\'\'', trim($nameFirst));
    $actorAgent = str_replace('\'', '\'\'', trim($actorAgent));
    $gender = trim($gender);
    
    $query = <<<HTML
    Insert into actor(nameLast,nameFirst,age,gender,actorAgent)
        Values('$nameLast','$nameFirst','$age','$gender','$actorAgent')
HTML;

    return executeQuery($query);
}

 function getActorsByAgent()
{
    $query = <<<HTML
        Select (actorPK, nameFirst, nameLast, age, gender, actorAgent) 
            from Actor 
                order by actorAgent
HTML;
    return executeQuery($query);
}

function getActorsByName()
{
    $query = <<<HTML
        Select actorPK, nameFirst, nameLast, age, gender, actorAgent
            From Actor
                where len(nameLast) > 0
                Order by nameLast
HTML;
    return executeQuery($query);
}

function getActorByPK($actorPK)
{
   $query = <<<HTML
       Select actorPK, nameFirst, nameLast, age, gender,actorAgent
           From actor
                Where actorPK = '$actorPK'
HTML;
    return executeQuery($query);
}

function updateActor($actorPK, $nameFirst, $nameLast, $age, $gender, $actorAgent)
{
        $nameLast = str_replace('\'', '\'\'', trim($nameLast));
        $nameFirst = str_replace('\'', '\'\'', trim($nameFirst));
        $actorAgent = str_replace('\'', '\'\'', trim($actorAgent));
        $gender = trim($gender);

        $query = <<<HTML
        Update actor
            Set  nameLast = '$nameLast', nameFirst = '$nameFirst', age = '$age', gender = '$gender', actorAgent = '$actorAgent'
                Where actorpk = '$actorPK'
HTML;

    return executeQuery($query);
}

function deleteActor($actorPK)
{
    $query = <<<HTML
    Delete
        From actor
            Where actorpk = $actorPK
HTML;

    return executeQuery($query);
}

?>
