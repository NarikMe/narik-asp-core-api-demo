using Narik.Common.Shared.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace NarikDemo.Modules.Demo._Account
{
    public partial class AccountViewModel : INarikViewModel
    {
        public long ViewModelId { get => AccountId; set => AccountId = (int)value; }
        
		[Key]
        public int AccountId { get; set; } 
        
		
        public double? AvailBalance { get; set; } 
        
		
        public System.DateTime? CloseDate { get; set; } 
        
		
        public System.DateTime? LastActivityDate { get; set; } 
        
		
        public System.DateTime OpenDate { get; set; } 
        
		
        public double? PendingBalance { get; set; } 
        
		
        public string Status { get; set; } 
        
		
        public int? CustId { get; set; } 
        
		
        public int OpenBranchId { get; set; } 
        
		
        public int OpenEmpId { get; set; } 
        
		
        public string ProductCd { get; set; } 
        
    }
}
