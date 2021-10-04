using Microsoft.EntityFrameworkCore;

namespace thSolution.Entities.Mapping
{
    public partial class ProductInCategoryMap
        : IEntityTypeConfiguration<thSolution.Entities.ProductInCategory>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<thSolution.Entities.ProductInCategory> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("ProductInCategory", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.ProductId)
                .IsRequired()
                .HasColumnName("ProductId")
                .HasColumnType("int");

            builder.Property(t => t.CategoryId)
                .IsRequired()
                .HasColumnName("CategoryId")
                .HasColumnType("int");

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
            builder.HasOne(t => t.Category)
                .WithMany(t => t.ProductInCategories)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK_ProductInCategory_Category");

            builder.HasOne(t => t.Product)
                .WithMany(t => t.ProductInCategories)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_ProductInCategory_Product");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "ProductInCategory";
        }

        public struct Columns
        {
            public const string Id = "Id";
            public const string ProductId = "ProductId";
            public const string CategoryId = "CategoryId";
            public const string CreatedDate = "CreatedDate";
            public const string ModifiedDate = "ModifiedDate";
            public const string CreatedBy = "CreatedBy";
            public const string ModifiedBy = "ModifiedBy";
        }
        #endregion
    }
}
