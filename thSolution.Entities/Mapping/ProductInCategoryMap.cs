using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace thSolution.Entities.Mapping
{
    public class ProductInCategoryMap : IEntityTypeConfiguration<ProductInCategory>
    {
        public void Configure(EntityTypeBuilder<ProductInCategory> builder)
        {
            // table
            builder.ToTable("ProductInCategory");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
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

            // relationship
            builder.HasOne(t => t.Product)
                .WithMany(t => t.ProductInCategories)
                .HasForeignKey(t => t.ProductId)
                .HasConstraintName("FK_ProductInCategory_Product");

            builder.HasOne(t => t.Category)
                .WithMany(t => t.ProductInCategories)
                .HasForeignKey(t => t.CategoryId)
                .HasConstraintName("FK_ProductInCategory_Category");
        }
    }
}
