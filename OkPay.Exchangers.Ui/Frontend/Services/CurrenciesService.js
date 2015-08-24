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
}