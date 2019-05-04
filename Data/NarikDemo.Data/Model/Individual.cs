

namespace NarikDemo.Data.Model
{
    public partial class Individual
    {
        
        public System.DateTime? BirthDate { get; set; } 
        
        public string FirstName { get; set; } 
        
        public string LastName { get; set; } 
        
        public int CustId { get; set; } 
        

        
        public Customer Cust { get; set; } 
        

        

    }
}
