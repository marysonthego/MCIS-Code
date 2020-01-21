var express = require('express');
var router = express.Router();
var mongoose = require('mongoose');
var bodyParser = require('body-parser');
var BlogPost = require('../models/BlogPost');

mongoose.connect('mongodb://localhost/blogdb',
  {useNewUrlParser: true, useUnifiedTopology: true});

router.use(bodyParser.json());
router.use(bodyParser.urlencoded({ extended:true}));

const searchposts = require('../Controllers/searchPostController');
router.get('/search/:searchBox', searchposts);
//router.param('searchBox', searchposts());

const blogposts = require('../Controllers/listPostsController');
router.get('/',blogposts);


module.exports = router;
