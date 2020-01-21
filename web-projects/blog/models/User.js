const mongoose = require('mongoose');
const schema = mongoose.Schema;
const bcrypt = require('bcryptjs');

const UserSchema = new schema({
    username: {
        type: String,
        required: true,
        unique: true
    },
    password: {
        type: String,
        required: true
    },
    datecreated: {
        type: Date,
        default: new Date()
    }
});

UserSchema.pre('save', function(next) {
    const user = this;
    bcrypt.hash(user.password, 10,(error,hash) => {
        user.password = hash;
        next();
    });
});

const User = mongoose.model('User',UserSchema);

module.exports = User;