module.exports = (req,res,next)=>{
  if(req.files == null || req.body.title == null ||
    req.body.subheading == null || req.body.body == null ||
    req.body.username == null) {
    return res.redirect('/new');
  }
  next();
};