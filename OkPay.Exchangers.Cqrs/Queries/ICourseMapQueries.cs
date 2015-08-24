using System;
using System.Collections.Generic;
using System.Linq;
using OkPay.Exchangers.Cqrs.Contracts.CourseMap;
using OkPay.Exchangers.Model;

namespace OkPay.Exchangers.Cqrs.Queries
{
    public interface ICourseMapQueries
    {
        IQueryable<CourseMap> SelectByCurrencies(Guid firstCurrencyId, Guid secondCurrencyId);
    }
}