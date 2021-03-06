using Microsoft.EntityFrameworkCore;

namespace thSolution.Entities.Mapping
{
    public partial class ProductMap
        : IEntityTypeConfiguration<thSolution.Entities.Product>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<thSolution.Entities.Product> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Product", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Price)
                .IsRequired()
                .HasColumnName("Price")
                .HasColumnType("decimal(18,2)");

            builder.Property(t => t.OriginalPrice)
                .IsRequired()
                .HasColumnName("OriginalPrice")
                .HasColumnType("decimal(18,2)");

            builder.Property(t => t.Stock)
                .IsRequired()
                .HasColumnName("Stock")
                .HasColumnType("int");

            builder.Property(t => t.ViewCount)
                .IsRequired()
                .HasColumnName("ViewCount")
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
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "Product";
        }

        public struct Columns
        {
            public const string Id = "Id";
            public const string Price = "Price";
            public const string OriginalPrice = "OriginalPrice";
            public const string Stock = "Stock";
            public const string ViewCount = "ViewCount";
            public const string CreatedDate = "CreatedDate";
            public const string ModifiedDate = "ModifiedDate";
            public const string CreatedBy = "CreatedBy";
            public const string ModifiedBy = "ModifiedBy";
        }
        #endregion
    }
}
