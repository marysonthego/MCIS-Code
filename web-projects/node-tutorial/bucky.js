var movies = require("./movies2")
//movies.favMovie = "Good Will Hunting";
console.log("Bucky's favMovie is " + movies.favMovie);
var buckyFav = movies();
buckyFav.favMovie = "Star Wars";
console.log("buckyFav.favMovie is " + buckyFav.favMovie);