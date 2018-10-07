var CRM = angular.module('Face', ['ngRoute']);

CRM.config(['$routeProvider', function ($routeProvider) {
    //$httpProvider.defaults.useXDomain = true;
    //delete $httpProvider.defaults.headers.common['X-Requested-With'];

    //這邊要注意的是，這裡的Controller指的不是Asp.net MVC的controller，這邊指的是AngularJS的ng-controller，這個Controller可以在路由
    //裡面宣告，也可以在View頁面裡面的模板中宣告。
    $routeProvider.when("/", { templateUrl: '/Home/Main' }) //首頁路由
        .when("/Main", { templateUrl: '/Home/Main/' })
        .when("/PNF45", { templateUrl: '/PNF45/Index' })
        .when("/PNF42", { templateUrl: '/PNF42/Index' })
        .when("/PSF77", { templateUrl: '/PSF77/Index' })
        .when("/PSF78", { templateUrl: '/PSF78/Index' })
        .when("/Holiday", { templateUrl: '/Holiday/Index' })
        
}]);