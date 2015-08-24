using System;
using System.Data.Entity;
using OkPay.Exchangers.Cqrs.Contracts.User;
using OkPay.Exchangers.Model;

namespace OkPay.Exchangers.Cqrs.Commands
{
    public class UserCommands : IUserCommands
    {
        private readonly DbContext mContext;

        public UserCommands(DbContext context)
        {
            mContext = context;
        }

        public void CreateNew(UserRequest request)
        {
            var user = new User
            {
                Id = Guid.NewGuid(),
                Login = request.Login,
                Password = request.Password
            };

            mContext.Set<User>().Add(user);
            mContext.SaveChanges();
        }
    }
}