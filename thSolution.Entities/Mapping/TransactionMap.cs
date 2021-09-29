using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace thSolution.Entities.Mapping
{
    public class TransactionMap : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.ToTable("Transaction");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

            builder.Property(t => t.CreatedDate)
                .IsRequired()
                .HasColumnName("CreatedDate")
                .HasColumnType("date");

            builder.Property(t => t.ModifiedDate)
                .HasColumnName("ModifiedDate")
                .HasColumnType("date");

            builder.Property(t => t.CreatedBy)
                .IsRequired()
                .HasColumnName("CreatedBy")
                .HasColumnType("character varying(255)")
                .HasMaxLength(255);

            builder.Property(t => t.ModifiedBy)
                .HasColumnName("ModifiedBy")
                .HasColumnType("character varying(255)")
                .HasMaxLength(255);

            builder.HasOne(x => x.Users)
                .WithMany(x => x.Transactions)
                .HasForeignKey(x => x.UserId)
                .HasConstraintName("FK_Transaction_User");
        }
    }
}
