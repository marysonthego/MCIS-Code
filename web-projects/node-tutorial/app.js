
var person;
person = {
    firstName: "Bucky",
    lastName: "Roberts",
    age: 45
};
console.log("string representation", person);

function addNumber(a, b) {
    return (a + b);
}
console.log("function result", addNumber(7,3));

var printBacon = function() {
    console.log("console.log inside printBacon Bacon, Bacon, Bacon!");
    return ("return value from printBacon Hi!");
}

console.log("call function, get return value", printBacon());
console.log("printBacon() is next");
printBacon();

setTimeout(printBacon,2000);

function placeAnOrder(orderNumber) {
    console.log("Customer order:", orderNumber);
    //callback fires on return from callDB
    callDB(function () {
        console.log("Delivered order", orderNumber)
    });
}

//Simulate a 5 second operation
function callDB(callback) {
    setTimeout(callback, 2000);
};

//Simulate a web request
placeAnOrder(1);
placeAnOrder(2);
placeAnOrder(3);
placeAnOrder(4);

var myVar = {
    favFood: "bacon",
    favMovie: "Chappie"
};

var aVar = myVar;
aVar.favFood = 'Salad';
console.log(myVar.favFood);
//aVar is a reference to myVar

console.log(19 == '19');  //true because it only compares the values
console.log(19 === '19'); //false because you're comparing values and types

//this refers to the thing that called it
var Bucky = {
    printFirstName: function() {
        console.log("My name is Bucky");
        console.log(this === Bucky); //true
    }
};
Bucky.printFirstName();

//the default calling context is global
function doSomething() {
    console.log("\nDoing Something");
    console.log(this === Bucky); //false
    console.log(this === global);/ //true
};

doSomething();

//prototyping
function User() {
    this.name = "";
    this.life = 100;
    this.giveLife = function giveLife(targetPlayer) {
      targetPlayer.life += 1;
      console.log(this.name + " gave 1 life to " + targetPlayer.name);
    }
}

var Bucky = new User();
var Wendy = new User();

Bucky.name = "Bucky";
Wendy.name = "Wendy";

Bucky.giveLife(Wendy);
console.log("Bucky:" + Bucky.life);
console.log("Wendy:" + Wendy.life);

//prototype can add new functions to all objects
User.prototype.uppercut = function uppercut(targetPlayer) {
    targetPlayer.life -= 3;
    console.log(this.name + " Uppercut to " + targetPlayer.name);
}

Wendy.uppercut(Bucky);
console.log("Bucky: " + Bucky.life);
console.log("Wendy: " + Wendy.life);

//prototype can add new properties to all objects
User.prototype.magic = 60;
console.log("Bucky: " + Bucky.magic);
console.log("Wendy: " + Wendy.magic);

var movies = require("./movies");
movies.printAvatar();
movies.printChappie();
console.log(movies.favMovie);