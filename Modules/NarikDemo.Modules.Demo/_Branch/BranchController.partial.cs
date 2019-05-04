using System.Linq;
using Narik.Common.Shared.Models;
using NarikDemo.Data.Model;

namespace NarikDemo.Modules.Demo._Branch
{
    public partial class BranchController
    {
        public IQueryable<NarikDto> GetForSelector()
        {
            return DomainService.GetEntityList<Branch, NarikDto>();
        }
    }
}
