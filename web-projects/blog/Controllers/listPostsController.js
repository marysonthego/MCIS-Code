var BlogPost = require('../models/BlogPost');

module.exports = async (req, res, next) => {
  console.log('in listPostsController');
  var blogposts = await BlogPost.find({});
  res.render('index', {
    blogposts: blogposts
  });
};