var express = require('express');
var router = express.Router();
var ipcalc = require('../public/javascripts/ipcalc-script');

/* GET home page.
   when get url matches '/', function is called.
   move function to the file index.js in controllers directory*/
/* original router.get:
router.get('/', function(req, res, next) {
  res.render('index', { title: 'Subnet Calculator' });
});
*/
let index = require('../controllers/index');
router.get('/', index.index);

router.get('./ipcalc-script', function(req, res, next) {
  res.send(ipcalc.validate());
});

module.exports = router;
