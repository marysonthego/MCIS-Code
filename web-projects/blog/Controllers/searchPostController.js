const BlogPost = require('../models/BlogPost');

module.exports = async function (req,  res,  next) {
  console.log('in searchPostController');
  let searchString = req.params.searchBox;
  searchString = '/' + searchString + '/i';
  console.log('searchString = ' + searchString);
  let blogposts = await BlogPost.find({'title': searchString}, function (err, blogposts) {
    res.render('index', {
      blogposts: blogposts
    });
  });
};