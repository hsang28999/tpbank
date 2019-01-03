﻿
function config($stateProvider, $urlRouterProvider, $ocLazyLoadProvider, $locationProvider, IdleProvider) {

    // Configure Idle settings
    IdleProvider.idle(5); // in seconds
    IdleProvider.timeout(120); // in seconds

    $urlRouterProvider.otherwise("/");

    $ocLazyLoadProvider.config({
        // Set to true if you want to see what and when is dynamically loaded
        debug: false
    });
    $locationProvider.html5Mode(true);

    $stateProvider
        .state('login',
            {
                url: "/login"
            })
        .state('menu',
            {
                url: "/menu",
                templateUrl: "html/menu.html"
            })
        .state('detail',
            {
                url: "/account-detail/:id",
                templateUrl: "html/accountdetail.html"
            })
        .state('history',
            {
                url: "/history",
                templateUrl: "html/history.html"
            })
        .state('deposit',
            {
                url: "/deposit",
                templateUrl: "html/deposit.html"
            })
        ;
}


app.config(config)
    .run(function ($rootScope, $state, $stateParams) {
        $rootScope.$state = $state;
        $rootScope.$stateParams = $stateParams;
        $rootScope.$on('$stateChangeSuccess', function () {
            document.body.scrollTop = document.documentElement.scrollTop = 0;

        });
    });
