using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using OkPay.Exchangers.Cqrs.Commands;
using OkPay.Exchangers.Cqrs.Contracts.User;
using OkPay.Exchangers.Cqrs.Queries;
using OkPay.Exchangers.Services.User;

namespace OkPay.Exchangers.Ui.Controllers
{
    public class AccountsController : ApiController
    {
        private readonly IUsersService mUsersService;

        public AccountsController(IUsersService usersService)
        {
            mUsersService = usersService;
        }

        [Route("accounts/{login}")]
        public UserResponse GetIsLoginUnique(string login)
        {
            return new UserResponse {IsUserRegistered = mUsersService.IsLoginUnique(login)};
        }

        [Route("accounts/register")]
        public UserResponse PostRegisteredUser(UserRequest request)
        {
            try
            {
                mUsersService.CreateUser(request);
                return new UserResponse
                {
                    IsUserRegistered = true,
                    Description = "Поздравляем, вы прошли регистрацию."
                };
            }
            catch (Exception e)
            {
                return new UserResponse
                {
                    IsUserRegistered = false,
                    Description = "Произошла ошибка при создании пользователя."
                };
            }
            

        }

        [Route("accounts/login")]
        public UserResponse PostLoginUser(UserRequest request)
        {
            try
            {
                var canUserLogin = mUsersService.CanUserLogin(request);
                return new UserResponse
                {
                    IsUserLogedIn = canUserLogin,
                    Description = canUserLogin ? "Пользователь вошёл" : "Пользователь не зарегистрирован"
                };
            }
            catch (Exception)
            {
                return new UserResponse
                {
                    IsUserLogedIn = false,
                    Description = "Произошла ошибка при авторизации."
                };
            }
            
        }
    }
}
