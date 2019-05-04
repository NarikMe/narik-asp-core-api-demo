using NarikDemo.Data.Model;
using Narik.Common.Web.Infrastructure.OData;

namespace NarikDemo.Modules.Demo._AccTransaction
{
    public partial class AccTransactionController:NarikODataController<AccTransaction,
    AccTransactionViewModel,NarikDemoDomainService>
    {
        
    }
}
