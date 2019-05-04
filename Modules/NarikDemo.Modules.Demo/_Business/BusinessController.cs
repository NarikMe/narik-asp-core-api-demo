using NarikDemo.Data.Model;
using Narik.Common.Web.Infrastructure.OData;

namespace NarikDemo.Modules.Demo._Business
{
    public partial class BusinessController:NarikODataController<Business,
    BusinessViewModel,NarikDemoDomainService>
    {
        
    }
}
