﻿/// <reference path="/Assets/admin/libs/angular/angular.js" />

(function () {
    angular.module('Nlshop.ProductCategory', ['Nlshop.common']).config(config);

    config.$inject = ['$stateProvider', '$urlRouterProvider'];

    function config($stateProvider, $urlRouterProvider) {
        $stateProvider.state('product_categories', {
            url: "/product_categories",
            templateUrl: "/app/components/product_categories/ProductCategoryView.html",
            controller: "ProductCategoryController"
        });
    }
})();