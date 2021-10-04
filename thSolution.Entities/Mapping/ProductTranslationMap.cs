using Microsoft.EntityFrameworkCore;

namespace thSolution.Entities.Mapping
{
    public partial class ProductTranslationMap
        : IEntityTypeConfiguration<thSolution.Entities.ProductTranslation>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<thSolution.Entities.ProductTranslation> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("ProductTranslation", "dbo");

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

            builder.Property(t => t.Name)
                .IsRequired()
                .HasColumnName("Name")
                .HasColumnType("nvarchar(200)")
                .HasMaxLength(200);

            builder.Property(t => t.Description)
                .HasColumnName("Description")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.Details)
                .HasColumnName("Details")
                .HasColumnType("nvarchar(500)")
                .HasMaxLength(500);

            builder.Property(t => t.SeoDescription)
                .HasColumnName("SeoDescription")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.SeoTitle)
                .HasColumnName("SeoTitle")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.SeoAlias)
                .IsRequired()
                .HasColumnName("SeoAlias")
                .HasColumnType("nvarchar(200)")
                .HasMaxLength(200);

            builder.Property(t => t.LanguageId)
                .IsRequired()
                .HasColumnName("LanguageId")
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
            builder.HasOne(t => t.Language)
                .WithMany(t => t.ProductTranslations)
                .HasForeignKey(d => d.LanguageId)
                .HasConstraintName("FK_ProductTranslation_Language_LanguageId");

            builder.HasOne(t => t.Product)
                .WithMany(t => t.ProductTranslations)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_ProductTranslation_Products_ProductId");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "ProductTranslation";
        }

        public struct Columns
        {
            public const string Id = "Id";
            public const string ProductId = "ProductId";
            public const string Name = "Name";
            public const string Description = "Description";
            public const string Details = "Details";
            public const string SeoDescription = "SeoDescription";
            public const string SeoTitle = "SeoTitle";
            public const string SeoAlias = "SeoAlias";
            public const string LanguageId = "LanguageId";
            public const string CreatedDate = "CreatedDate";
            public const string ModifiedDate = "ModifiedDate";
            public const string CreatedBy = "CreatedBy";
            public const string ModifiedBy = "ModifiedBy";
        }
        #endregion
    }
}
