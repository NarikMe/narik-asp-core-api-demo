
using System.Collections.Generic;
namespace NarikDemo.Data.Model
{
    public partial class Branch
    {
        
        public int BranchId { get; set; } 
        
        public string Address { get; set; } 
        
        public string City { get; set; } 
        
        public string Name { get; set; } 
        
        public string State { get; set; } 
        
        public string ZipCode { get; set; } 
        

        

        
        public ICollection<Account> Accounts { get; set; } 
        
        public ICollection<AccTransaction> AccTransactions { get; set; } 
        
        public ICollection<Employee> Employees { get; set; } 
        

    }
}
