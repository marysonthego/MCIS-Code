var person;
person = {
    firstName: "Bucky",
    lastName: "Roberts",
    age: 45
};
console.log(person);

function addNumber(a, b) {
    return (a + b);
}
console.log(addNumber(7,3));

var printBacon = function() {
    console.log("Bacon, Bacon, Bacon!");
    return ("Hi!");
}

console.log(printBacon());
printBacon();

setTimeout(printBacon,2000);