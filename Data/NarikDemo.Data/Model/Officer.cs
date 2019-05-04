

namespace NarikDemo.Data.Model
{
    public partial class Officer
    {
        
        public int OfficerId { get; set; } 
        
        public System.DateTime? EndDate { get; set; } 
        
        public string FirstName { get; set; } 
        
        public string LastName { get; set; } 
        
        public System.DateTime StartDate { get; set; } 
        
        public string Title { get; set; } 
        
        public int? CustId { get; set; } 
        

        
        public Customer Cust { get; set; } 
        

        

    }
}
