using System.Data.Entity;
using System.Linq;
using OkPay.Exchangers.Cqrs.Contracts;
using OkPay.Exchangers.Model;

namespace OkPay.Exchangers.Cqrs.Queries
{
    public class CurrencyQueries : ICurrencyQueries
    {
        private readonly DbContext mContext;

        public CurrencyQueries(DbContext context)
        {
            mContext = context;
        }

        public IQueryable<Currency> SelectAll()
        {
            return mContext.Set<Currency>();
        }
    }
}