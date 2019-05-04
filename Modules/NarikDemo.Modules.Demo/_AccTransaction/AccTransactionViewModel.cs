using Narik.Common.Shared.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace NarikDemo.Modules.Demo._AccTransaction
{
    public partial class AccTransactionViewModel : INarikViewModel
    {
        public long ViewModelId { get => (long) TxnId; set => TxnId = (long)value; }
        
		[Key]
        public decimal TxnId { get; set; } 
        
		
        public double Amount { get; set; } 
        
		
        public System.DateTime FundsAvailDate { get; set; } 
        
		
        public System.DateTime TxnDate { get; set; } 
        
		
        public string TxnTypeCd { get; set; } 
        
		
        public int? AccountId { get; set; } 
        
		
        public int? ExecutionBranchId { get; set; } 
        
		
        public int? TellerEmpId { get; set; } 
        
    }
}
