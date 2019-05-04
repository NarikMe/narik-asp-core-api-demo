using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Narik.Common.Shared.Models;

namespace NarikDemo.Modules.Demo.Controllers
{
    public class UserActionController : ControllerBase
    {
        private readonly NarikDemoDomainService _domainService;

        public UserActionController(NarikDemoDomainService domainService)
        {
            _domainService = domainService;
        }

        [HttpPost]
        public async Task<bool> UpdateRoles([FromBody]ValueHolder<int, int[]> roles)
        {
            return await _domainService.UpdateUserRoles(roles.Value, roles.Value1);
        }

        [HttpGet]
        public async Task<int> GetUserRole(int userId)
        {
            return await _domainService.GetUserRole(userId);
        }

        
    }
}
