<!DOCTYPE html>
<!--

CIS665 phpHOE2

By: Mary Clark

Date: 2/26/2019

Filename: phpHOE2.php


URL: http://cisweb.biz.colostate.edu/cis665/sp19clark.mclark59/phpHOE2/phpHOE2.php
-->
<html>
    <head>
        <meta charset="UTF-8">
        <title>Average Big Mac Country</title>
    </head>
    <body>
        <?php
        
            $bigMacCountry = array 
            ('South Africa' => '1.77',
            'United States' => '4.93',
            'Ukraine' => '1.54',
            'Australia' => '3.74',
            'China' => '2.72',
            'Denmark' => '4.32',
            'New Zealand' => '3.91',
            'Ireland' => '4.25',
            'United Kingdom' => '4.22',
            'Israel' => '4.29');
            
            $numCountries = count($bigMacCountry);

            
            $sum = 0;
            
            foreach ($bigMacCountry as $country => $price) {
                $sum += $price;
            }
                                   
             
            $average = $sum/$numCountries;
            
            
            printf("The average price of a Big Mac is \$%.2f\n",$average);
            $closest = 100;
            
            foreach ($bigMacCountry as $country => $price) {
                if (abs($average - $price) < $closest ) {
                    $closest = abs($average - $price);
                    
                    $closestCountry = $country;
                }
            }
            echo "<br></br>";
           printf ("The country closest to the average is %s\n",$closestCountry);
           printf ("The price in %s is \$%.2f", $closestCountry, $bigMacCountry[$closestCountry]);
            
        ?>
    </body>
</html>
