using NarikDemo.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace NarikDemo.Data
{
    public partial class NarikDemoDbContext: DbContext
    {
        public NarikDemoDbContext()
        {
            
        }
        public NarikDemoDbContext( DbContextOptions options):base(options)
        {

        }

        
        public DbSet<Account> Accounts { get; set; }
        
        public DbSet<AccTransaction> AccTransactions { get; set; }
        
        public DbSet<Branch> Branchs { get; set; }
        
        public DbSet<Business> Businesss { get; set; }
        
        public DbSet<Customer> Customers { get; set; }
        
        public DbSet<Department> Departments { get; set; }
        
        public DbSet<Employee> Employees { get; set; }
        
        public DbSet<Individual> Individuals { get; set; }
        
        public DbSet<Officer> Officers { get; set; }
        
        public DbSet<Product> Products { get; set; }
        
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<UserAccount> UserAccounts { get; set; }
        public DbSet<UserAccountRole> UserAccountRoles { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
