/// <reference path="../angular.min.js" />
var myapp = angular.module('MyApp', []);
myapp.controller("QLSanPhamController", function ($scope, $http) {
    $http({
        method: "get",
        url: "/QLSanPham/GetAllProduct"
    }).then(function Success(d) {
        $scope.SanPhams = d.data.sp;
    }, function (e) {
        alert('Failed');
    });
    $scope.Add = function (s) {
        $http({
            method: "Post",
            url: '/QLSanPham/AddProduct',
            datatype: 'Json',
            data: { s: s }
        }).then(function (d) {
            alert("da them");
        }, function (error) {
            alert(error);
        });
    };
    $scope.Delete = function (s) {
        var x = s.MaSP;
        $http({
            method: "Get",
            url: '/QLSanPham/DeleteProduct',
            datatype: 'Json',
            params: { id: x }
        }).then(function (d) {
            var vt = $scope.SanPhams.indexOf(s);
            $scope.SanPhams.splice(vt, 1);
        }, function (error) {
            alert("xoa loi");
        });
    };
    $scope.Edit = function (s) {
        $rootScope.sp = s;
    };
    $scope.SaveEdit = function (s) {
        $scope.sanpham = s;
        $http({
            method: "Post",
            url: '/QLSanPham/EditProduct',
            datatype: 'Json',
            data: { s: $scope.sanpham }
        }).then(function (d) {
            if (d.data == "") {
                for (i = 0; i < $scope.SanPhams.length; i++) {

                }
            }
        }, function (error) {
            alert(error);
        });
    };
});