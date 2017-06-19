(function () {

    //create a module
    var app = angular.module('MyApp', ['ngRoute']);

    //create controller
    app.controller('HomeController', function ($scope) {
        $scope.Message = "Yahoo!!!";
    });
})();