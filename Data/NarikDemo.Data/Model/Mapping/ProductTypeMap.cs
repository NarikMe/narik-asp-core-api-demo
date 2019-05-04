using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace NarikDemo.Data.Model.Mapping
{
    public partial class ProductTypeMap : IEntityTypeConfiguration<ProductType>
    {

        private readonly string _schema;
        public ProductTypeMap()
            : this("dbo")
        {
        }

        public ProductTypeMap(string schema)
        {
            this._schema = schema;
        }


        public void Configure(EntityTypeBuilder<ProductType> builder)
        {
            builder.ToTable("PRODUCT_TYPE", _schema);
            builder.HasKey(x => x.ProductTypeCd);

            
            builder.Property(x => x.ProductTypeCd).HasColumnName("PRODUCT_TYPE_CD").HasColumnType("varchar").HasMaxLength(255).IsRequired();
            
            builder.Property(x => x.Name).HasColumnName("NAME").HasColumnType("varchar").HasMaxLength(50);
            

            

            ConfigurePartial(builder);
        }

        partial void ConfigurePartial(EntityTypeBuilder<ProductType> builder);

     
    }
}
