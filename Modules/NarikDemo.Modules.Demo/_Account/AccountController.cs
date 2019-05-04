using NarikDemo.Data.Model;
using Narik.Common.Web.Infrastructure.OData;

namespace NarikDemo.Modules.Demo._Account
{
    public partial class AccountController:NarikODataController<Account,
    AccountViewModel, AccountListViewModel, NarikDemoDomainService>
    {
        
    }
}
