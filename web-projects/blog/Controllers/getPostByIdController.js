const BlogPost = require('../models/BlogPost');

module.exports = async (req,res,next) => {
  const blogpost = await BlogPost.findById(req.params.id);
    res.render('post', {
      blogpost: blogpost
    });
  };