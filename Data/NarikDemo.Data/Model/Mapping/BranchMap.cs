using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace NarikDemo.Data.Model.Mapping
{
    public partial class BranchMap : IEntityTypeConfiguration<Branch>
    {

        private readonly string _schema;
        public BranchMap()
            : this("dbo")
        {
        }

        public BranchMap(string schema)
        {
            this._schema = schema;
        }


        public void Configure(EntityTypeBuilder<Branch> builder)
        {
            builder.ToTable("BRANCH", _schema);
            builder.HasKey(x => x.BranchId);

            
            builder.Property(x => x.BranchId).HasColumnName("BRANCH_ID").HasColumnType("int").IsRequired().UseIdentityColumn();
            
            builder.Property(x => x.Address).HasColumnName("ADDRESS").HasColumnType("varchar").HasMaxLength(30);
            
            builder.Property(x => x.City).HasColumnName("CITY").HasColumnType("varchar").HasMaxLength(20);
            
            builder.Property(x => x.Name).HasColumnName("NAME").HasColumnType("varchar").HasMaxLength(20).IsRequired();
            
            builder.Property(x => x.State).HasColumnName("STATE").HasColumnType("varchar").HasMaxLength(10);
            
            builder.Property(x => x.ZipCode).HasColumnName("ZIP_CODE").HasColumnType("varchar").HasMaxLength(12);
            

            

            ConfigurePartial(builder);
        }

        partial void ConfigurePartial(EntityTypeBuilder<Branch> builder);

     
    }
}
