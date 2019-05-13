using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Narik.Common.Shared.Models;
using NarikDemo.Data.Model;

namespace NarikDemo.Modules.Demo._Branch
{
    [AllowAnonymous] //TODO: just add to testing clients whit out need to authentication
    public partial class BranchController
    {
        public IQueryable<NarikDto> GetForSelector()
        {
            return DomainService.GetEntityList<Branch, NarikDto>();
        }
    }
}
