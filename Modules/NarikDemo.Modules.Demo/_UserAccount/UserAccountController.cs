using Narik.Common.Web.Infrastructure.OData;
using NarikDemo.Data.Model;

namespace NarikDemo.Modules.Demo._UserAccount
{
    public partial class UserAccountController:NarikODataController<UserAccount,
    UserAccountViewModel,NarikDemoDomainService>
    {
        
    }
}
