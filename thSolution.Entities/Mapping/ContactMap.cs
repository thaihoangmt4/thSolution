using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace thSolution.Entities.Mapping
{
    public class ContactMap : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.ToTable("Contact");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

            builder.Property(x => x.Name)
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(x => x.Email)
                .HasMaxLength(200)
                .IsRequired();
            builder.Property(x => x.PhoneNumber)
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(x => x.Message)
                .IsRequired();

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
        }
    }
}
