var express = require('express');
var router = express.Router();
var mongoose = require('mongoose');
var bodyParser = require('body-parser');
var BlogPost = require('../models/BlogPost');

mongoose.connect('mongodb://localhost/blogdb',
  {useNewUrlParser: true, useUnifiedTopology: true});

router.use(bodyParser.json());
router.use(bodyParser.urlencoded({ extended:true}));

router.get('/', async (req, res, next) => {
  var blogposts = await BlogPost.find({});
  res.render('index', {
    blogposts: blogposts
  });
});

module.exports = router;
