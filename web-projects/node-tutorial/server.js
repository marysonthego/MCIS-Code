var http = require('http');
var fs = require('fs');

//404 response
function send404Response(response) {
    response.writeHead(404, {"Content-Type": "text/plain"});
    response.write("Error 404 - not found");
    response.end();
}

function onRequest(request, response) {
    console.log("User made a request. " + request.url);
    if (request.method == "GET" && request.url == "/") {
        response.writeHead(200, {"Content-Type": "text/html"});
        fs.createReadStream("./index.html").pipe(response);
    } else {
        send404Response(response);
    }
  //  response.end();
}
 //   response.writeHead(200, {"Context-Type": "text/plain"});
 //   response.write("Here is some data.");
 //   response.end();
// }
http.createServer(onRequest).listen(9876);
console.log('Server is now running...');
