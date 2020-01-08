var movies = require("./movies2");
movies.favMovie = "The Notebook";
console.log("Emily's favMovie is " + movies.favMovie);
var emilyFav = movies();
emilyFav.favMovie = "Cat on a Hot Tin Roof";
console.log("emilyFav.favMovie is " + emilyFav.favMovie);