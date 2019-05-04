using Narik.Common.Shared.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace NarikDemo.Modules.Demo._Individual
{
    public partial class IndividualViewModel : INarikViewModel
    {
        public long ViewModelId { get => CustId; set => CustId = (int)value; }
        
		
        public System.DateTime? BirthDate { get; set; } 
        
		
        public string FirstName { get; set; } 
        
		
        public string LastName { get; set; } 
        
		[Key]
        public int CustId { get; set; } 
        
    }
}
