using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.OData.Query;
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
