using Narik.Common.Shared.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace NarikDemo.Modules.Demo._ProductType
{
    public partial class ProductTypeViewModel : INarikViewModel<string>
    {
        public string ViewModelId { get => ProductTypeCd; set => ProductTypeCd = value; }
        
		[Key]
        public string ProductTypeCd { get; set; } 
        
		
        public string Name { get; set; } 
        
    }
}
