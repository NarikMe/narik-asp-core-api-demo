using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace NarikDemo.Data.Model.Mapping
{
    public partial class IndividualMap : IEntityTypeConfiguration<Individual>
    {

        private readonly string _schema;
        public IndividualMap()
            : this("dbo")
        {
        }

        public IndividualMap(string schema)
        {
            this._schema = schema;
        }


        public void Configure(EntityTypeBuilder<Individual> builder)
        {
            builder.ToTable("INDIVIDUAL", _schema);
            builder.HasKey(x => x.CustId);

            
            builder.Property(x => x.BirthDate).HasColumnName("BIRTH_DATE").HasColumnType("datetime");
            
            builder.Property(x => x.FirstName).HasColumnName("FIRST_NAME").HasColumnType("varchar").HasMaxLength(30).IsRequired();
            
            builder.Property(x => x.LastName).HasColumnName("LAST_NAME").HasColumnType("varchar").HasMaxLength(30).IsRequired();
            
            builder.Property(x => x.CustId).HasColumnName("CUST_ID").HasColumnType("int").IsRequired();
            

            
            builder.HasOne(p => p.Cust)
            .WithMany(p => p.Individuals).HasForeignKey(x => x.CustId).IsRequired();
            

            ConfigurePartial(builder);
        }

        partial void ConfigurePartial(EntityTypeBuilder<Individual> builder);

     
    }
}
