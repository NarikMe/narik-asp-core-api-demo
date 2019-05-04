using NarikDemo.Data.Model;
using Narik.Common.Web.Infrastructure.OData;

namespace NarikDemo.Modules.Demo._Individual
{
    public partial class IndividualController:NarikODataController<Individual,
    IndividualViewModel,NarikDemoDomainService>
    {
        
    }
}
