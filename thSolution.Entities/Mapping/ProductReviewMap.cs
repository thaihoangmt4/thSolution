using Microsoft.EntityFrameworkCore;

namespace thSolution.Entities.Mapping
{
    public partial class ProductReviewMap
        : IEntityTypeConfiguration<thSolution.Entities.ProductReview>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<thSolution.Entities.ProductReview> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("ProductReview", "dbo");

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

            builder.Property(t => t.ParentId)
                .HasColumnName("ParentId")
                .HasColumnType("int");

            builder.Property(t => t.Title)
                .IsRequired()
                .HasColumnName("Title")
                .HasColumnType("varchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.Rating)
                .IsRequired()
                .HasColumnName("Rating")
                .HasColumnType("int");

            builder.Property(t => t.Content)
                .IsRequired()
                .HasColumnName("Content")
                .HasColumnType("text");

            builder.Property(t => t.CreatedDate)
                .IsRequired()
                .HasColumnName("CreatedDate")
                .HasColumnType("date");

            builder.Property(t => t.ModifiedDate)
                .IsRequired()
                .HasColumnName("ModifiedDate")
                .HasColumnType("date");

            builder.Property(t => t.CreatedBy)
                .HasColumnName("CreatedBy")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.ModifiedBy)
                .HasColumnName("ModifiedBy")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            // relationships
            builder.HasOne(t => t.Product)
                .WithMany(t => t.ProductReviews)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_ProductReview_Product");

            #endregion Generated Configure
        }

        #region Generated Constants

        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "ProductReview";
        }

        public struct Columns
        {
            public const string Id = "Id";
            public const string ProductId = "ProductId";
            public const string ParentId = "ParentId";
            public const string Title = "Title";
            public const string Rating = "Rating";
            public const string Content = "Content";
            public const string CreatedDate = "CreatedDate";
            public const string ModifiedDate = "ModifiedDate";
            public const string CreatedBy = "CreatedBy";
            public const string ModifiedBy = "ModifiedBy";
        }

        #endregion Generated Constants
    }
}
