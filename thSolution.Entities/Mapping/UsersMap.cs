using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace thSolution.Entities.Mapping
{
    public class UsersMap : IEntityTypeConfiguration<Users>

    {
        public void Configure(EntityTypeBuilder<Users> builder)
        {
            builder.ToTable("Users");

            builder.Property(x => x.FirstName)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(x => x.LastName)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(x => x.Dob)
                .IsRequired();
        }
    }
}
