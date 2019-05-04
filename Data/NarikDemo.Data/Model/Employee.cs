
using System.Collections.Generic;
namespace NarikDemo.Data.Model
{
    public partial class Employee
    {
        
        public int EmpId { get; set; } 
        
        public System.DateTime? EndDate { get; set; } 
        
        public string FirstName { get; set; } 
        
        public string LastName { get; set; } 
        
        public System.DateTime StartDate { get; set; } 
        
        public string Title { get; set; } 
        
        public int? AssignedBranchId { get; set; } 
        
        public int? DeptId { get; set; } 
        
        public int? SuperiorEmpId { get; set; } 
        

        
        public Branch AssignedBranch { get; set; } 
        
        public Department Dept { get; set; } 
        
        public Employee ParentSuperiorEmp { get; set; } 
        

        
        public ICollection<Account> Accounts { get; set; } 
        
        public ICollection<AccTransaction> AccTransactions { get; set; } 
        
        public ICollection<Employee> Employees { get; set; } 
        

    }
}
