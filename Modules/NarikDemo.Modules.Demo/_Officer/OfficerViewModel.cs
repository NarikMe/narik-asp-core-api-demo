using Narik.Common.Shared.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace NarikDemo.Modules.Demo._Officer
{
    public partial class OfficerViewModel : INarikViewModel
    {
        public long ViewModelId { get => OfficerId; set => OfficerId = (int)value; }
        
		[Key]
        public int OfficerId { get; set; } 
        
		
        public System.DateTime? EndDate { get; set; } 
        
		
        public string FirstName { get; set; } 
        
		
        public string LastName { get; set; } 
        
		
        public System.DateTime StartDate { get; set; } 
        
		
        public string Title { get; set; } 
        
		
        public int? CustId { get; set; } 
        
    }
}
