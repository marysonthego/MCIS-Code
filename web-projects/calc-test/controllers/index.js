
//handler for index route
exports.index = function(req, res, next) {
    res.render('index', { title: 'Subnet Calculator' });
};
/* res.render ('html page name in views directory', { js key value pairs } */