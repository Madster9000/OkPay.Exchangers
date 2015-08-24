using OkPay.Exchangers.Cqrs.Contracts.User;

namespace OkPay.Exchangers.Services.User
{
    public interface IUsersService
    {
        bool CanUserLogin(UserRequest request);
        bool IsLoginUnique(string login);
        void CreateUser(UserRequest request);
    }
}