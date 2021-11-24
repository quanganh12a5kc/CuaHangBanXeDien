/// <reference path="../angular.min.js" />
var myapp = angular.module('MyApp', []);
myapp.controller("DangNhapController", function ($scope, $http, $rootScope) {
    $rootScope.close = "";
    $rootScope.khach = null;
    $rootScope.login = 0;
    $rootScope.username = "";
    $rootScope.remember = false;
    $rootScope.password = "";
    $rootScope.Login = function (us, pass, rp) {
        $http({
            method: "get",
            url: "/Customer/Logins",
            params: {
                us: us,
                pass: pass,
                rp: rp
            }
        }).then(function Success(d) {
            alert("da vao dang nhap");
            if (d.data.login == "0") {
                $rootScope.close = "";
                alert("sai");
            }
            else {
                $rootScope.close = "modal";
                alert("dung");
            }
        }, function (e) {
            alert('Failed');
        });
    };
});