var express = require('express');
var router = express.Router();
var jsonData = require('../data.json');

/* GET home page. */
router.get('/', (req, res, next) => {
  res.render('index', {
    title: 'Express',
    data: jsonData });
});

module.exports = router;
