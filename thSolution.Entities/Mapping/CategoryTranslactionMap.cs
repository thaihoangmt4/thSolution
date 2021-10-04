using Microsoft.EntityFrameworkCore;

namespace thSolution.Entities.Mapping
{
    public partial class CategoryTranslactionMap
        : IEntityTypeConfiguration<thSolution.Entities.CategoryTranslaction>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<thSolution.Entities.CategoryTranslaction> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("CategoryTranslaction", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.CategoryId)
                .IsRequired()
                .HasColumnName("CategoryId")
                .HasColumnType("int");

            builder.Property(t => t.Name)
                .IsRequired()
                .HasColumnName("Name")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.SeoDescription)
                .HasColumnName("SeoDescription")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.SeoTitle)
                .HasColumnName("SeoTitle")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.SeoAlias)
                .HasColumnName("SeoAlias")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

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
            builder.HasOne(t => t.Category)
                .WithMany(t => t.CategoryTranslactions)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK_CategoryTranslaction_Category");

            builder.HasOne(t => t.Language)
                .WithMany(t => t.CategoryTranslactions)
                .HasForeignKey(d => d.LanguageId)
                .HasConstraintName("FK_CategoryTranslaction_Language");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "CategoryTranslaction";
        }

        public struct Columns
        {
            public const string Id = "Id";
            public const string CategoryId = "CategoryId";
            public const string Name = "Name";
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
