const EventEmitter = require('events');  

class Logger extends EventEmitter {

    log(message) {
        console.log(message);
        //Raise an event (do second)
        //Raise event 'Logging and send data: message
        this.emit('Logging', {data: 'message'});
    }
}
module.exports = Logger;