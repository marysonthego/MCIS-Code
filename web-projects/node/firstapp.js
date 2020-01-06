
const path = require('path'); //a built-in object
const os = require('os');
var totalMemory = os.totalmem();
var freeMemory = os.freemem();
//console.log('Total Memory ' + totalMemory);
//template string
//ES6 / ES2015 : ECMAScript 6
console.log(`Total Memory: ${totalMemory}`);
console.log(`Free Memory: ${freeMemory}`);
var pathObj = path.parse(__filename);
console.log(pathObj);

const fs = require('fs');
//const files = fs.readdirSync('./');
//console.log(files);
fs.readdir('./', function(err, files) {
    if (err) console.log('Error', err);
    else console.log('Files', files);
});
//console.log(files);

//const logger = require('./logger');
//console.log(logger);
//logger.log('a message');
//const log = require('./logger');
//log('a new message');
//logger = 1; // an error

//function sayHello(name) {
//    console.log('Hello ' + name);
//}

//sayHello('Me');

//global objects in javascript
//Use window object to access globals
//setTimeout();
//clearTimeout();
//setInterval();
//clearInterval();
// var's are in window the object in js but not in node
//var message = 'hi';

//globals in node
//Use the global object to access globals

//undefined
//global.console.log(global.message);

//modules are not global, they are scoped to their file
//console.log(module);



