using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace NarikDemo.Data.Model.Mapping
{
    public partial class CustomerMap : IEntityTypeConfiguration<Customer>
    {

        private readonly string _schema;
        public CustomerMap()
            : this("dbo")
        {
        }

        public CustomerMap(string schema)
        {
            this._schema = schema;
        }


        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("CUSTOMER", _schema);
            builder.HasKey(x => x.CustId);

            
            builder.Property(x => x.CustId).HasColumnName("CUST_ID").HasColumnType("int").IsRequired().UseSqlServerIdentityColumn();
            
            builder.Property(x => x.Address).HasColumnName("ADDRESS").HasColumnType("varchar").HasMaxLength(30);
            
            builder.Property(x => x.City).HasColumnName("CITY").HasColumnType("varchar").HasMaxLength(20);
            
            builder.Property(x => x.CustTypeCd).HasColumnName("CUST_TYPE_CD").HasColumnType("varchar").HasMaxLength(1).IsRequired();
            
            builder.Property(x => x.FedId).HasColumnName("FED_ID").HasColumnType("varchar").HasMaxLength(12).IsRequired();
            
            builder.Property(x => x.PostalCode).HasColumnName("POSTAL_CODE").HasColumnType("varchar").HasMaxLength(10);
            
            builder.Property(x => x.State).HasColumnName("STATE").HasColumnType("varchar").HasMaxLength(20);
            

            

            ConfigurePartial(builder);
        }

        partial void ConfigurePartial(EntityTypeBuilder<Customer> builder);

     
    }
}
