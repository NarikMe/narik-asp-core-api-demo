
using System.Collections.Generic;
namespace NarikDemo.Data.Model
{
    public partial class Department
    {
        
        public int DeptId { get; set; } 
        
        public string Name { get; set; } 
        

        

        
        public ICollection<Employee> Employees { get; set; } 
        

    }
}
