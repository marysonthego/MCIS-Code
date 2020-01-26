const express = require('express');
const router = express.Router();
const bodyParser = require('body-parser');
const fileUpload = require('express-fileupload');
const authMiddleware = require('../middleware/authenticationMiddleware');

router.use(bodyParser.json());
router.use(bodyParser.urlencoded({ extended:true}));
router.use(fileUpload());

const validateMiddleware = require("../middleware/validateMiddleware");
router.use("/store",validateMiddleware);

const newPost = require('../Controllers/newPostController');
router.get('/new',authMiddleware,newPost);

const getPostById = require('../Controllers/getPostByIdController');
router.get('/:id', getPostById);

const findPost = require('../Controllers/findPostController');
router.get('/', findPost);

const storePost = require('../Controllers/storePostController');
router.post("/store",authMiddleware,storePost);

module.exports = router;
