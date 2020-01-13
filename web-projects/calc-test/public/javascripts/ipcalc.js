
exports.validate = function (req, res, next) {
    console.log('in validate');
    let ipAddr = req.body.ipAddr;
    console.log('ipAddr = ' + ipAddr);
    let mask = req.body.mask;
    console.log('mask = ' + mask);
    res.send('OK');
};