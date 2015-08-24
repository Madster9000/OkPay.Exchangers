using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using OkPay.Exchangers.Cqrs.Contracts.CourseMap;
using OkPay.Exchangers.Services.CourseMap;

namespace OkPay.Exchangers.Ui.Controllers
{
    public class CourseMapsController : ApiController
    {
        private readonly ICourseMapService mCourseMapService;

        public CourseMapsController(ICourseMapService courseMapService)
        {
            mCourseMapService = courseMapService;
        }

        public IEnumerable<CourseMapResponse> GetCourseMaps([FromUri]CourseMapRequest request)
        {
            return mCourseMapService.FindCourseMaps(request);
        }
    }
}
