namespace OkPay.Exchangers.Cqrs.Contracts.User
{
    public class UserResponse
    {
        public bool IsUserRegistered { get; set; }
        public bool IsUserLogedIn { get; set; }
        public string Description { get; set; }
    }
}