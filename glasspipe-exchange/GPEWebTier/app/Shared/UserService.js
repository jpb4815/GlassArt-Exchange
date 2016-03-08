(function () {
    'use strict';

    angular
        .module('UserService', [])
        .factory('User',['$q', '$http','$scope', UserService] );


    function UserService($q, $http, $scope) {

        this.getCurrentUser = function() {
            var deferred = $q.defer();

            $http({
                method: "GET",
                url: "http://localhost:59894/Users/User/{id}"
            }).success(function(data) {
                //data is sucessfully returned and accesible
                deferred.resolve();
            }).error(function() {
                $scope.errorMessage = "Error retrieving Data";
                deferred.reject();
            });
            return deferred.promise();
        }
        
    }
    //return an object with all of our functions
    return {
        getCurrent: getCurrent,
        signup: signup,
        login: login,
        logout: logout
    };

    /**
     * get the current user that is logged in
     */
    function getCurrent() {
        var def = $q.defer();

        // get the instance of the logged in user and build hir/her
        var newUser = getCurrentUser().then(function(response) {
            $scope.data = response;
        });
        return def.promise;

    }
})();