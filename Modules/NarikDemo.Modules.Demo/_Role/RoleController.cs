using Narik.Common.Web.Infrastructure.OData;
using NarikDemo.Data.Model;

namespace NarikDemo.Modules.Demo._Role
{
    public partial class RoleController:NarikODataController<Role,
    RoleViewModel, NarikDemoDomainService>
    {
        
    }
}
