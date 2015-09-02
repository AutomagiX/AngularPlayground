angular.module("sportsStore", ["customFilters"])
.constant("dataUrl", "https://api.parse.com/1/classes/Products")
.run(function($http){
    $http.defaults.headers.common["X-Parse-Application-Id"]
    = "rUkY7KxnQRF89KpbfsRtOPLe3MXNKVveBzAKUHUE";
    $http.defaults.headers.common["X-Parse-REST-API-Key"]
    = "Vzkvk2ch0TDnuWnGdhJqH3ai31R8jRTN9g3yU46s";
})
.controller("sportsStoreCtrl", function ($scope, $http, dataUrl) {

    $scope.data = {};
    
    $http.get(dataUrl)
    .success(function(data){
        $scope.data.products=data.results;
    })
    .error(function(response){
        $scope.data.error = response.error||response;
    });
});
