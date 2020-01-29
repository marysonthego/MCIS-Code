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
        const validationErrors = Object.keys(error.errors).map(key => error.errors[key].message);
        req.flash('validationErrors',validationErrors);
        req.flash('data',req.body);
        console.log('failed to create user');
        console.log(validationErrors);
        return res.redirect('/user/register');
      }
    })
  };
