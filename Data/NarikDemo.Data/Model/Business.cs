

namespace NarikDemo.Data.Model
{
    public partial class Business
    {
        
        public System.DateTime? IncorpDate { get; set; } 
        
        public string Name { get; set; } 
        
        public string StateId { get; set; } 
        
        public int CustId { get; set; } 
        

        
        public Customer Cust { get; set; } 
        

        

    }
}
