const http = require('http');
const instructions = require('./database');

http.createServer((req, res) => {
  if (req.url === '/instructions') {
    res.writeHead(200, { 'Content-Type': 'application/json charset=utf-8' });
    res.end(JSON.stringify(instructions))
  }
}).listen(8080, () => console.log('Server is running...'));