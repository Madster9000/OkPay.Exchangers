namespace OkPay.Exchangers.Cqrs.Contracts.User
{
    public class UserRequest
    {
        public string Login { get; set; }
        public string Password { get; set; }
    }
}