const mongoose = require('mongoose');
const schema = mongoose.Schema;

const BlogPostSchema = new schema({
    title: String,
    subheading: String,
    body: String,
    username: String,
    image: String,
    dateposted: {
        type: Date,
        default: new Date()
    }
});

const BlogPost = mongoose.model('BlogPost',BlogPostSchema);

module.exports = BlogPost;