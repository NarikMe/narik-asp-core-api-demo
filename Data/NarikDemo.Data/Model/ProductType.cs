
using System.Collections.Generic;
namespace NarikDemo.Data.Model
{
    public partial class ProductType
    {
        
        public string ProductTypeCd { get; set; } 
        
        public string Name { get; set; } 
        

        

        
        public ICollection<Product> Products { get; set; } 
        

    }
}
