using Microsoft.AspNetCore.Authorization;
using NarikDemo.Data.Model;
using Narik.Common.Web.Infrastructure.OData;

namespace NarikDemo.Modules.Demo._Department
{
    [AllowAnonymous] //TODO: just add to testing clients whit out need to authentication
    public partial class DepartmentController:NarikODataController<Department,
    DepartmentViewModel,NarikDemoDomainService>
    {
        
    }
}
