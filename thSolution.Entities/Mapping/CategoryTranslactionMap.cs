using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace thSolution.Entities.Mapping
{
    public class CategoryTranslactionMap : IEntityTypeConfiguration<CategoryTranslaction>
    {
        public void Configure(EntityTypeBuilder<CategoryTranslaction> builder)
        {
            // table
            builder.ToTable("CategoryTranslaction");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Name)
                .IsRequired()
                .HasColumnType("character varying(255)")
                .HasMaxLength(255);

            builder.Property(t => t.SeoAlias)
                .HasColumnType("character varying(255)")
                .HasMaxLength(255);

            builder.Property(t => t.SeoDescription)
                .HasColumnType("character varying(255)")
                .HasMaxLength(255);

            builder.Property(t => t.SeoTitle)
                .HasColumnType("character varying(255)")
                .HasMaxLength(255);

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
            builder.HasOne(t => t.Category)
                .WithMany(t => t.CategoryTranslactions)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK_CategoryTranslaction_Category");

            builder.HasOne(t => t.Language)
                .WithMany(t => t.CategoryTranslactions)
                .HasForeignKey(d => d.LanguageId)
                .HasConstraintName("FK_CategoryTranslaction_Language");
        }
    }
}
