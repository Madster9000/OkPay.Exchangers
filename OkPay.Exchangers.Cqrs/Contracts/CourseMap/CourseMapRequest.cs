using System;

namespace OkPay.Exchangers.Cqrs.Contracts.CourseMap
{
    public class CourseMapRequest
    {
        public Guid FirstCurrencyId { get; set; }
        public Guid SecondCurrencyId { get; set; }
    }
}