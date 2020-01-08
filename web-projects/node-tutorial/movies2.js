//module is shared by all other modules that import it
/*
module.exports = {
    favMovie: ""
};
*/
//object factory creates a new movie object on every call
module.exports = function() {
    return{
        favMove: ""
    }
};