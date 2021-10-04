using Microsoft.EntityFrameworkCore;

namespace thSolution.Entities.Mapping
{
    public partial class UserClaimsMap
        : IEntityTypeConfiguration<thSolution.Entities.UserClaims>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<thSolution.Entities.UserClaims> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("UserClaims", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.UserId)
                .IsRequired()
                .HasColumnName("UserId")
                .HasColumnType("uniqueidentifier");

            builder.Property(t => t.ClaimType)
                .HasColumnName("ClaimType")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.ClaimValue)
                .HasColumnName("ClaimValue")
                .HasColumnType("nvarchar(max)");

            // relationships
            builder.HasOne(t => t.UserUsers)
                .WithMany(t => t.UserUserClaims)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_UserClaim_User");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "UserClaims";
        }

        public struct Columns
        {
            public const string Id = "Id";
            public const string UserId = "UserId";
            public const string ClaimType = "ClaimType";
            public const string ClaimValue = "ClaimValue";
        }
        #endregion
    }
}
