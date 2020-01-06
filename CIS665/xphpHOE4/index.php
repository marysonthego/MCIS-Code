<?php
 /* 
  * Actor Search Form
  * Filename: index.php
  * CIS665 phpHOE4
  * Link: http://cisweb.biz.colostate.edu/cis665/sp19clark.mclark59/phpHOE4/index.php
  * Author: Mary Clark
  * Date: 03/5/2019
  */

require_once "ActorData.php";

$actorData = ActorData::getActors();

echo <<< myHereDoc
    <head>
        <meta charset="UTF-8" />
        <title>Actor Search - Mary Clark</title>
        <link href="phpHOE4Structure.css" rel="stylesheet" />
        <link href="phpHOE4.css" rel="stylesheet" />
    </head>

    <header>
        <h1>Actor Search</h1>         
    </header>
  
    <div class="Search-Form">
      <form id="Search-Form" method="post" action="">
      <legend>Select your Search</legend>
      <label for="lastName">Search by Last Name</label>
      <input name="lastName" type="text" class="form-control">
      <br />
      <fieldset id="actorGender">
          <legend>Male or Female?</legend>
          <label for="male">Male</label>
          <input name="actorGender" id="male" value="M" type="radio"/>
          <label for="female">Female</label>
          <input name="actorGender" id="female" value="F" type="radio" checked/>
      </fieldset>
      <fieldset id="age">
          <legend>Who is oldest?</legend>
          <label for="age">List by Age</label>
          <input name="age" value="yes" type="checkbox"/>
      </fieldset>
      </form>
    </div>
      <input value="Search!" type="submit" class="form-submit"/> 
<div class="search-results">
 <legend>Search Results</legend> 
  <nav>
myHereDoc;

if (isset($lastName)){
    $actorData = ActorDate::getActorsByName($lastName);
    }
    elseif ($age == "yes") {
        $actorData = ActorData::getActorsByAge();
    }
        elseif (isset($actorGender)) {
            $actorData = ActorData::getActorByGender($actorGender);
        }
else {
    $actorData = ActorData::getActors();
}

foreach ($actorData as $actor)
  {
      $myLine = $actor->nameFirst . ' ' . $actor->nameLast . ' ' .  $actor->age . ' ' .  $actor->gender . '<br />';

$myOutput .= <<<myHereDoc2
    <ul>
     <li>'$myLine'</li>    
    </ul>
myHereDoc2;
  }
$myOutput .= <<<myHereDoc3
    </nav>
    </section>
'<footer>'
     CIS 665 &bull;
     phpHOE4 &bull;
     March 5, 2019 &bull;
     Mary Clark 
'</footer> </body>'
myHereDoc3;

 echo $myOutput;

?>