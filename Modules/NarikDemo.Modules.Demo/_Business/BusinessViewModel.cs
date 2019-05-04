using Narik.Common.Shared.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace NarikDemo.Modules.Demo._Business
{
    public partial class BusinessViewModel : INarikViewModel
    {
        public long ViewModelId { get => CustId; set => CustId = (int)value; }
        
		
        public System.DateTime? IncorpDate { get; set; } 
        
		
        public string Name { get; set; } 
        
		
        public string StateId { get; set; }

        public string CustomerTitle { get; set; }
        
		[Key]
        public int CustId { get; set; } 
        
    }
}
