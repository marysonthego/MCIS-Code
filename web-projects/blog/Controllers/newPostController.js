module.exports = (req, res, next) => {
    if(req.session.userId) {
        return res.render('create');
    } else
        res.redirect('/user/login');
};

