/// <reference path="/Assets/admin/libs/angular/angular.js" />

(function () {
    angular.module('Nlshop',
        ['Nlshop.products',
         'Nlshop.product_categories',
         'Nlshop.common'])
        .config(config);

    config.$inject = ['$stateProvider', '$urlRouterProvider'];

    function config($stateProvider, $urlRouterProvider) {
        $stateProvider.state('home', {
            url: "/admin",
            templateUrl: "/app/components/home/homeView.html",
            controller: "homeController"
        });
        $urlRouterProvider.otherwise('/admin');
    }
})();