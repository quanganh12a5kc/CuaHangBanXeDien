/// <reference path="../angular.min.js" />
var myapp = angular.module('MyApp', []);

myapp.controller("SanPhamController", function ($scope, $http) {
    $http({
        method: "get",
        url: "/Customer/GetProduct"
    }).then(function success(d) {
        $scope.SanPhams = d.data.sp;
    }, function error() {
        alert("loi lay san pham");
    });
    $scope.ChonSanPham = function (masp) {
        localStorage.setItem("MaSP", masp);
    };
    $scope.ChonLoaiSP = function (maloai) {
        localStorage.setItem("MaLoai", maloai);
    };
});

myapp.controller("MenuController", function ($scope, $http) {
    $http({
        method: "get",
        url: "/Customer/LayLoaiSP"
    }).then(function success(d) {
        $scope.LoaiSPs = d.data.sp;
    }, function error() {
        alert("loi lay loai sp");
    });
    $scope.SelectMaSP = function (maloai) {
        localStorage.setItem("MaLoai", maloai);
    };
});

myapp.controller("XemChiTietController", function ($scope, $http) {
    $http({
        method: "get",
        url: "/Customer/LaySanPhamTheoMaSP",
        params: { masp: localStorage.getItem("MaSP") }
    }).then(function success(d) {
        $scope.SanPhams = d.data.sp;
    }, function error() {
        alert("loi lay san pham");
    });
});

myapp.controller("TimKiemTheoLoaiController", function ($scope, $http) {
    $http({
        method: "get",
        url: "/Customer/LaySanPhamTheoMaLoai",
        params: { maloai: localStorage.getItem("MaLoai") }
    }).then(function success(d) {
        $scope.SanPhams = d.data.sp;
    }, function error() {
        alert("lay san pham theo loai loi");
    });
});