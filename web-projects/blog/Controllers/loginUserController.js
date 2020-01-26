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
            res.redirect('/');
          }
          else{
            res.redirect('/user/login');
          }
        });
      }
      else{
        res.redirect('/user/login');
      }
    });
};