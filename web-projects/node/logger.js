//(function (exports, require, module, __filename, __dirname) {
//module wrapper function
const EventEmitter = require('events');  //events is a class
//const emitter = new EventEmitter();
//var url = 'http://mylogger.io/log';
//console.log(__filename);

class Logger extends EventEmitter {

    log(message) {
        console.log(message);
        //Raise an event (do second)
        //emitter.emit('messageLogged', 1, 'url');
        this.emit('messageLogged', {id: 1, url: 'http://localhost'});

        //Raise event 'Logging and send data: message
        this.emit('Logging', {data: 'message'});
    }
}
module.exports = Logger;
//module.exports = log; //export as a function
//module.exports.log = log; //export as an object
//module.exports.myurl = url;
//console.log(module);
//}) //IIFE Immediately invoked function expression