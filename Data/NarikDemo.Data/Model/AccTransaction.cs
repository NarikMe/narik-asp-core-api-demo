

namespace NarikDemo.Data.Model
{
    public partial class AccTransaction
    {
        
        public decimal TxnId { get; set; } 
        
        public double Amount { get; set; } 
        
        public System.DateTime FundsAvailDate { get; set; } 
        
        public System.DateTime TxnDate { get; set; } 
        
        public string TxnTypeCd { get; set; } 
        
        public int? AccountId { get; set; } 
        
        public int? ExecutionBranchId { get; set; } 
        
        public int? TellerEmpId { get; set; } 
        

        
        public Account Account { get; set; } 
        
        public Branch ExecutionBranch { get; set; } 
        
        public Employee TellerEmp { get; set; } 
        

        

    }
}
