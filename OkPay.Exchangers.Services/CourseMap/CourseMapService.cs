using System.Collections.Generic;
using System.Linq;
using OkPay.Exchangers.Cqrs.Contracts;
using OkPay.Exchangers.Cqrs.Contracts.CourseMap;
using OkPay.Exchangers.Cqrs.Queries;

namespace OkPay.Exchangers.Services.CourseMap
{
    public class CourseMapService : ICourseMapService
    {
        private readonly ICourseMapQueries mCourseMapQueries;

        public CourseMapService(ICourseMapQueries courseMapQueries)
        {
            mCourseMapQueries = courseMapQueries;
        }

        public IEnumerable<CourseMapResponse> FindCourseMaps(CourseMapRequest request)
        {
            return
                mCourseMapQueries
                    .SelectByCurrencies(request.FirstCurrencyId, request.SecondCurrencyId)
                    .Select
                    (
                        cm =>
                            new CourseMapResponse
                            {
                                ExchangerName = cm.Exchanger.Name,
                                Course = cm.Course
                            }
                    ).ToList();
        }
    }
}