using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Narik.Common.Data.DomainService;
using Narik.Common.Shared.Models;
using NarikDemo.Data.Model;
using NarikDemo.Modules.Demo._UserAccount;

namespace NarikDemo.Modules.Demo._Role
{
    //[NarikAuthorize(new []{Roles.SysAdmin})]
    public partial class RoleController
    {
        //[NarikOverrideAuthorize(new[] { Roles.SysAdmin,Roles.Admin,Roles.Staff })]
        public IQueryable<NarikDto> GetForSelector()
        {
            return DomainService.GetEntityList<Role, NarikDto>(r => r.IsActive);
        }


        protected override async Task<string> DoBeforeDeleteAsync(List<ChangeSetEntry> changes)
        {
            var ids = changes.Select(x => x.Entity).OfType<RoleViewModel>().Select(x => x.Id).ToList();
            var isAdminId = await DomainService.IsAdminRoleId(ids);
            if (isAdminId)
                return "errors.ADMIN_IS_NOT_EDITABLE";
            return null;
        }

    }
}
