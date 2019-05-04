using NarikDemo.Data.Model;
using Narik.Common.Web.Infrastructure.OData;

namespace NarikDemo.Modules.Demo._Department
{
    public partial class DepartmentController:NarikODataController<Department,
    DepartmentViewModel,NarikDemoDomainService>
    {
        
    }
}
