const BlogPost = require('../models/BlogPost');
const path = require('path');

module.exports = (req,res,next) => {
  let image = req.files.image;
  image.mv(path.resolve(__dirname, '../public/img', image.name),
    async (onerror) => {
      await BlogPost.create({
        // ... is the rest operator.
        // https://oprea.rocks/blog/what-do-the-three-dots-mean-in-javascript/
        ...req.body,
        image: '/img/' + image.name
      });
      res.redirect('/');
    });
};