using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace NarikDemo.Data.Model.Mapping
{
    public partial class AccountMap : IEntityTypeConfiguration<Account>
    {

        private readonly string _schema;
        public AccountMap()
            : this("dbo")
        {
        }

        public AccountMap(string schema)
        {
            this._schema = schema;
        }


        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.ToTable("ACCOUNT", _schema);
            builder.HasKey(x => x.AccountId);

            
            builder.Property(x => x.AccountId).HasColumnName("ACCOUNT_ID").HasColumnType("int").IsRequired().UseSqlServerIdentityColumn();
            
            builder.Property(x => x.AvailBalance).HasColumnName("AVAIL_BALANCE").HasColumnType("float");
            
            builder.Property(x => x.CloseDate).HasColumnName("CLOSE_DATE").HasColumnType("datetime");
            
            builder.Property(x => x.LastActivityDate).HasColumnName("LAST_ACTIVITY_DATE").HasColumnType("datetime");
            
            builder.Property(x => x.OpenDate).HasColumnName("OPEN_DATE").HasColumnType("datetime").IsRequired();
            
            builder.Property(x => x.PendingBalance).HasColumnName("PENDING_BALANCE").HasColumnType("float");
            
            builder.Property(x => x.Status).HasColumnName("STATUS").HasColumnType("varchar").HasMaxLength(10);
            
            builder.Property(x => x.CustId).HasColumnName("CUST_ID").HasColumnType("int");
            
            builder.Property(x => x.OpenBranchId).HasColumnName("OPEN_BRANCH_ID").HasColumnType("int").IsRequired();
            
            builder.Property(x => x.OpenEmpId).HasColumnName("OPEN_EMP_ID").HasColumnType("int").IsRequired();
            
            builder.Property(x => x.ProductCd).HasColumnName("PRODUCT_CD").HasColumnType("varchar").HasMaxLength(10).IsRequired();
            

            
            builder.HasOne(p => p.OpenBranch)
            .WithMany(p => p.Accounts).HasForeignKey(x => x.OpenBranchId).IsRequired();
            
            builder.HasOne(p => p.Cust)
            .WithMany(p => p.Accounts).HasForeignKey(x => x.CustId);
            
            builder.HasOne(p => p.OpenEmp)
            .WithMany(p => p.Accounts).HasForeignKey(x => x.OpenEmpId).IsRequired();
            
            builder.HasOne(p => p.ProductCd1)
            .WithMany(p => p.Accounts).HasForeignKey(x => x.ProductCd).IsRequired();
            

            ConfigurePartial(builder);
        }

        partial void ConfigurePartial(EntityTypeBuilder<Account> builder);

     
    }
}
