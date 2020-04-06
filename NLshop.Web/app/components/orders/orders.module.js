/// <reference path="/Assets/admin/libs/angular/angular.js" />

(function () {
    angular.module('Nlshop.orders', ['Nlshop.common']).config(config);

    config.$inject = ['$stateProvider', '$urlRouterProvider'];

    function config($stateProvider, $urlRouterProvider) {
        $stateProvider.state('orders', {
            url: "/orders",
            templateUrl: "/app/components/orders/ordersView.html",
            controller: "ordersController"
        });
    }
})();