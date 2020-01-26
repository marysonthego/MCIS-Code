const User = require('../models/User');
const path = require('path');

module.exports = (req,res,next) => {
  User.create({
    username: req.body.username,
    password: req.body.password,
    datecreated: new Date() },
    (error, user) => {
      if(!error) {
        console.log('user created successfully');
        console.log(user);
        res.redirect('/');
      } else {
        console.log('failed to create user');
        console.log(error);
        res.redirect('/user/register');
      }
    })
  };
