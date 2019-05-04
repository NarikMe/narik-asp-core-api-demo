using System.Linq;
using Narik.Common.Shared.Models;
using NarikDemo.Data.Model;

namespace NarikDemo.Modules.Demo._Account
{
    public partial class AccountController
    {
        public IQueryable<NarikDto> GetForSelector()
        {
            return DomainService.GetEntityList<Account, NarikDto>();
        }
    }
}
