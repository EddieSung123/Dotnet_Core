var IndexApp = angular.module('KTJApp');
IndexApp.controller('IndexCtrl', IndexCtrl);

IndexCtrl.$inject = ['$scope', '$rootScope', '$route', '$templateCache'];

function IndexCtrl($scope, $rootScope, $route, $templateCache) {
    var self = this;
    $scope.test = "AAA";

    self.tabs = [];

    self.clickmenu = function (tab, link) {
        self.tab = {};
        //console.log("tab =" + tab);
        //console.log("link =" + link);
        self.tab.name = tab;
        self.tab.link = link;
        self.tabs.push(self.tab);
    };

    self.select = function ($event) {
        //console.log("Select");
        $ele = angular.element($event.target);
        $ele.parents('ul').find('li>span').each(function () { $(this).removeClass('active') });
        $ele.parent().addClass('active');

        //console.log($ele.parents('ul').find('li>span'));

        //清除KENDOWINDOW CACHE
        //var KWs = [];
        //KWs.push($("#grid").data("kendoWindow"));
        //KWs.push($("#Photodialog").data("kendoWindow"));
        //KWs.push($("#OpenSite").data("kendoWindow"));

        //for (var item of KWs) {
        //    if (!(item === undefined || item === null)) {
        //        //console.log(item);
        //        item.destroy();
        //    };
        //}
    };

    //標籤關閉
    self.colse = function ($event) {
        $ele = angular.element($event.target);
        $ele.parent().remove();
    };
}