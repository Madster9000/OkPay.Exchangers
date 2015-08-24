using System.Collections.Generic;
using System.Linq;
using OkPay.Exchangers.Cqrs.Contracts;
using OkPay.Exchangers.Cqrs.Queries;

namespace OkPay.Exchangers.Services.Currency
{
    public class CurrenciesService : ICurrenciesService
    {
        private readonly ICurrencyQueries mCurrencyQueries;

        public CurrenciesService(ICurrencyQueries currencyQueries)
        {
            mCurrencyQueries = currencyQueries;
        }

        public IEnumerable<CurrencyResponse> SelectAll()
        {
            return mCurrencyQueries.SelectAll().Select(c => new CurrencyResponse
            {
                Id = c.Id,
                Name = c.Name
            });
        }
    }
}