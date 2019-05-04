using NarikDemo.Data.Model;
using Narik.Common.Web.Infrastructure.OData;

namespace NarikDemo.Modules.Demo._Product
{
    public partial class ProductController: NarikPkTypeODataController<Product,
    ProductViewModel,string,NarikDemoDomainService>
    {
        
    }
}
