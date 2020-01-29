
exports.validate = (req, res, next) => {
    console.log('in validate');
    let ipAddr = req.body.ipAddr;
    console.log('ipAddr = ' + ipAddr);
    setOctetsFromAddr(ipAddr);

    let mask = req.body.mask;
    console.log('mask = ' + mask);
    setOctetsFromAddr(mask);
    res.send('OK');
};

exports.setOctetsFromAddr = (addr) => {
    var octets = addr.split('.');

    for(const value in octets) {
        console.log('octet = ' + value);
    }
};