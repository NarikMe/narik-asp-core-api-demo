using Microsoft.AspNet.OData.Builder;
using Microsoft.AspNetCore.SignalR;
using Narik.Common.Infrastructure.Interfaces;
using Narik.Common.Services.Core;
using Narik.Common.Web.Infrastructure.OData;
using NarikDemo.Data;
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
        }

        public void RegisterOdataController(ODataModelBuilder builder)
        {
            ODataHelper.RegisterControllers(builder, GetType().Assembly);
        }

        public void RegisterSignalRHubs(HubRouteBuilder routes)
        {

        }
    }
}
