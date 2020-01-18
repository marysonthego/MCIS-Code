const mongoose = require('mongoose');
const BlogPost = require('./models/BlogPost');

mongoose.connect('mongodb://localhost/blogdb',
    {useNewUrlParser: true, useUnifiedTopology: true});

BlogPost.create({
    title: 'Blog 2 Post Title',
    body: 'Blog post 2 body text.'
}, (error, blogpost) => {
    console.log(error, blogpost);
});

BlogPost.find({title:/Blog/}, (error, blogpost) => {
    console.log(error,blogpost)
});