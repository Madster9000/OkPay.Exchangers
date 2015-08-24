ExchangersServicesModule = angular.module("ExchangersServices", []);

ExchangersServicesModule.factory("UsersSvc", ["$http", UsersService]);
ExchangersServicesModule.factory("CurrenciesSvc", ["$http", CurrenciesService]);
ExchangersServicesModule.factory("CourseMapsSvc", ["$http", CourseMapsService]);