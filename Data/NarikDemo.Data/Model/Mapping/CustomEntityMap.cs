using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace NarikDemo.Data.Model.Mapping
{
    public partial class CustomEntityMap : IEntityTypeConfiguration<CustomEntity>
    {

        private readonly string _schema;
        public CustomEntityMap()
            : this("dbo")
        {
        }

        public CustomEntityMap(string schema)
        {
            this._schema = schema;
        }


        public void Configure(EntityTypeBuilder<CustomEntity> builder)
        {
            builder.ToTable("CustomEntity", _schema);
            builder.HasKey(x => x.Id);

            
            builder.Property(x => x.Id).HasColumnName("Id").HasColumnType("int").IsRequired().UseIdentityColumn();
            
            builder.Property(x => x.LName).HasColumnName("LName").HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
            
            builder.Property(x => x.FName).HasColumnName("FName").HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
            

            

            ConfigurePartial(builder);
        }

        partial void ConfigurePartial(EntityTypeBuilder<CustomEntity> builder);

     
    }
}
