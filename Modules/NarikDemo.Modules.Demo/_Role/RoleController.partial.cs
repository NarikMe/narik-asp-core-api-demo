using System.Collections.Generic;
using System.Linq;
using Narik.Common.Shared.Models;
using NarikDemo.Data.Model;

namespace NarikDemo.Modules.Demo._Role
{
    //[NarikAuthorize(new []{Roles.SysAdmin})]
    public partial class RoleController
    {
        //[NarikOverrideAuthorize(new[] { Roles.SysAdmin,Roles.Admin,Roles.Staff })]
        public IQueryable<NarikDto> GetForSelector()
        {
               return DomainService.GetEntityList<Role, NarikDto>();
           
        }

        
    }
}
