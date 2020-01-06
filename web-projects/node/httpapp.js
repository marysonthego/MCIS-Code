const http = require('http');

//replace all this with Express framework
const server = http.createServer((req, res) => {
    if (req.url === '/') {
        res.write('Hello world');
        res.end();
    }

    if (req.url ==='/api') {
        res.write(JSON.stringify([1, 2, 3]));
        res.end();
    }
});

server.on('connection', (socket) => {
    console.log('New connection...');
});

server.listen(30000);

console.log('Listening on port 30000...');