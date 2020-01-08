
const zeros = "00000000";
var inIpStr = "";
var ipClass = "";
var ipRoute = "";
var ipClassMaskStr = "";
var ipClassSlash = "";
var intIpArray = [0, 0, 0, 0];
var binIpStrArray = ['0', '0', '0', '0'];
var byteIpArray = [0b0, 0b0, 0b0, 0b0];
var intClassMaskArray = [0, 0, 0, 0];
var binClassMaskStrArray = ['0', '0', '0', '0'];
var byteClassMaskArray = [0b0, 0b0, 0b0, 0b0];

import EventEmitter from 'events';  
//events is a class

import Logger from './logger';
const logger = new Logger();

logger.on('Logging', (arg) => {
    console.log('log: ', arg);
});

//Call logger (do second)
logger.log('Logger message');

function getInputIp() {
    inIpStr = console.readLine("%nEnter an IP Address: ");
    if (validateInputIp(inIpStr)) {
        setIntOctetsFromStr(inIpStr);
        setBinaryIpOctetStrFromInt();
        setClass();
    } else
        console.format("%nIP Address %s is invalid",inIpStr);        
}

function setBinaryClassMaskStrFromInt() {
    let i = 0;
    let leadingZeros = 0;
    let octet = ipClassMaskStr.split("[.]");   
    for(let x in octet) { 
        intClassMaskArray[i] = +x;             
        i++;
    }
    i = 0;
    for(let x in intClassMaskArray) {
        resultStr.setLength(0);
        let binStr = x.toString(2);
        let leadingZeros = Math.clz32(x) - 24;
        let leader = zeros.substring(0, leadingZeros);
        resultStr = resultStr.insert(0,leader);
        resultStr = resultStr.append(binStr);
        binClassMaskStrArray[i] = resultStr.substring(0);
        logger.log("%nClass Mask +x at position +i = +binClassMaskStrArray[i]");
        byteClassMaskArray[i] = Integer.valueOf(x).byteValue();
        i++;
    }
    logger.log("%nipClass = %s %nipClassMask = %s %nipClassSlash = %s %nipRoute = %s",ipClass, ipClassMaskStr, ipClassSlash, ipRoute);
}