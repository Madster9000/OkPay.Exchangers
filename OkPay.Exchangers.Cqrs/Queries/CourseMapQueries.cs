using System;
using System.Data.Entity;
using System.Linq;
using OkPay.Exchangers.Cqrs.Contracts.CourseMap;
using OkPay.Exchangers.Model;

namespace OkPay.Exchangers.Cqrs.Queries
{
    public class CourseMapQueries : ICourseMapQueries
    {
        private readonly DbContext mContext;

        public CourseMapQueries(DbContext context)
        {
            mContext = context;
        }


        public IQueryable<CourseMap> SelectByCurrencies(Guid firstCurrencyId, Guid secondCurrencyId)
        {
            return
                mContext.Set<CourseMap>()
                    .Where
                    (
                        cm =>
                            cm.FirstCurrency.Id == firstCurrencyId
                            &&
                            cm.SecondCurrency.Id == secondCurrencyId
                    );
        }
    }
}