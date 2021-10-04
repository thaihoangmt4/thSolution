using Microsoft.EntityFrameworkCore;

namespace thSolution.Entities.Mapping
{
    public partial class UserTokensMap
        : IEntityTypeConfiguration<thSolution.Entities.UserTokens>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<thSolution.Entities.UserTokens> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("UserTokens", "dbo");

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

            builder.Property(t => t.Name)
                .HasColumnName("Name")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.Value)
                .HasColumnName("Value")
                .HasColumnType("nvarchar(max)");

            // relationships
            builder.HasOne(t => t.UserUsers)
                .WithOne(t => t.UserUserTokens)
                .HasForeignKey<thSolution.Entities.UserTokens>(d => d.UserId)
                .HasConstraintName("FK_UserToken_User");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "UserTokens";
        }

        public struct Columns
        {
            public const string UserId = "UserId";
            public const string LoginProvider = "LoginProvider";
            public const string Name = "Name";
            public const string Value = "Value";
        }
        #endregion
    }
}
