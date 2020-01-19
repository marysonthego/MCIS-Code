            <ul>
              <li>Webstorm is an IDE customized for creating Node.js Express apps. The steps below
                pick up after you have generated a new <em>Node JS/Express app</em> with
                the EJS template engine. Webstorm generates a skeleton app that is a great starting point
                for learning about Express.</li>
              <li><br><h3>./package.json</h3> Defines the application dependencies.  You can edit or create
                this file yourself, but it is generated for you when you create a new project.</li>
              <li><br><h3>./bin/www</h3> The file "www" (with no extension) is the entry point
                to the application. It points the global variable <code>app</code> to the file
                <code>../app.js</code> like this:
                <code>var app = require('../app');</code> (You do not have to specify the file extension).<br>
                Next, <code>www</code> sets the listening port to <code>3000</code> by default (you can change the port), and finally,<br>
                it instructs <code>app</code> to listen for browser requests on the listening port.</li>

              <li><p><h3>./app.js</h3> Defines the Express application object called <code>app</code> by default.<br><br>
                Express improves on vanilla Node.js by introducing a <em>routing</em> mechanism to organize Node.js websites.
                <code>./app.js</code> is the nerve-center of your application. It's where you'll define the top-level
                <em>routes</em> to all the stuff you want to serve up. Let's start with the simple
                case.</p>

                You have a website with only two pages. Your home page is at <code>http://localhost:3000/index</code>
                and you have one child page at <code>http://localhost:3000/about</code>.  The simplest kind of route is
                one you define at the application level in <code>app</code>. For a simple app like this, you can put all
                the routing info you need in the <code>./app.js</code> file itself.



                You can define <em>routes</em> in <code>app.js</code> in 2 steps:<br><br>
                <code>   1.  var indexRouter = require('./routes/index');</code><br>
                <code>   2.  app.use('/', indexRouter);</code><br><br>
                <code>'/'</code> is now a <em>route</em> to <code>index</code> in
                the application URL.  For example, <code>http://localhost:3000/</code> points
                to <code>http://localhost:3000/index</code><br><br>

                <p>A <em>route</em> is a section of Express code that associates an HTTP verb-pattern
                  (GET, POST, PUT, DELETE, etc.), with a URL path/verb-pattern, and a <em>function</em>
                  that is called to handle that pattern on that path.</p>
                <p>You use the <em>express.Router</em> middleware to group the route handlers
                  for a particular part of a site together and access them using a
                  common route-prefix such as <code>http://localhost:3000/get</code>. </p>
                <p><code>require</code> only imports the module.  Here, we set the variable <code>indexRouter</code> equal to <code>./routes/index</code></p>
                <p><code>use</code> enables us to actually <em>use</em> the module with
                  the alias <code>/</code>. The <code>use</code> function adds the <em>middleware</em>
                  library <code>./routes/index</code> to the <em>request handling chain</em>.</p>
                <P>You must <em>export</em> everything you want to access in your app, whether
                  it's a module, function, or variable.  So, to export the entire <code>app.js</code> module (file),
                  the final line in <code>./app.js</code> is <code>module.exports = app;</code></P>
              </li>

              <li><h3>./routes/index.js</h3><p>Route files are defined in the <code>./routes/</code> directory.  When an
                  HTTP request arrives from the browser, <em>Express</em> looks for a matching route from among
                  those we defined in <code>apps.js</code>.  If it can't match a route in
                  any of the modules (files) we registered (used) in <code>app.js</code>, we will get a <em>404 Not Found</em>
                  error in the browser for that HTTP request.</p>
                <p>For example, if you click the "submit" button on a form, but there is no route
                matching <code>action=URL</code> and <code>method=GET</code> in a route file
                registered in <code>apps.js</code>, you will get a <em>404 not found</em>
                error on return.</p>
                <p>Below, the route specifies a callback function that is invoked whenever an HTTP GET
                  request from the correct html page arrives from the browser. The function always takes
                  the request, response, and next as parameters. Here, the function responds to the browser
                  with a redirect to the /catalog page.</p>
                <div class='code'>
              <pre><code>   var express = require('express');
   var router = express.Router();

   /* GET home page. */
   router.get('/', function(req, res, next) {
       res.redirect('/catalog');
   });

   module.exports = router;</code></pre></div>
                <br><code>req</code> Request object</br>
                <br><code>res</code> Response object</br>
                <br><code>next</code> Next middleware function to call</br>
              </li>
            </ul>
          </div>
        </div>