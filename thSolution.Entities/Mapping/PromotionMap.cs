using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace thSolution.Entities.Mapping
{
    public class PromotionMap : IEntityTypeConfiguration<Promotion>
    {
        public void Configure(EntityTypeBuilder<Promotion> builder)
        {
            // table
            builder.ToTable("Promotion");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

            builder.Property(t => t.FromDate)
                .IsRequired()
                .HasColumnType("date");

            builder.Property(t => t.ToDate)
                .IsRequired()
                .HasColumnType("date");

            builder.Property(t => t.ApplyToAll)
                .HasDefaultValue(false);

            builder.Property(t => t.DiscountAmount)
                .IsRequired()
                .HasColumnType("character varying(255)")
                .HasMaxLength(255);

            builder.Property(t => t.DiscountPercent)
                .IsRequired()
                .HasColumnType("character varying(10)")
                .HasMaxLength(10);

            builder.Property(t => t.Name)
                .IsRequired()
                .HasColumnType("character varying(255)")
                .HasMaxLength(255);

            builder.Property(t => t.ProductIds)
                .IsRequired()
                .HasColumnType("character varying(255)")
                .HasMaxLength(255);

            builder.Property(t => t.ProductCategoryIds)
                .IsRequired()
                .HasColumnType("character varying(255)")
                .HasMaxLength(255);

            builder.Property(t => t.Status);

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
        }
    }
}
