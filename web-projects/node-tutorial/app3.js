var fs = require('fs');

fs.writeFileSync('corny.txt', "Corn is great.");
console.log(fs.readFileSync("corny.txt").toString());

var path = require('path');
var websiteHome = "Desktop/Bucky//thenewboston/home.html";

console.log(path.normalize(websiteHome));
console.log(path.dirname(websiteHome));
console.log(path.basename(websiteHome));
console.log(path.extname(websiteHome));

setInterval( () => {
    console.log("beef");
}, 2000);

console.log(__dirname);
console.log(__filename);
