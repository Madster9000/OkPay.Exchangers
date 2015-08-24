using System.Linq;
using OkPay.Exchangers.Cqrs.Commands;
using OkPay.Exchangers.Cqrs.Contracts.User;
using OkPay.Exchangers.Cqrs.Queries;

namespace OkPay.Exchangers.Services.User
{
    public class UsersService : IUsersService
    {
        private readonly IUserQueries mUserQueries;
        private readonly IUserCommands mUserCommands;

        public UsersService(IUserQueries userQueries, IUserCommands userCommands)
        {
            mUserQueries = userQueries;
            mUserCommands = userCommands;
        }

        public bool CanUserLogin(UserRequest request)
        {
            return mUserQueries.Find(request).Any();
        }

        public bool IsLoginUnique(string login)
        {
            return !mUserQueries.FindByLogin(login).Any();
        }

        public void CreateUser(UserRequest request)
        {
            mUserCommands.CreateNew(request);
        }
    }
}