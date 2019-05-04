using System.Collections.Generic;

namespace NarikDemo.Data.Model
{
    public partial class Role
    {
        
        public int Id { get; set; } 
        
        public string Title { get; set; } 
        
        public bool IsActive { get; set; } 
        

        

        
        public ICollection<UserAccountRole> UserAccountRoles { get; set; } 
        

    }
}
