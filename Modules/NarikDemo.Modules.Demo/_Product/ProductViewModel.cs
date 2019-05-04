using Narik.Common.Shared.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace NarikDemo.Modules.Demo._Product
{
    public partial class ProductViewModel : INarikViewModel<string>
    {
        public string ViewModelId { get => ProductCd; set => ProductCd = value; }
        
		[Key]
        public string ProductCd { get; set; } 
        
		
        public System.DateTime? DateOffered { get; set; } 
        
		
        public System.DateTime? DateRetired { get; set; } 
        
		
        public string Name { get; set; } 
        
		
        public string ProductTypeCd { get; set; } 
        
    }
}
