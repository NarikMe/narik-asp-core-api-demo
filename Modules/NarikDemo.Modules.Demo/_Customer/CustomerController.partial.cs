using System.Linq;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Authorization;
using NarikDemo.Data.Model;

namespace NarikDemo.Modules.Demo._Customer
{
    public partial class CustomerController
    {
        [EnableQuery]
        public IQueryable<CustomerDto> GetForSelector()
        {
            return DomainService.GetEntityList<Customer, CustomerDto>(x=>x.Individuals.Any());
        }
    }
}
