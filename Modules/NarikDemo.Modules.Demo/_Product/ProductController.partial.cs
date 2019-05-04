using System.Linq;
using Narik.Common.Shared.Models;
using NarikDemo.Data.Model;

namespace NarikDemo.Modules.Demo._Product
{
    public partial class ProductController
    {
        public IQueryable<ProductDto> GetForSelector()
        {
            return DomainService.GetEntityList<Product, ProductDto>();
        }
    }
}
