using CommonServiceLocator;
using Narik.Common.Services.Core;
using NarikDemo.Modules.Demo.Models;

namespace NarikDemo.Modules.Demo
{
    public class SessionHelper
    {
        private static ISessionStorage _sessionStorage;
        public static ISessionStorage SessionStorage => _sessionStorage ?? (_sessionStorage = ServiceLocator.Current.GetInstance<ISessionStorage>());
        public static NarikDemoUser User => SessionStorage["User"] as NarikDemoUser;
    }
}
