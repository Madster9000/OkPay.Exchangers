UsersService = function($http)
{
    var currentUser =
        {
            IsUserRegistered: false,
            IsUserLogedIn: false,
            Description: "Зарегистрируйтесь"
        };

    var registerUser = function(registerViewModel)
    {
        var userData =
            {
                Login: registerViewModel.Login,
                Password: registerViewModel.Password
            };
        var requestUrl = "accounts/register";
        return $http.post(requestUrl, userData);
    }

    var loginUser = function(loginViewModel)
    {
        var userData =
            {
                Login: loginViewModel.Login,
                Password: loginViewModel.Password
            };
        var requestUrl = "accounts/login";
        return $http.post(requestUrl, userData);
    }

    var service =
        {
            CurrentUser: currentUser,
            RegisterUser: registerUser,
            LoginUser: loginUser
        };

    return service;
}