var express = require('express');
var router = express.Router();

/* GET about page. */
router.get('/', (req, res, next) => {
    res.render('about', { title: 'Express' });
});

module.exports = router;
