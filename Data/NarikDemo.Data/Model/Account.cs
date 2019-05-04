
using System.Collections.Generic;
namespace NarikDemo.Data.Model
{
    public partial class Account
    {
        
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
        

        
        public Branch OpenBranch { get; set; } 
        
        public Customer Cust { get; set; } 
        
        public Employee OpenEmp { get; set; } 
        
        public Product ProductCd1 { get; set; } 
        

        
        public ICollection<AccTransaction> AccTransactions { get; set; } 
        

    }
}
