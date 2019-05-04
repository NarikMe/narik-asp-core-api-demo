using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Narik.Common.Data;
using NarikDemo.Data;
using NarikDemo.Data.Model;

namespace NarikDemo.Modules.Demo
{
    public class NarikDemoDataService : BaseDataService<NarikDemoDbContext>
    {
        public async Task UpdateUserPassword(int userId, string password)
        {
            await Update<UserAccount>(x => x.Id == userId, p => new UserAccount
            {
                Password = password
            });
        }

        public async Task<bool> UpdateUserRoles(int userId, int[] roles)
        {
            using (BeginTransaction())
            {
                DbContext.UserAccountRoles.RemoveRange(DbContext.UserAccountRoles.Where(x => x.UserAccountId == userId));
                foreach (var role in roles)
                {
                    DbContext.UserAccountRoles.Add(new UserAccountRole()
                    {
                        RoleId = role,
                        UserAccountId = userId
                    });
                }
                await DbContext.SaveChangesAsync();
                CommitTransaction();
            }
            return true;
        }

        public async Task<int> GetUserRole(int userId)
        {
            return await DbContext.UserAccountRoles
                .Where(x => x.UserAccountId == userId)
                .Select(x => x.RoleId).FirstOrDefaultAsync();
        }
    }
}
