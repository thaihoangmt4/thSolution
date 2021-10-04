using Microsoft.EntityFrameworkCore;

namespace thSolution.Entities.Mapping
{
    public partial class RoleClaimsMap
        : IEntityTypeConfiguration<thSolution.Entities.RoleClaims>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<thSolution.Entities.RoleClaims> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("RoleClaims", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.RoleId)
                .IsRequired()
                .HasColumnName("RoleId")
                .HasColumnType("uniqueidentifier");

            builder.Property(t => t.ClaimType)
                .HasColumnName("ClaimType")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.ClaimValue)
                .HasColumnName("ClaimValue")
                .HasColumnType("nvarchar(max)");

            // relationships
            builder.HasOne(t => t.RoleRoles)
                .WithMany(t => t.RoleRoleClaims)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("FK_RoleClaim_Role");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "RoleClaims";
        }

        public struct Columns
        {
            public const string Id = "Id";
            public const string RoleId = "RoleId";
            public const string ClaimType = "ClaimType";
            public const string ClaimValue = "ClaimValue";
        }
        #endregion
    }
}
