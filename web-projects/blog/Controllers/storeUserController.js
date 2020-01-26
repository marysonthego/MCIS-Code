const User = require('../models/User');
const path = require('path');
//const bcrypt = require('bcryptjs');

module.exports = (req,res,next) => {
  //const { username, password } = req.body;
  //User.create(req.body,{
  var user = User.create(
  //var user = User.create(req.body,
    {
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
