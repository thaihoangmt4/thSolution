using Microsoft.EntityFrameworkCore;

namespace thSolution.Entities.Mapping
{
    public partial class ProductImageMap
        : IEntityTypeConfiguration<thSolution.Entities.ProductImage>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<thSolution.Entities.ProductImage> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("ProductImage", "dbo");

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

            builder.Property(t => t.ImagePath)
                .IsRequired()
                .HasColumnName("ImagePath")
                .HasColumnType("nvarchar(200)")
                .HasMaxLength(200);

            builder.Property(t => t.Caption)
                .HasColumnName("Caption")
                .HasColumnType("nvarchar(200)")
                .HasMaxLength(200);

            builder.Property(t => t.IsDefault)
                .IsRequired()
                .HasColumnName("IsDefault")
                .HasColumnType("bit");

            builder.Property(t => t.SortOrder)
                .IsRequired()
                .HasColumnName("SortOrder")
                .HasColumnType("int");

            builder.Property(t => t.FileSize)
                .IsRequired()
                .HasColumnName("FileSize")
                .HasColumnType("bigint");

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
            builder.HasOne(t => t.Product)
                .WithMany(t => t.ProductImages)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_ProductImage_Product");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "ProductImage";
        }

        public struct Columns
        {
            public const string Id = "Id";
            public const string ProductId = "ProductId";
            public const string ImagePath = "ImagePath";
            public const string Caption = "Caption";
            public const string IsDefault = "IsDefault";
            public const string SortOrder = "SortOrder";
            public const string FileSize = "FileSize";
            public const string CreatedDate = "CreatedDate";
            public const string ModifiedDate = "ModifiedDate";
            public const string CreatedBy = "CreatedBy";
            public const string ModifiedBy = "ModifiedBy";
        }
        #endregion
    }
}
