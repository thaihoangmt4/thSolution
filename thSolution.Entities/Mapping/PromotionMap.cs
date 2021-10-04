using Microsoft.EntityFrameworkCore;

namespace thSolution.Entities.Mapping
{
    public partial class PromotionMap
        : IEntityTypeConfiguration<thSolution.Entities.Promotion>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<thSolution.Entities.Promotion> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Promotion", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.FromDate)
                .IsRequired()
                .HasColumnName("FromDate")
                .HasColumnType("date");

            builder.Property(t => t.ToDate)
                .IsRequired()
                .HasColumnName("ToDate")
                .HasColumnType("date");

            builder.Property(t => t.ApplyToAll)
                .IsRequired()
                .HasColumnName("ApplyToAll")
                .HasColumnType("bit")
                .HasDefaultValueSql("(CONVERT([bit],(0)))");

            builder.Property(t => t.DiscountPercent)
                .IsRequired()
                .HasColumnName("DiscountPercent")
                .HasColumnType("varchar(10)")
                .HasMaxLength(10);

            builder.Property(t => t.DiscountAmount)
                .IsRequired()
                .HasColumnName("DiscountAmount")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.ProductIds)
                .IsRequired()
                .HasColumnName("ProductIds")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.ProductCategoryIds)
                .IsRequired()
                .HasColumnName("ProductCategoryIds")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.Status)
                .IsRequired()
                .HasColumnName("Status")
                .HasColumnType("int");

            builder.Property(t => t.Name)
                .IsRequired()
                .HasColumnName("Name")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

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
            public const string Name = "Promotion";
        }

        public struct Columns
        {
            public const string Id = "Id";
            public const string FromDate = "FromDate";
            public const string ToDate = "ToDate";
            public const string ApplyToAll = "ApplyToAll";
            public const string DiscountPercent = "DiscountPercent";
            public const string DiscountAmount = "DiscountAmount";
            public const string ProductIds = "ProductIds";
            public const string ProductCategoryIds = "ProductCategoryIds";
            public const string Status = "Status";
            public const string Name = "Name";
            public const string CreatedDate = "CreatedDate";
            public const string ModifiedDate = "ModifiedDate";
            public const string CreatedBy = "CreatedBy";
            public const string ModifiedBy = "ModifiedBy";
        }
        #endregion
    }
}
