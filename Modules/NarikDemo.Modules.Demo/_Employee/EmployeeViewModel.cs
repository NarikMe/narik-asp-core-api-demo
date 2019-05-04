using Narik.Common.Shared.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace NarikDemo.Modules.Demo._Employee
{
    public partial class EmployeeViewModel : INarikViewModel
    {
        public long ViewModelId { get => EmpId; set => EmpId = (int)value; }
        
		[Key]
        public int EmpId { get; set; } 
        
		
        public System.DateTime? EndDate { get; set; } 
        
		
        public string FirstName { get; set; } 
        
		
        public string LastName { get; set; } 
        
		
        public System.DateTime StartDate { get; set; } 
        
		
        public string Title { get; set; } 
        
		
        public int? AssignedBranchId { get; set; } 
        
		
        public int? DeptId { get; set; } 
        
		
        public int? SuperiorEmpId { get; set; } 
        
    }
}
