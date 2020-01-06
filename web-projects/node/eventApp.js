const EventEmitter = require('events');  //events is a class
//const emitter = new EventEmitter();
const Logger = require('./logger');
const logger = new Logger();

//Register a listener (do first)
logger.on('messageLogged', (arg) => { // (arg) => {...} === function(arg) {...}
    console.log('Listener called', arg);
});

logger.on('Logging', (arg) => {
    console.log('Listener for Logging called', arg);
});

//Call logger (do second)
logger.log('Logger message');