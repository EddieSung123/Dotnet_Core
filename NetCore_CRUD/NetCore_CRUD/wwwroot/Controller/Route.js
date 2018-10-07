var KTJApp = angular.module('KTJApp', ['ngRoute']);

KTJApp.config(['$routeProvider', function ($routeProvider) {
    //$httpProvider.defaults.useXDomain = true;
    //delete $httpProvider.defaults.headers.common['X-Requested-With'];

    //這邊要注意的是，這裡的Controller指的不是Asp.net MVC的controller，這邊指的是AngularJS的ng-controller，這個Controller可以在路由
    //裡面宣告，也可以在View頁面裡面的模板中宣告。
    

    $routeProvider.when("/", { templateUrl: '/Home/Basic/' }) //首頁路由
        .when("/Basic", { templateUrl: '/Basic/Index/' })

       
        .otherwise({ redirectTo: '/' });
}]);