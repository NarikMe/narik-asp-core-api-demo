
using System.Collections.Generic;
namespace NarikDemo.Data.Model
{
    public partial class Product
    {
        
        public string ProductCd { get; set; } 
        
        public System.DateTime? DateOffered { get; set; } 
        
        public System.DateTime? DateRetired { get; set; } 
        
        public string Name { get; set; } 
        
        public string ProductTypeCd { get; set; } 
        

        
        public ProductType ProductTypeCd1 { get; set; } 
        

        
        public ICollection<Account> Accounts { get; set; } 
        

    }
}
