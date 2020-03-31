using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace NarikDemo.Data.Model.Mapping
{
    public partial class OfficerMap : IEntityTypeConfiguration<Officer>
    {

        private readonly string _schema;
        public OfficerMap()
            : this("dbo")
        {
        }

        public OfficerMap(string schema)
        {
            this._schema = schema;
        }


        public void Configure(EntityTypeBuilder<Officer> builder)
        {
            builder.ToTable("OFFICER", _schema);
            builder.HasKey(x => x.OfficerId);

            
            builder.Property(x => x.OfficerId).HasColumnName("OFFICER_ID").HasColumnType("int").IsRequired().UseIdentityColumn();
            
            builder.Property(x => x.EndDate).HasColumnName("END_DATE").HasColumnType("datetime");
            
            builder.Property(x => x.FirstName).HasColumnName("FIRST_NAME").HasColumnType("varchar").HasMaxLength(30).IsRequired();
            
            builder.Property(x => x.LastName).HasColumnName("LAST_NAME").HasColumnType("varchar").HasMaxLength(30).IsRequired();
            
            builder.Property(x => x.StartDate).HasColumnName("START_DATE").HasColumnType("datetime").IsRequired();
            
            builder.Property(x => x.Title).HasColumnName("TITLE").HasColumnType("varchar").HasMaxLength(20);
            
            builder.Property(x => x.CustId).HasColumnName("CUST_ID").HasColumnType("int");
            

            
            builder.HasOne(p => p.Cust)
            .WithMany(p => p.Officers).HasForeignKey(x => x.CustId);
            

            ConfigurePartial(builder);
        }

        partial void ConfigurePartial(EntityTypeBuilder<Officer> builder);

     
    }
}
