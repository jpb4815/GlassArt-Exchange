(function() {
    "use strict";

    angular.module("app.routes", [])
        .config(["$stateProvider", "$urlRouterProvider", "$locationProvider", appRoutes]);

    /**
     * create all of the application routes
     */
    function AppRoutes($stateProvider, $urlRouterProvider, $locationProvider) {
        
        //pretty angular urls
        $locationProvider.html5Mode(true);

        //redirect to the home url if they try to go somewhere that does not exist
        $urlRouterProvider.otherwise("/");

        //create our routes, set the view, pull in the controller
        $stateProvider

        //Home Page
        .state("home", {
            url: "/",
            templateUrl: "app/home/home.html",
            controller: "HomeController as vm"
        })

        //shop page
        .state("shop", {
            url: "/shop/{name}",
            templateUrl: "/app/components/shop/shop.html",
            controller: "ShopController as vm"
        })

        //product page ( a child of shop)
        .state("product", {
            url: "/listing/{id}/{name}",
            templateUrl: "/app/components/product/product.html",
            controller: "ProductController as vm"
        })

        //login/signup page
        .state("authenticate", {
            url: "/authenticate",
            templateUrl: "/app/components/authenticate/authenticate.html",
            controller: "AuthenticateController as vm"
        })

         // profile page
        .state('profile', {
            url: '/profile/{user_name}',
            templateUrl: '/app/components/profile/profile.html',
            controller: 'ProfileController as profile'
        })

        // checkout page
        .state('checkout', {
            url: '/checkout/{id}',
            templateUrl: '/app/components/checkout/checkout.html',
            controller: 'CheckoutController as checkout'
        })

        // checkout page
        .state('admin', {
            url: '/admin',
            templateUrl: '/app/components/admin/admin.html',
            controller: 'AdminController as admin'
        });

    }
})();