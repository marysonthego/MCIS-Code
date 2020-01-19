const express = require('express');
const router = express.Router();
const mongoose = require('mongoose');
const bodyParser = require('body-parser');
const path = require('path');
const BlogPost = require('../models/BlogPost');
const fileUpload = require('express-fileupload');

router.use(bodyParser.json());
router.use(bodyParser.urlencoded({ extended:true}));
router.use(fileUpload());

const validateMiddleware = require("../middleware/validateMiddleware");
router.use("/store",validateMiddleware);

const newPost = require('../Controllers/newPostController');
router.get('/new',newPost);

const getPostById = require('../Controllers/getPostByIdController');
router.get('/:id', getPostById);

const storePost = require('../Controllers/storePostController');
router.post("/store", storePost);

const findPost = require('../Controllers/findPostController');
router.get('/post', findPost);

module.exports = router;
