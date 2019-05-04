using System.Linq;
using Narik.Common.Shared.Models;
using NarikDemo.Data.Model;
using Narik.Common.Web.Infrastructure.OData;

namespace NarikDemo.Modules.Demo._Branch
{
    public partial class BranchController:NarikODataController<Branch,
    BranchViewModel,NarikDemoDomainService>
    {
       
    }
}
