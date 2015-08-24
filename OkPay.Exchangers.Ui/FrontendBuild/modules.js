ExchangersControllersModule = angular.module("ExchangersControllers", ["ExchangersServices"]);

ExchangersControllersModule.controller("RegisterCtrl", ["$scope","$location", "UsersSvc", RegisterController]);
ExchangersControllersModule.controller("LoginCtrl", ["$scope", "$location", "UsersSvc", LoginController]);
ExchangersControllersModule.controller("ExchangersCtrl", ["$scope","CourseMapsSvc","CurrenciesSvc", ExchangersController]);
;
ExchangersServicesModule = angular.module("ExchangersServices", []);

ExchangersServicesModule.factory("UsersSvc", ["$http", UsersService]);
ExchangersServicesModule.factory("CurrenciesSvc", ["$http", CurrenciesService]);
ExchangersServicesModule.factory("CourseMapsSvc", ["$http", CourseMapsService]);