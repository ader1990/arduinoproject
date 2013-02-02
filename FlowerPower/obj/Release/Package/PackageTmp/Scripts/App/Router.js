define([
  // Application.
  "App",
  'backbone'
],

function (app, Backbone) {
    var Router = Backbone.Router.extend({
        routes: {
            "/": "index",
            "": "index",
            "#": "index",
            "flowers": "index",
            "placeholder": "placeholder",
            "enviroment": "enviroment",
        },
        placeholder: function () {
            var placeholder = "#placeholders";
            $(placeholder).parent().children().hide();
            $(placeholder).show();
        },
        enviroment: function () {
            var placeholder = "#enviroment";
            $(placeholder).parent().children().hide();
            $(placeholder).show();
        },
        index: function () {
            var placeholder = "#flowers";
            $(placeholder).parent().children().hide();
            $(placeholder).show();
            $(".flower-menu a").css("z-index", 0);
            $(".link").removeClass("selected");
            $(".flower-menu a").addClass("selected");
            $(".flower-menu a").css("z-index", 100);
            $.ajax({
                url: "/api/flowers",
                type: "POST",
                data: {
                    Name: "Flower Power",
                }
            }).success(function () {
                $.ajax({
                    url: "/api/flowers",
                    type: "GET"
                }).success(function (data) {
                    console.log(data);

                    for (var i in data) {
                        $.ajax({
                            url: "/api/flowers/" + data[i].Id,
                            type: "DELETE"
                        });
                        $("#flowers").append("<p>" + data[i].Name + "</p>");
                    }
                });
            });
        }
    });

    return Router;

});