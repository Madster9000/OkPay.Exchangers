var LoginController = function ($scope, $location, usersService)
{
    $scope.LoginViewModel =
        {
            Login: "",
            Password: ""
        };

    $scope.LoginEvents =
        {
            OnLoginClicked: function()
            {
                console.log($scope.LoginViewModel);
                usersService
                    .LoginUser($scope.LoginViewModel)
                    .then
                    (
                        function(response)
                        {
                            usersService.CurrentUser = response.data;
                            if (response.data.IsUserLogedIn)
                            {
                                $location.path("/account");
                            }
                        }
                    );
            },
            OnRegisterClicked: function()
            {
                $location.path("/register");
            }
}
}