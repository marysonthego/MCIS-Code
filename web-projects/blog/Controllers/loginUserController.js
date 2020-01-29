const bcrypt = require('bcryptjs');
const User = require('../models/User');

module.exports = (req, res, next) => {
    const { username, password } = req.body;

    User.findOne({username:username}, (error,user) => {
      if (user){
        bcrypt.compare(password, user.password, (error, same) => {
          if(same) { // if passwords match
            // store user session
            req.session.userId = user.id;
            return res.redirect('/');
          }})}
      else{
            const validationErrors = Object.keys(error.errors).map(key => error.errors[key].message);
            req.flash('validationErrors',validationErrors);
            req.flash('data',req.body);
            console.log('Login error');
            return res.redirect('/user/login');
          }
      })
      };

