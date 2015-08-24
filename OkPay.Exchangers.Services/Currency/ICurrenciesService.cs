using System.Collections.Generic;
using OkPay.Exchangers.Cqrs.Contracts;

namespace OkPay.Exchangers.Services.Currency
{
    public interface ICurrenciesService
    {
        IEnumerable<CurrencyResponse> SelectAll();
    }
}