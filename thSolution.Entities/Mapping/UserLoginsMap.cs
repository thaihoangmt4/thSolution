using Microsoft.EntityFrameworkCore;

namespace thSolution.Entities.Mapping
{
    public partial class UserLoginsMap
        : IEntityTypeConfiguration<thSolution.Entities.UserLogins>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<thSolution.Entities.UserLogins> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("UserLogins", "dbo");

            // key
            builder.HasKey(t => t.UserId);

            // properties
            builder.Property(t => t.UserId)
                .IsRequired()
                .HasColumnName("UserId")
                .HasColumnType("uniqueidentifier");

            builder.Property(t => t.LoginProvider)
                .HasColumnName("LoginProvider")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.ProviderKey)
                .HasColumnName("ProviderKey")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.ProviderDisplayName)
                .HasColumnName("ProviderDisplayName")
                .HasColumnType("nvarchar(max)");

            // relationships
            builder.HasOne(t => t.UserUsers)
                .WithOne(t => t.UserUserLogins)
                .HasForeignKey<thSolution.Entities.UserLogins>(d => d.UserId)
                .HasConstraintName("FK_UserLogin_User");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "UserLogins";
        }

        public struct Columns
        {
            public const string UserId = "UserId";
            public const string LoginProvider = "LoginProvider";
            public const string ProviderKey = "ProviderKey";
            public const string ProviderDisplayName = "ProviderDisplayName";
        }
        #endregion
    }
}
