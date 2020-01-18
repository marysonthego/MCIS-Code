var express = require('express');
var router = express.Router();
var mongoose = require('mongoose');
var bodyParser = require('body-parser');
var BlogPost = require('../models/BlogPost.js');

mongoose.connect('mongodb://localhost/blogdb',
    {useNewUrlParser: true, useUnifiedTopology: true});


router.use(bodyParser.json());
router.use(bodyParser.urlencoded({ extended:true}));
//router.use(BlogPost);

router.get("/", (req, res, next) => {
  res.render("posts");
});

router.get("/new",(req,res,next) => {
  res.render('create');
});

router.post("/store", async (req,res,next) => {
  await BlogPost.create(req.body);
  console.log(req.body);
  res.redirect('/posts');
  });

module.exports = router;
