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
        Select actorpk, nameFirst, nameLast, age, gender, actorAgent
            from Actor 
                order by actorAgent
HTML;
    return executeQuery($query);
}

 function getActorsForAgent($actorAgent)
{
    $query = <<<HTML
        Select actorpk, nameFirst, nameLast, age, gender, actorAgent
            from Actor 
                where actorAgent = '$actorAgent'
HTML;
    return executeQuery($query);
}

function getActorsByName()
{
    $query = <<<HTML
        Select actorpk, nameFirst, nameLast, age, gender, actorAgent
            From Actor
                where len(nameLast) > 0
                Order by nameLast
HTML;
    return executeQuery($query);
}

function getActorByPK($actorpk)
{
   $query = <<<HTML
       Select actorpk, nameFirst, nameLast, age, gender, actorAgent
           From actor
                Where actorpk = '$actorpk'
HTML;
    return executeQuery($query);
}

function updateActor($actorpk, $nameFirst, $nameLast, $age, $gender, $actorAgent)
{
        $nameLast = str_replace('\'', '\'\'', trim($nameLast));
        $nameFirst = str_replace('\'', '\'\'', trim($nameFirst));
        $actorAgent = str_replace('\'', '\'\'', trim($actorAgent));
        $gender = trim($gender);

        $query = <<<HTML
        Update actor
            Set  nameLast = '$nameLast', nameFirst = '$nameFirst', age = '$age', gender = '$gender', actorAgent = '$actorAgent'
                Where actorpk = '$actorpk'
HTML;

    return executeQuery($query);
}

function deleteActor($actorpk)
{
    $query = <<<HTML
    Delete
        From actor
            Where actorpk = $actorpk
HTML;

    return executeQuery($query);
}

?>
