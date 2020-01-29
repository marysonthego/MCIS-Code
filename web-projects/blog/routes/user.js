const express = require('express');
const router = express.Router();
const redirectIfAuthenticated = require('../middleware/redirectIfAuthenticatedMiddleware');
const logout = require('../controllers/logoutController')
const login = require('../Controllers/loginController');

router.get('/login',redirectIfAuthenticated,login);

router.get('/logout',logout);

const loginUser = require('../Controllers/loginUserController');
router.post('/login',redirectIfAuthenticated,loginUser);

const registerUser = require("../Controllers/registerController");
router.get("/register",redirectIfAuthenticated,registerUser);

const storeUser = require('../controllers/storeUserController');
router.post('/register',redirectIfAuthenticated,storeUser);

module.exports = router;

