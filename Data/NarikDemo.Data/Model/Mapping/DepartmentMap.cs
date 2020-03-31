using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace NarikDemo.Data.Model.Mapping
{
    public partial class DepartmentMap : IEntityTypeConfiguration<Department>
    {

        private readonly string _schema;
        public DepartmentMap()
            : this("dbo")
        {
        }

        public DepartmentMap(string schema)
        {
            this._schema = schema;
        }


        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.ToTable("DEPARTMENT", _schema);
            builder.HasKey(x => x.DeptId);

            
            builder.Property(x => x.DeptId).HasColumnName("DEPT_ID").HasColumnType("int").IsRequired().UseIdentityColumn();
            
            builder.Property(x => x.Name).HasColumnName("NAME").HasColumnType("varchar").HasMaxLength(20).IsRequired();
            

            

            ConfigurePartial(builder);
        }

        partial void ConfigurePartial(EntityTypeBuilder<Department> builder);

     
    }
}
