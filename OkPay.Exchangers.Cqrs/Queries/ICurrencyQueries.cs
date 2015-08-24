using System.Linq;
using OkPay.Exchangers.Cqrs.Contracts;
using OkPay.Exchangers.Model;

namespace OkPay.Exchangers.Cqrs.Queries
{
    public interface ICurrencyQueries
    {
        IQueryable<Currency> SelectAll();
    }
}