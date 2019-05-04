using NarikDemo.Data.Model;
using Narik.Common.Web.Infrastructure.OData;

namespace NarikDemo.Modules.Demo._Officer
{
    public partial class OfficerController:NarikODataController<Officer,
    OfficerViewModel,NarikDemoDomainService>
    {
        
    }
}
