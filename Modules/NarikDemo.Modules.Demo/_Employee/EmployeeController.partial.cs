using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Narik.Common.Shared.Models;
using NarikDemo.Data.Model;

namespace NarikDemo.Modules.Demo._Employee
{
    [AllowAnonymous] //TODO: just add to testing clients whit out need to authentication
    public partial class EmployeeController
    {
        public IQueryable<NarikDto> GetForSelector()
        {
            return DomainService.GetEntityList<Employee, NarikDto>();
        }
    }
}
