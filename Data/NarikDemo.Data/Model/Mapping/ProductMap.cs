using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace NarikDemo.Data.Model.Mapping
{
    public partial class ProductMap : IEntityTypeConfiguration<Product>
    {

        private readonly string _schema;
        public ProductMap()
            : this("dbo")
        {
        }

        public ProductMap(string schema)
        {
            this._schema = schema;
        }


        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("PRODUCT", _schema);
            builder.HasKey(x => x.ProductCd);

            
            builder.Property(x => x.ProductCd).HasColumnName("PRODUCT_CD").HasColumnType("varchar").HasMaxLength(10).IsRequired();
            
            builder.Property(x => x.DateOffered).HasColumnName("DATE_OFFERED").HasColumnType("datetime");
            
            builder.Property(x => x.DateRetired).HasColumnName("DATE_RETIRED").HasColumnType("datetime");
            
            builder.Property(x => x.Name).HasColumnName("NAME").HasColumnType("varchar").HasMaxLength(50).IsRequired();
            
            builder.Property(x => x.ProductTypeCd).HasColumnName("PRODUCT_TYPE_CD").HasColumnType("varchar").HasMaxLength(255);
            

            
            builder.HasOne(p => p.ProductTypeCd1)
            .WithMany(p => p.Products).HasForeignKey(x => x.ProductTypeCd);
            

            ConfigurePartial(builder);
        }

        partial void ConfigurePartial(EntityTypeBuilder<Product> builder);

     
    }
}
