const mongoose = require('mongoose');
const Schema = mongoose.Schema;
const bcrypt = require('bcryptjs');

const UserSchema = new Schema({
    username: {
        type: String,
        required: true,
        unique: true
    },
    password: {
        type: String,
        required: true
    } //,
    //datecreated: {
    //    type: Date,
    //    default: new Date()
    //}
});

UserSchema.pre ('save', function(next) {
    const user = this;
    console.log('username = ' + [user.username]);
    bcrypt.hash(user.password, 10, function(error,hash) {
        user.password = hash;
        console.log('hashed pwd = ' + user.password);
        next();
    });
});

const User = mongoose.model('User',UserSchema);

module.exports = User;