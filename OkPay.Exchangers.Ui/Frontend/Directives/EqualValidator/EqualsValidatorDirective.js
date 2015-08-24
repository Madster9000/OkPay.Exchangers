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
}