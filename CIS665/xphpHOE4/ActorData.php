<?php
    require_once 'TableData.php';

/*
    Purpose: Demo3 Alt - Film Data Class
    Author: LV
    Date: February 2019
 */
class ActorData extends TableData
{

    protected $rowData = array('actorpk' => "", 'nameFirst' => "", 'nameLast' => "", 'age' => "", 'gender' => "");
    
    public static function getActors()
    {
        $query = "Select actorpk, nameFirst, nameLast, age, gender from actor order by namelast";
        return self::execQuery($query);
    }
    
    public static function getActorByLastName($lastName)
    {
    // the SQL query to be executed on the database
    $name=$_POST['lastName'];
    $query = "Select actorpk, nameFirst, nameLast, age, gender
		From actor
                Where contains (nameLast, $name)";
    return self::execQuery($query);
    }
    
    public static function getActorByAge()
    {
    // the SQL query to be executed on the database
    
    $query = "Select actorpk, nameFirst, nameLast, age, gender
		From actor
                Order By age DESC";
    return self::execQuery($query);
    }
    
    public static function getActorByGender($actorGender)
    {
    // the SQL query to be executed on the database
    
    $query = "Select actorpk, nameFirst, nameLast, age, gender
		From actor
                Order By nameLast ASC 
                where gender = $actorGender";
    return self::execQuery($query);
    }
    
    private static function execQuery($query)
    {
        $conn = parent::dbConnect();
        try 
        {
            $stmt = $conn->query($query);
            $actors = array();
            foreach ($stmt->fetchAll((PDO::FETCH_ASSOC)) as $row)
            {
                $actors[] = new ActorData($row);
            }

// the fetchObject method fetchs the next row/record in the result set, returns it as a FilmData object, and sets the object's properties from corresponding column values.
// if this method is used, a constructor that just initializes properties would not be needed

//            while ($film = $stmt->fetchObject(__CLASS__))
//            {
//                $films[] = $film;
//            }
            
            parent::dbDisconnect($conn);
            return $actors;
        } 
        catch (PDOException $ex)
        {
            parent::dbDisconnect($conn);
            die('Query failed: ' . $ex->getMessage());
        }
    }
    
    public function checkImageFile()
    {
        $fileName = "../images/f$this->actorpk.gif";
    
        return file_exists($fileName);
    }
}