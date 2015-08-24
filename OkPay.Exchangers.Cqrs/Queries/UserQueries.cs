using System.Data.Entity;
using System.Linq;
using OkPay.Exchangers.Cqrs.Contracts.User;
using OkPay.Exchangers.Model;

namespace OkPay.Exchangers.Cqrs.Queries
{
    public class UserQueries : IUserQueries
    {
        private readonly DbContext mContext;

        public UserQueries(DbContext context)
        {
            mContext = context;
        }

        public IQueryable<User> Find(UserRequest request)
        {
            return mContext.Set<User>().Where(u => u.Login == request.Login && u.Password == request.Password);
        }

        public IQueryable<User> FindByLogin(string login)
        {
            return mContext.Set<User>().Where(u => u.Login == login);

        }
    }
}