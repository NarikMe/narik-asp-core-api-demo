using Narik.Common.Shared.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace NarikDemo.Modules.Demo._Customer
{
    public partial class CustomerViewModel : INarikViewModel
    {
        public long ViewModelId { get => CustId; set => CustId = (int)value; }
        
		[Key]
        public int CustId { get; set; } 
        
		
        public string Address { get; set; } 
        
		
        public string City { get; set; } 
        
		
        public string CustTypeCd { get; set; } 
        
		
        public string FedId { get; set; } 
        
		
        public string PostalCode { get; set; } 
        
		
        public string State { get; set; } 
        
    }
}
