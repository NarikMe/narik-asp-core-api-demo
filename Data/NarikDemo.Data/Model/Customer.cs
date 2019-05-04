
using System.Collections.Generic;
namespace NarikDemo.Data.Model
{
    public partial class Customer
    {
        
        public int CustId { get; set; } 
        
        public string Address { get; set; } 
        
        public string City { get; set; } 
        
        public string CustTypeCd { get; set; } 
        
        public string FedId { get; set; } 
        
        public string PostalCode { get; set; } 
        
        public string State { get; set; } 
        

        

        
        public ICollection<Account> Accounts { get; set; } 
        
        public ICollection<Business> Businesss { get; set; } 
        
        public ICollection<Individual> Individuals { get; set; } 
        
        public ICollection<Officer> Officers { get; set; } 
        

    }
}
