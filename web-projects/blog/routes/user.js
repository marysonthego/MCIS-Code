const express = require('express');
const router = express.Router();

const login = require('../Controllers/loginController');
router.get('/login',login);
router.post('/login',)

const newUser = require("../controllers/newUserController");
router.get("/register",newUser);

const storeUser = require('../controllers/storeUserController');
router.post('/store', storeUser);

module.exports = router;
