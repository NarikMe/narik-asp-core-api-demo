using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace NarikDemo.Data.Model.Mapping
{
    public partial class BusinessMap : IEntityTypeConfiguration<Business>
    {

        private readonly string _schema;
        public BusinessMap()
            : this("dbo")
        {
        }

        public BusinessMap(string schema)
        {
            this._schema = schema;
        }


        public void Configure(EntityTypeBuilder<Business> builder)
        {
            builder.ToTable("BUSINESS", _schema);
            builder.HasKey(x => x.CustId);

            
            builder.Property(x => x.IncorpDate).HasColumnName("INCORP_DATE").HasColumnType("datetime");
            
            builder.Property(x => x.Name).HasColumnName("NAME").HasColumnType("varchar").HasMaxLength(255).IsRequired();
            
            builder.Property(x => x.StateId).HasColumnName("STATE_ID").HasColumnType("varchar").HasMaxLength(10).IsRequired();
            
            builder.Property(x => x.CustId).HasColumnName("CUST_ID").HasColumnType("int").IsRequired();
            

            
            builder.HasOne(p => p.Cust)
            .WithMany(p => p.Businesss).HasForeignKey(x => x.CustId).IsRequired();
            

            ConfigurePartial(builder);
        }

        partial void ConfigurePartial(EntityTypeBuilder<Business> builder);

     
    }
}
