var EqualsValidatorDirective = function()
{
    return {
        restrict: "A",
        scope:
            {
                opEquals: "="
            },
        require: "ngModel",
        link: function(scope, elm, attrs, ngModel)
        {
            ngModel.$validators.equals = function(value)
            {
                return value === scope.opEquals;
            };

            scope.$watch
                (
                    function() { return scope.opEquals },
                    function(newValue, oldValue)
                    {
                        ngModel.$validate();
                    }
                );
        }
    };
};
var EqualsValidatorModule = angular.module("EqualsValidator", []);

EqualsValidatorModule.directive("opEquals", EqualsValidatorDirective);;
var UserMessageController = function($scope, userService)
{
    $scope.UsersService = userService;
};
var UserMessageDirective = function () {
    return {
        restrict: "A",
        templateUrl: "Frontend/Directives/UserMessage/UserMessageTempate.html",
        controller: "UserMessageCtrl"
    };
};
var UserMessageModule = angular.module("UserMessage", ["ExchangersServices"]);

UserMessageModule.directive("opUserMessage", UserMessageDirective);
UserMessageModule.controller("UserMessageCtrl", ["$scope", "UsersSvc", UserMessageController]);