var ExchangersApplication =
    angular.module
        (
            "exchangersApplication",
            [
                "ngRoute",
                "ExchangersControllers",
                "ExchangersServices",

                "EqualsValidator",
                "UserMessage"
            ]
        );

ExchangersApplication
    .config
    ([
        "$routeProvider",
        "$locationProvider",
        function ($routeProvider, $locationProvider)
        {
            $routeProvider
                .when("/register",
                    {
                        templateUrl: "Frontend/Views/RegisterView.html",
                        controller: "RegisterCtrl"
                    })
                .when("/login",
                    {
                        templateUrl: "Frontend/Views/LoginView.html",
                        controller: "LoginCtrl"
                    })
                .when("/account",
                    {
                        templateUrl: "Frontend/Views/ExchangersView.html",
                        controller: "ExchangersCtrl"
                    })
                .otherwise(
                    {
                        redirectTo: "/register"
                    });

            //$locationProvider.html5Mode
            //    (
            //        {
            //            enabled: true,
            //            requireBase: false
            //        }
            //    );
        }
    ]);