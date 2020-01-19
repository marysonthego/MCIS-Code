var BlogPost = require('../models/BlogPost');

module.exports = async (req, res, next) => {
  var blogposts = await BlogPost.find({});
  res.render('index', {
    blogposts: blogposts
  });
};