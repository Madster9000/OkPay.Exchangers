using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using OkPay.Exchangers.Cqrs.Contracts;
using OkPay.Exchangers.Cqrs.Queries;
using OkPay.Exchangers.Services.Currency;

namespace OkPay.Exchangers.Ui.Controllers
{
    public class CurrenciesController : ApiController
    {
        private readonly ICurrenciesService mCurrenciesService;

        public CurrenciesController(ICurrenciesService currenciesService)
        {
            mCurrenciesService = currenciesService;
        }

        public IEnumerable<CurrencyResponse> GetAll()
        {
            return mCurrenciesService.SelectAll();
        }
    }
}
