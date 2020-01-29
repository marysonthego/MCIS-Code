var express = require('express');
var router = express.Router();

let landing = require('../controllers/landing');
router.get('/', landing.getLanding);

let ipcalc = require('../public/javascripts/ipcalc');
router.post('/', ipcalc.validate(req, res, next));

module.exports = router;
//var ipcalc = require('../public/javascripts/ipcalc');

/* GET home page.
   when get url matches '/', function is called.
   move function to the file index.js in controllers directory*/
/* original router.get:
router.get('/', function(req, res, next) {
  res.render('index', { title: 'Subnet Calculator' });
});
*/

//router.get('./ipcalc-script', function(req, res, next) {
//  res.send(ipcalc.validate);
//});
