const BlogPost = require('../models/BlogPost');

module.exports = async (req,  res,  next) => {
  let blogpost = await BlogPost.findOne(req.params.id);
  res.render('post', {
    blogpost: blogpost
  });
};