var Book = require('../models/book');
var Author = require('../models/author');
var Genre = require('../models/genre');
var BookInstance = require('../models/bookinstance');

var async = require('async');

/*
The async.parallel() method is passed an object with functions
for getting the counts for each of our models. These functions
are all started at the same time. When all of them have completed
the final callback is invoked with the counts in the results
parameter (or an error).

On success the callback function calls res.render(), specifying
a view (template) named 'index' and an object containing the data
that is to be inserted into it (this includes the results object
that contains our model counts). The data is supplied as key-value
pairs, and can be accessed in the template using the key.

 We use the countDocuments() method to get the number of instances
 of each model. This is called on a model with an optional set of
 conditions to match against in the first argument and a callback
 in the second argument (as discussed in Using a Database (with
 Mongoose), and you can also return a Query and then execute it
 with a callback later. The callback will be returned when the database
 returns the count, with an error value (or null) as the first parameter
 and the count of records (or null if there was an error)
 as the second parameter.
 */
exports.index = function(req, res, next) {

    async.parallel({
        book_count: function(callback) {
            Book.countDocuments({}, callback); // Pass an empty object as match condition to find all documents of this collection
        },
        book_instance_count: function(callback) {
            BookInstance.countDocuments({}, callback);
        },
        book_instance_available_count: function(callback) {
            BookInstance.countDocuments({status:'Available'}, callback);
        },
        author_count: function(callback) {
            Author.countDocuments({}, callback);
        },
        genre_count: function(callback) {
            Genre.countDocuments({}, callback);
        }
    }, function(err, results) {
        res.render('index', { title: 'Local Library Home', error: err, data: results });
    });
};

// Display list of all books.
exports.book_list = function(req, res, next) {
    Book.find({}, 'title author')
        .populate('author')
        .exec(function (err, list_books) {
            if (err) { return next(err); }
            //Successful, so render
            res.render('book_list', { title: 'Book List', book_list: list_books });
        });

};

// Display detail page for a specific book.
exports.book_detail = function(req, res) {
    res.send('NOT IMPLEMENTED: Book detail: ' + req.params.id);
};

// Display book create form on GET.
exports.book_create_get = function(req, res) {
    res.send('NOT IMPLEMENTED: Book create GET');
};

// Handle book create on POST.
exports.book_create_post = function(req, res) {
    res.send('NOT IMPLEMENTED: Book create POST');
};

// Display book delete form on GET.
exports.book_delete_get = function(req, res) {
    res.send('NOT IMPLEMENTED: Book delete GET');
};

// Handle book delete on POST.
exports.book_delete_post = function(req, res) {
    res.send('NOT IMPLEMENTED: Book delete POST');
};

// Display book update form on GET.
exports.book_update_get = function(req, res) {
    res.send('NOT IMPLEMENTED: Book update GET');
};

// Handle book update on POST.
exports.book_update_post = function(req, res) {
    res.send('NOT IMPLEMENTED: Book update POST');
};