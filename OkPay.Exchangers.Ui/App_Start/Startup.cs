using System.Web.Http;
using Microsoft.Owin;
using Ninject;
using Ninject.Web.Common.OwinHost;
using Ninject.Web.WebApi.OwinHost;
using OkPay.Exchangers.Cqrs.Commands;
using OkPay.Exchangers.Cqrs.Queries;
using OkPay.Exchangers.DbContext;
using OkPay.Exchangers.Services.CourseMap;
using OkPay.Exchangers.Services.Currency;
using OkPay.Exchangers.Services.User;
using OkPay.Exchangers.Ui;
using Owin;

[assembly: OwinStartup(typeof(Startup))]
namespace OkPay.Exchangers.Ui
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureWebApi(app);
        }

        private void ConfigureWebApi(IAppBuilder app)
        {
            var apiConfiguration = new HttpConfiguration();
            apiConfiguration.Routes.MapHttpRoute
                (
                    name: "DefaultApi",
                    routeTemplate: "{controller}"
                );
            apiConfiguration.MapHttpAttributeRoutes();
            apiConfiguration.IncludeErrorDetailPolicy = IncludeErrorDetailPolicy.Always;

            app.UseNinjectMiddleware(CreatKernel).UseNinjectWebApi(apiConfiguration);
        }

        private IKernel CreatKernel()
        {
            var kernel = new StandardKernel();


            kernel.Bind<System.Data.Entity.DbContext>().To<OkPayContext>();
                

            kernel.Bind<IUsersService>().To<UsersService>();
            kernel.Bind<IUserCommands>().To<UserCommands>();
            kernel.Bind<IUserQueries>().To<UserQueries>();

            kernel.Bind<ICurrencyQueries>().To<CurrencyQueries>();
            kernel.Bind<ICurrenciesService>().To<CurrenciesService>();

            kernel.Bind<ICourseMapQueries>().To<CourseMapQueries>();
            kernel.Bind<ICourseMapService>().To<CourseMapService>();

            return kernel;
        }
    }
}
