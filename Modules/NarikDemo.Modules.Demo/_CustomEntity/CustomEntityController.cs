using NarikDemo.Data.Model;
using Narik.Common.Web.Infrastructure.OData;

namespace NarikDemo.Modules.Demo._CustomEntity
{
    public partial class CustomEntityController:NarikODataController<CustomEntity,
    CustomEntityViewModel,NarikDemoDomainService>
    {
        
    }
}
