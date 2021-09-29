using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace thSolution.Entities.Mapping
{
    public class ProductTranslactionMap : IEntityTypeConfiguration<ProductTranslation>
    {
        public void Configure(EntityTypeBuilder<ProductTranslation> builder)
        {
            builder.ToTable("ProductTranslation");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(x => x.SeoAlias)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(x => x.Details)
                .HasMaxLength(500);

            builder.Property(x => x.LanguageId)
                .IsUnicode(false)
                .IsRequired()
                .HasMaxLength(5);

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

            // relativeship
            builder.HasOne(x => x.Language)
                .WithMany(x => x.ProductTranslations)
                .HasForeignKey(x => x.LanguageId);

            builder.HasOne(x => x.Product)
                .WithMany(x => x.ProductTranslations)
                .HasForeignKey(x => x.ProductId);
        }
    }
}
