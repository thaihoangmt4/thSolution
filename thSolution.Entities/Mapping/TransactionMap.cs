using Microsoft.EntityFrameworkCore;

namespace thSolution.Entities.Mapping
{
    public partial class TransactionMap
        : IEntityTypeConfiguration<thSolution.Entities.Transaction>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<thSolution.Entities.Transaction> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Transaction", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.TracsactionDate)
                .IsRequired()
                .HasColumnName("TracsactionDate")
                .HasColumnType("datetime2");

            builder.Property(t => t.ExternalTracsactionId)
                .IsRequired()
                .HasColumnName("ExternalTracsactionId")
                .HasColumnType("int");

            builder.Property(t => t.Amount)
                .IsRequired()
                .HasColumnName("Amount")
                .HasColumnType("int");

            builder.Property(t => t.Fee)
                .IsRequired()
                .HasColumnName("Fee")
                .HasColumnType("decimal(18,2)");

            builder.Property(t => t.Result)
                .IsRequired()
                .HasColumnName("Result")
                .HasColumnType("bit");

            builder.Property(t => t.Message)
                .HasColumnName("Message")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.Status)
                .IsRequired()
                .HasColumnName("Status")
                .HasColumnType("int");

            builder.Property(t => t.Provider)
                .HasColumnName("Provider")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.UserId)
                .IsRequired()
                .HasColumnName("UserId")
                .HasColumnType("uniqueidentifier");

            builder.Property(t => t.CreatedDate)
                .IsRequired()
                .HasColumnName("CreatedDate")
                .HasColumnType("date");

            builder.Property(t => t.ModifiedDate)
                .IsRequired()
                .HasColumnName("ModifiedDate")
                .HasColumnType("date");

            builder.Property(t => t.CreatedBy)
                .IsRequired()
                .HasColumnName("CreatedBy")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.ModifiedBy)
                .HasColumnName("ModifiedBy")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            // relationships
            builder.HasOne(t => t.UserUsers)
                .WithMany(t => t.UserTransactions)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_Transaction_User");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "Transaction";
        }

        public struct Columns
        {
            public const string Id = "Id";
            public const string TracsactionDate = "TracsactionDate";
            public const string ExternalTracsactionId = "ExternalTracsactionId";
            public const string Amount = "Amount";
            public const string Fee = "Fee";
            public const string Result = "Result";
            public const string Message = "Message";
            public const string Status = "Status";
            public const string Provider = "Provider";
            public const string UserId = "UserId";
            public const string CreatedDate = "CreatedDate";
            public const string ModifiedDate = "ModifiedDate";
            public const string CreatedBy = "CreatedBy";
            public const string ModifiedBy = "ModifiedBy";
        }
        #endregion
    }
}
