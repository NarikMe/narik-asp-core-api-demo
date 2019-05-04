using NarikDemo.Data.Model;
using Narik.Common.Web.Infrastructure.OData;

namespace NarikDemo.Modules.Demo._Employee
{
    public partial class EmployeeController:NarikODataController<Employee,
    EmployeeViewModel,NarikDemoDomainService>
    {
        
    }
}
