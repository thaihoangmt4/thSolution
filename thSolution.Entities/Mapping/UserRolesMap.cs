using Microsoft.EntityFrameworkCore;

namespace thSolution.Entities.Mapping
{
    public partial class UserRolesMap
        : IEntityTypeConfiguration<thSolution.Entities.UserRoles>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<thSolution.Entities.UserRoles> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("UserRoles", "dbo");

            // key
            builder.HasKey(t => new { t.UserId, t.RoleId });

            // properties
            builder.Property(t => t.UserId)
                .IsRequired()
                .HasColumnName("UserId")
                .HasColumnType("uniqueidentifier");

            builder.Property(t => t.RoleId)
                .IsRequired()
                .HasColumnName("RoleId")
                .HasColumnType("uniqueidentifier");

            // relationships
            builder.HasOne(t => t.RoleRoles)
                .WithMany(t => t.RoleUserRoles)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("FK_UserRoles_Roles");

            builder.HasOne(t => t.UserUsers)
                .WithMany(t => t.UserUserRoles)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_UserRoles_Users");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "UserRoles";
        }

        public struct Columns
        {
            public const string UserId = "UserId";
            public const string RoleId = "RoleId";
        }
        #endregion
    }
}
