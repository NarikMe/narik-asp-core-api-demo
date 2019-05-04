using Narik.Common.Shared.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace NarikDemo.Modules.Demo._Branch
{
    public partial class BranchViewModel : INarikViewModel
    {
        public long ViewModelId { get => BranchId; set => BranchId = (int)value; }
        
		[Key]
        public int BranchId { get; set; } 
        
		
        public string Address { get; set; } 
        
		
        public string City { get; set; } 
        
		
        public string Name { get; set; } 
        
		
        public string State { get; set; } 
        
		
        public string ZipCode { get; set; } 
        
    }
}
