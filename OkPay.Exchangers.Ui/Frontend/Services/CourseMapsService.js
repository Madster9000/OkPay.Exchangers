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
}