var express = require('express');
var router = express.Router();

router.get('/post', function(req, res, next) {
  console.log(req.toString());
  res.render('index');
});

module.exports = router;
