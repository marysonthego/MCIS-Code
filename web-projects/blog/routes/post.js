const express = require('express');
const router = express.Router();
const mongoose = require('mongoose');
const bodyParser = require('body-parser');
const path = require('path');
const BlogPost = require('../models/BlogPost');
const fileUpload = require('express-fileupload');

//mongoose.connect('mongodb://localhost/blogdb',
//    {useNewUrlParser: true, useUnifiedTopology: true});

router.use(bodyParser.json());
router.use(bodyParser.urlencoded({ extended:true}));
router.use(fileUpload());

router.get("/new",(req,res,next) => {
  res.render('create');
});

router.get('/:id', async (req,res,next) => {
  let blogpost = await BlogPost.findById(req.params.id);
  res.render('post', {
    blogpost: blogpost
  });
});

router.post("/store", async (req,res,next) => {
  let image = req.files.image;
  image.mv(path.resolve(__dirname, '../public/img', image.name));
  req.files.image = image;
  await BlogPost.create(req.body);
  BlogPost.image = req.files.image;
  BlogPost.save;
  console.log(req.body);
  res.redirect('/');
});


module.exports = router;
