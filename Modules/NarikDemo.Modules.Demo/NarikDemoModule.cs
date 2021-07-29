using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.SignalR;
using Microsoft.OData.ModelBuilder;
using Narik.Common.Services.Core;
using Narik.Common.Web.Infrastructure.Interfaces;
using Narik.Common.Web.Infrastructure.OData;
using NarikDemo.Data;
using NarikDemo.Modules.Demo.Models;
using NarikDemo.Modules.Demo.Services;
using Unity;
using Unity.Lifetime;

namespace NarikDemo.Modules.Demo
{
    public class NarikDemoModule : INarikWebModule
    {
        private readonly IUnityContainer _unityContainer;


        public NarikDemoModule(IUnityContainer unityContainer, IEnvironment environment)
        {
            _unityContainer = unityContainer;
            environment.AddModelAssembly(typeof(NarikDemoDbContext).Assembly);
        }

        public const string KEY = "NarikDemo";
        public string Key => KEY;
        public void Init()
        {
            _unityContainer.RegisterType<IAccountService, AccountService>(
                new ContainerControlledLifetimeManager());

            _unityContainer.Resolve<ISessionStorage>()
                .AddCallBack("User", x =>
                {
                    var ibnDomainService = _unityContainer.Resolve<NarikDemoDomainService>();
                    var httpContextAccessor = _unityContainer.Resolve<IHttpContextAccessor>();
                    var userId = httpContextAccessor.HttpContext.User.FindFirst("UserId").Value;
                    var userInfo = ibnDomainService.GetUserByUserId(Convert.ToInt32(userId));
                    return new NarikDemoUser
                    {
                        UserId = userInfo.Id,
                        Title = userInfo.Title,
                        UserName = userInfo.UserName
                    };
                });
        }

        public void RegisterOdataController(ODataModelBuilder builder)
        {
            ODataHelper.RegisterControllers(builder, GetType().Assembly);
        }

       
        public void RegisterSignalRHubs(IEndpointRouteBuilder configure)
        {
        }
    }
}
