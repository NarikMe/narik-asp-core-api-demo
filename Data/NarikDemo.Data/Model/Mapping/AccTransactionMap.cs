using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace NarikDemo.Data.Model.Mapping
{
    public partial class AccTransactionMap : IEntityTypeConfiguration<AccTransaction>
    {

        private readonly string _schema;
        public AccTransactionMap()
            : this("dbo")
        {
        }

        public AccTransactionMap(string schema)
        {
            this._schema = schema;
        }


        public void Configure(EntityTypeBuilder<AccTransaction> builder)
        {
            builder.ToTable("ACC_TRANSACTION", _schema);
            builder.HasKey(x => x.TxnId);

            
            builder.Property(x => x.TxnId).HasColumnName("TXN_ID").HasColumnType("numeric").IsRequired().UseIdentityColumn();
            
            builder.Property(x => x.Amount).HasColumnName("AMOUNT").HasColumnType("float").IsRequired();
            
            builder.Property(x => x.FundsAvailDate).HasColumnName("FUNDS_AVAIL_DATE").HasColumnType("datetime").IsRequired();
            
            builder.Property(x => x.TxnDate).HasColumnName("TXN_DATE").HasColumnType("datetime").IsRequired();
            
            builder.Property(x => x.TxnTypeCd).HasColumnName("TXN_TYPE_CD").HasColumnType("varchar").HasMaxLength(10);
            
            builder.Property(x => x.AccountId).HasColumnName("ACCOUNT_ID").HasColumnType("int");
            
            builder.Property(x => x.ExecutionBranchId).HasColumnName("EXECUTION_BRANCH_ID").HasColumnType("int");
            
            builder.Property(x => x.TellerEmpId).HasColumnName("TELLER_EMP_ID").HasColumnType("int");
            

            
            builder.HasOne(p => p.Account)
            .WithMany(p => p.AccTransactions).HasForeignKey(x => x.AccountId);
            
            builder.HasOne(p => p.ExecutionBranch)
            .WithMany(p => p.AccTransactions).HasForeignKey(x => x.ExecutionBranchId);
            
            builder.HasOne(p => p.TellerEmp)
            .WithMany(p => p.AccTransactions).HasForeignKey(x => x.TellerEmpId);
            

            ConfigurePartial(builder);
        }

        partial void ConfigurePartial(EntityTypeBuilder<AccTransaction> builder);

     
    }
}
