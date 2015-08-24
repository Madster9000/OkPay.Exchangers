using System.Collections.Generic;
using OkPay.Exchangers.Cqrs.Contracts.CourseMap;

namespace OkPay.Exchangers.Services.CourseMap
{
    public interface ICourseMapService
    {
        IEnumerable<CourseMapResponse> FindCourseMaps(CourseMapRequest request);
    }
}