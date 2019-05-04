using NarikDemo.Data.Model;
using Narik.Common.Web.Infrastructure.OData;

namespace NarikDemo.Modules.Demo._Customer
{
    public partial class CustomerController:NarikODataController<Customer,
    CustomerViewModel,NarikDemoDomainService>
    {
        
    }
}
