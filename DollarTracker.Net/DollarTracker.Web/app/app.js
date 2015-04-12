﻿app = angular.module('DollarTrackerApp', ['ui.router','ui.bootstrap','ng-bootstrap-datepicker', 'satellizer']);
app.config(['$stateProvider', '$urlRouterProvider', '$locationProvider', '$httpProvider','$authProvider', 'API_URL',
function ($stateProvider, $urlRouterProvider, $locationProvider, $httpProvider,$authProvider, API_URL) {

        $locationProvider.html5Mode(false);
        $urlRouterProvider.otherwise("/");

        $stateProvider
        .state('/', {
            url: '/',
            templateUrl: 'app/dashboard/dashboard.html?random=' + RANDOM,
            controller: 'dashboardCtrl',
            resolve: {
                expenseStories: ['dashboard', function (dashboard) {
                    return dashboard.getExpenseStories().then(function (results) {
                        console.log("resolve");
                        console.log(results);
                        return results.data.data;
                    });
                }]
            }
        })
        .state('login', {
            url: '/login',
            templateUrl: 'app/user/login.html?random=' + RANDOM,
            controller: 'loginCtrl'
        })
        .state('register', {
            url: '/register',
            templateUrl: 'app/user/register.html?random=' + RANDOM
        })
        .state('logout', {
            url: '/logout',
            controller: 'logoutCtrl'
        });

        $authProvider.loginUrl = API_URL + 'auth/login';
        $authProvider.signupUrl = API_URL + 'auth/register';

        $authProvider.google({
            clientId: '',
            url: API_URL + 'auth/google'
        })

        $httpProvider.interceptors.push('authInterceptor');
    }])
.constant('API_URL', 'http://localhost:3000/')
.run(function ($window) {
    var params = $window.location.search.substring(1);

    if (params && $window.opener && $window.opener.location.origin === $window.location.origin) {
        var pair = params.split('=');
        var code = decodeURIComponent(pair[1]);

        $window.opener.postMessage(code, $window.location.origin);
    }
});