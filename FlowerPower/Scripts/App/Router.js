define([
  // Application.
  "App",
  'backbone'
],

function (app, Backbone) {

    // Defining the application router, you can attach sub routers here.
    var Router = Backbone.Router.extend({
        routes: {
            "": "index"
        },

        index: function () {
            $(".button").live("click", function () {
                $(".button").css("z-index", 0);
                $(".button").removeClass("selected");
                $(this).addClass("selected");
                $(this).css("z-index", 100);
                $(".content-placeholder").css("background-color", $(this).css("background-color"));
                $(".content-placeholder").removeClass("box-shadow", $(".content-placeholder").css("box-shadow"));
            });
        }
    });

    return Router;

});