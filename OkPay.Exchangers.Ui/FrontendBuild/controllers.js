var ExchangersController = function($scope, courseMapsService, currenciesService)
{
    $scope.ExchangersViewModel =
        {
            Currencies: [],
            FirstCurrency: null,
            SecondCurrency: null,
            Exchangers: []
        };

    $scope.ExchangersEvents =
        {
            OnControllerStarted: function()
            {
                currenciesService
                    .GetAll()
                    .then
                    (
                        function(response)
                        {
                            console.log(response);
                            $scope.ExchangersViewModel.Currencies = response.data;
                        }
                    );
            },
            OnFirstCurrencyClicked: function(currency)
            {
                $scope.ExchangersViewModel.FirstCurrency = currency;
                if ($scope.ExchangersViewModel.SecondCurrency != null)
                {
                    courseMapsService
                        .GetCourseMaps($scope.ExchangersViewModel.FirstCurrency.Id, $scope.ExchangersViewModel.SecondCurrency.Id)
                        .then
                        (
                            function(response)
                            {
                                console.log(response);
                                $scope.ExchangersViewModel.Exchangers = response.data;
                            }
                        );
                }
            },
            OnSecondCurrencyClicked: function(currency)
            {
                $scope.ExchangersViewModel.SecondCurrency = currency;
                if ($scope.ExchangersViewModel.FirstCurrency != null)
                {
                    courseMapsService
                        .GetCourseMaps($scope.ExchangersViewModel.FirstCurrency.Id, $scope.ExchangersViewModel.SecondCurrency.Id)
                        .then
                        (
                            function(response)
                            {
                                console.log(response);
                                $scope.ExchangersViewModel.Exchangers = response.data;
                            }
                        );
                }
            }
        }

    $scope.ExchangersEvents.OnControllerStarted();
};
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
};
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