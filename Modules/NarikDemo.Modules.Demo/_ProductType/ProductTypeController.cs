using NarikDemo.Data.Model;
using Narik.Common.Web.Infrastructure.OData;

namespace NarikDemo.Modules.Demo._ProductType
{
    public partial class ProductTypeController: NarikPkTypeODataController<ProductType,
    ProductTypeViewModel,string,NarikDemoDomainService>
    {
        
    }
}
