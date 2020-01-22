const BlogPost = require('../models/BlogPost');

module.exports = async function (req,  res,  next) {
  console.log('in searchPostController');
  var searchString = req.query.searchBox;
  const blogposts = await BlogPost.find({$text: {$search: searchString}},
    function (err, blogposts) {
    console.log(searchString);
    res.render('index', {
      blogposts
    });
  });
};

//Create a "text" index in order to use $text: {$search}
//From c:\Program Files\MongoDB\Server\4.2\bin command prompt:
//For next time, add this to PATH
// mongo
//show dbs
//use blogdb
//show collections
//Create a "text" index on blogdb.blogposts collection:
//db.blogposts.createIndex( { title: "text" } )
//The spaces in the command are important