var http = require('http');
var connect = require('../../node_modules/connect');

var app = connect();

function profile(request, response, next) {
    console.log('User requested profile');
    next();
}
function doFirst(request, response, next) {
    console.log("Bacon");
    next();
}

function doSecond(request, response, next) {
    console.log("Tuna");
    next();
}

app.use(profile);
app.use(doFirst);
app.use(doSecond);

http.createServer(app).listen(9876);
console.log("Server is running on 9876 ");
