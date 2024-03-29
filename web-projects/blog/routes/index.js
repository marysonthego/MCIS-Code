var express = require('express');
var router = express.Router();
var mongoose = require('mongoose');
var bodyParser = require('body-parser');
const flash = require('connect-flash');

mongoose.connect('mongodb://localhost/blogdb',
  {useNewUrlParser: true, useUnifiedTopology: true});

router.use(bodyParser.json());
router.use(bodyParser.urlencoded({ extended:true}));
router.use(flash());

const searchposts = require('../Controllers/searchPostController');
router.get('/search', searchposts);

const blogposts = require('../Controllers/listPostsController');
router.get('/', blogposts);

module.exports = router;
