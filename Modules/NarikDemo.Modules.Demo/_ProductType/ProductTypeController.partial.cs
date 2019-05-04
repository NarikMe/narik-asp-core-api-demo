using System.Linq;
using Narik.Common.Shared.Models;
using NarikDemo.Data.Model;

namespace NarikDemo.Modules.Demo._ProductType
{
    public partial class ProductTypeController
    {
        public IQueryable<ProductTypeDto> GetForSelector()
        {
            return DomainService.GetEntityList<ProductType, ProductTypeDto>();
        }
    }
}
