const express = require('express');
const router = express.Router();

const login = require('../Controllers/loginController');
router.get('/login',login);

const registerUser = require("../Controllers/registerController");
router.get("/register",registerUser);
//router.post("/register",);

const storeUser = require('../controllers/storeUserController');
router.post('/register', storeUser);

const loginUser = require('../Controllers/loginUserController');
router.post('/login', loginUser);

module.exports = router;

