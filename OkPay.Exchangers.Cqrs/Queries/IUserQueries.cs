using System.Linq;
using OkPay.Exchangers.Cqrs.Contracts.User;
using OkPay.Exchangers.Model;

namespace OkPay.Exchangers.Cqrs.Queries
{
    public interface IUserQueries
    {
        IQueryable<User> Find(UserRequest request);
        IQueryable<User> FindByLogin(string login);
    }
}