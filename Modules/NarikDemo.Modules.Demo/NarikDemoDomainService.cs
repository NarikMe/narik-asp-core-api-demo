using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using Narik.Common.Data;
using Narik.Common.Shared.Models;
using NarikDemo.Data.Model;

namespace NarikDemo.Modules.Demo
{
    public class NarikDemoDomainService : BaseDomainService<NarikDemoDataService>
    {
        public async Task<string> GetPasswordByUserName(string userName)
        {
            return await DataService.DbContext.UserAccounts.Where(x => x.UserName == userName)
                .Select(x => x.Password).FirstOrDefaultAsync();
        }

        public async Task UpdateUserPassword(int userId, string password)
        {
            await DataService.UpdateUserPassword(userId, password);
        }

        public async Task<string> GetPasswordByUserId(int userId)
        {
            return await DataService.DbContext.UserAccounts.Where(x => x.Id == userId)
                .Select(x => x.Password).FirstOrDefaultAsync();
        }

        public UserAccount GetUserByUserId(int userId)
        {
            return DataService.DbContext.UserAccounts.FirstOrDefault(x => x.Id == userId);
        }

        public async Task<ApplicationUser> GetApplicationUserByUserName(string userName)
        {
            return await DataService.DbContext.UserAccounts.Where(x => x.UserName == userName)
                .ProjectTo<ApplicationUser>(this.MapperConfiguration).FirstOrDefaultAsync();
        }

        public async Task<bool> UpdateUserRoles(int userId, int[] roles)
        {
            if (userId != 4)
                return await DataService.UpdateUserRoles(userId, roles);
            return false;
        }

        public async Task<int> GetUserRole(int userId)
        {
            return await DataService.GetUserRole(userId);
        }

        public async Task<bool> ExistsUserName(string userName, int id)
        {
            return await DataService.DbContext.UserAccounts
                .AnyAsync(x => x.UserName == userName && x.Id != id);
        }

        public async  Task<bool> IsAdminId(List<int> ids)
        {
            return await DataService.DbContext.UserAccounts
                .AnyAsync(x => x.UserName == "admin" && ids.Contains(x.Id));
        }

        public async Task<bool> IsAdminRoleId(List<int> ids)
        {
            return await DataService.DbContext.Set<Role>()
                .AnyAsync(x => x.Title == "admin" && ids.Contains(x.Id));
        }
    }
}
