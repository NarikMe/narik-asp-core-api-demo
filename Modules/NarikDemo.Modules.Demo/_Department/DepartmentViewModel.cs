using Narik.Common.Shared.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace NarikDemo.Modules.Demo._Department
{
    public partial class DepartmentViewModel : INarikViewModel
    {
        public long ViewModelId { get => DeptId; set => DeptId = (int)value; }
        
		[Key]
        public int DeptId { get; set; } 
        
		
        public string Name { get; set; } 
        
    }
}
