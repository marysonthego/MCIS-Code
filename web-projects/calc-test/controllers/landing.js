
//handler for landing route
exports.getLanding = function(req, res, next) {
    res.render('landing', { title: 'Subnet Calculator' });
};
/* res.render ('html page name in views directory', { js key value pairs } */