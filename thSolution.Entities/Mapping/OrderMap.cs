using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace thSolution.Entities.Mapping
{
    public class OrderMap : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Order");

            builder.HasKey(t => t.Id);

            builder.Property(t => t.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

            builder.Property(t => t.OrderDate);

            builder.Property(t => t.UserId);

            builder.Property(t => t.ShipName)
                .IsUnicode(false)
                .HasMaxLength(40);

            builder.Property(t => t.ShipAddress)
                .IsUnicode(false)
                .HasMaxLength(100);

            builder.Property(t => t.ShipPhoneNumber)
                .IsUnicode(false)
                .HasMaxLength(10);

            builder.Property(t => t.ShipEmail)
                .IsUnicode(false)
                .HasMaxLength(60);

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

            // relationship
            builder.HasOne(t => t.Contact)
                .WithOne(t => t.Order)
                .HasForeignKey<Contact>(t => t.OrderId)
                .HasConstraintName("FK_Order_Contact");
        }
    }
}
