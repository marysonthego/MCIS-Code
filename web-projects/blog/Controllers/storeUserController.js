const User = require('../models/User');
const path = require('path');

module.exports = async (req,res,next) => {
  await User.create(req.body, (error, user) => {
    if(error) {
      console.log(error);
      return res.redirect('/user/register');
    }
    res.redirect('/');
  });
};