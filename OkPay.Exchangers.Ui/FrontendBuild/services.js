var CourseMapsService = function($http)
{
    var getCourseMaps = function(firstCurrencyId, secondCurrencyId)
    {
        var requestUrl = "/CourseMaps?FirstCurrencyId=" + firstCurrencyId + "&SecondCurrencyId=" + secondCurrencyId;
        return $http.get(requestUrl);
    }
    var service =
        {
            GetCourseMaps: getCourseMaps
        };
    return service;
};
var CurrenciesService = function($http)
{
    var getAll = function()
    {
        var requestUrl = "/currencies";
        return $http.get(requestUrl);
    }
    var service =
        {
            GetAll: getAll
        };
    return service;
};
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