using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace thSolution.Entities.Mapping
{
    public class ProductImageMap : IEntityTypeConfiguration<ProductImage>
    {
        public void Configure(EntityTypeBuilder<ProductImage> builder)
        {
            builder.ToTable("ProductImage");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

            builder.Property(x => x.ImagePath)
                .HasMaxLength(200)
                .IsRequired(true);

            builder.Property(x => x.Caption)
                .HasMaxLength(200);

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

            builder.HasOne(x => x.Product)
                .WithMany(x => x.ProductImages)
                .HasForeignKey(x => x.ProductId)
                .HasConstraintName("FK_ProductImage_Product");
        }
    }
}
