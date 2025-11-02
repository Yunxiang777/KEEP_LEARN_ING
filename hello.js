const http = require('http');
const server = http.createServer((req, res) => {
  console.log(req.url);
  
  res.end('Hello, World!\n');
});

server.listen(9000, () => {
  console.log('Server is listening on port 3000');
});