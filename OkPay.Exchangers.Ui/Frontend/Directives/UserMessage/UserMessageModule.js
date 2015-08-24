var UserMessageModule = angular.module("UserMessage", ["ExchangersServices"]);

UserMessageModule.directive("opUserMessage", UserMessageDirective);
UserMessageModule.controller("UserMessageCtrl", ["$scope", "UsersSvc", UserMessageController]);