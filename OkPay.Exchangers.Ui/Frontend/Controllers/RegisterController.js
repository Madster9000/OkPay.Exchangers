var RegisterController = function($scope, $location, usersService)
{
    $scope.RegisterViewModel =
        {
            Login: "",
            Password: "",
            PasswordConfirmation: ""
        };
    $scope.RegisterEvents =
        {
            OnRegisterClicked: function()
            {
                usersService
                    .RegisterUser($scope.RegisterViewModel)
                    .then(function(response)
                    {
                        usersService.CurrentUser = response.data;
                        $location.path("/login");
                    });
            },
            OnUserRegisteredClicked: function()
            {
                $location.path("/login");
            }
        };
}