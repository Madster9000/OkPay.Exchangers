using OkPay.Exchangers.Cqrs.Contracts.User;

namespace OkPay.Exchangers.Cqrs.Commands
{
    public interface IUserCommands
    {
        void CreateNew(UserRequest request);
    }
}