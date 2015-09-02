angular.module("GymDemo", [])
    .config(function ($routeProvider) {
        $routeProvider.otherwise({

        });
    })
    .controller("GymController", function ($scope, $http) {
        $scope.data = {};

        $http.get("/Gym/AllGyms")
            .success(function (data) {
                $scope.data.gyms = data;
                console.log(data);
            })
            .error(function (response) {
                $scope.data.error = response.error || response;
                console.log($scope.data.error);
            })
        });