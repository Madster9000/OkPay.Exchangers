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
}