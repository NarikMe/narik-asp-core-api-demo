using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace NarikDemo.Data.Model.Mapping
{
    public partial class EmployeeMap : IEntityTypeConfiguration<Employee>
    {

        private readonly string _schema;
        public EmployeeMap()
            : this("dbo")
        {
        }

        public EmployeeMap(string schema)
        {
            this._schema = schema;
        }


        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("EMPLOYEE", _schema);
            builder.HasKey(x => x.EmpId);

            
            builder.Property(x => x.EmpId).HasColumnName("EMP_ID").HasColumnType("int").IsRequired().UseIdentityColumn();
            
            builder.Property(x => x.EndDate).HasColumnName("END_DATE").HasColumnType("datetime");
            
            builder.Property(x => x.FirstName).HasColumnName("FIRST_NAME").HasColumnType("varchar").HasMaxLength(20).IsRequired();
            
            builder.Property(x => x.LastName).HasColumnName("LAST_NAME").HasColumnType("varchar").HasMaxLength(20).IsRequired();
            
            builder.Property(x => x.StartDate).HasColumnName("START_DATE").HasColumnType("datetime").IsRequired();
            
            builder.Property(x => x.Title).HasColumnName("TITLE").HasColumnType("varchar").HasMaxLength(20);
            
            builder.Property(x => x.AssignedBranchId).HasColumnName("ASSIGNED_BRANCH_ID").HasColumnType("int");
            
            builder.Property(x => x.DeptId).HasColumnName("DEPT_ID").HasColumnType("int");
            
            builder.Property(x => x.SuperiorEmpId).HasColumnName("SUPERIOR_EMP_ID").HasColumnType("int");
            

            
            builder.HasOne(p => p.AssignedBranch)
            .WithMany(p => p.Employees).HasForeignKey(x => x.AssignedBranchId);
            
            builder.HasOne(p => p.Dept)
            .WithMany(p => p.Employees).HasForeignKey(x => x.DeptId);
            
            builder.HasOne(p => p.ParentSuperiorEmp)
            .WithMany(p => p.Employees).HasForeignKey(x => x.SuperiorEmpId);
            

            ConfigurePartial(builder);
        }

        partial void ConfigurePartial(EntityTypeBuilder<Employee> builder);

     
    }
}
