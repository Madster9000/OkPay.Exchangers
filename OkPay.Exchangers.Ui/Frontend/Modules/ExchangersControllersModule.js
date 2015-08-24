ExchangersControllersModule = angular.module("ExchangersControllers", ["ExchangersServices"]);

ExchangersControllersModule.controller("RegisterCtrl", ["$scope","$location", "UsersSvc", RegisterController]);
ExchangersControllersModule.controller("LoginCtrl", ["$scope", "$location", "UsersSvc", LoginController]);
ExchangersControllersModule.controller("ExchangersCtrl", ["$scope","CourseMapsSvc","CurrenciesSvc", ExchangersController]);
