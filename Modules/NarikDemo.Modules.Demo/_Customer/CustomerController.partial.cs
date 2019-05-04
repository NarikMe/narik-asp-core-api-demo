using System.Linq;
using NarikDemo.Data.Model;

namespace NarikDemo.Modules.Demo._Customer
{
    public partial class CustomerController
    {
        public IQueryable<CustomerDto> GetForSelector()
        {
            return DomainService.GetEntityList<Customer, CustomerDto>(x=>x.Individuals.Any());
        }
    }
}
