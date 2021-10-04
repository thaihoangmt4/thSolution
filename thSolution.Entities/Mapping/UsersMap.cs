using Microsoft.EntityFrameworkCore;

namespace thSolution.Entities.Mapping
{
    public partial class UsersMap
        : IEntityTypeConfiguration<thSolution.Entities.Users>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<thSolution.Entities.Users> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Users", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("uniqueidentifier");

            builder.Property(t => t.FirstName)
                .IsRequired()
                .HasColumnName("FirstName")
                .HasColumnType("nvarchar(200)")
                .HasMaxLength(200);

            builder.Property(t => t.LastName)
                .IsRequired()
                .HasColumnName("LastName")
                .HasColumnType("nvarchar(200)")
                .HasMaxLength(200);

            builder.Property(t => t.Dob)
                .IsRequired()
                .HasColumnName("Dob")
                .HasColumnType("datetime2");

            builder.Property(t => t.UserName)
                .HasColumnName("UserName")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.NormalizedUserName)
                .HasColumnName("NormalizedUserName")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.Email)
                .HasColumnName("Email")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.NormalizedEmail)
                .HasColumnName("NormalizedEmail")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.EmailConfirmed)
                .IsRequired()
                .HasColumnName("EmailConfirmed")
                .HasColumnType("bit");

            builder.Property(t => t.PasswordHash)
                .HasColumnName("PasswordHash")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.SecurityStamp)
                .HasColumnName("SecurityStamp")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.ConcurrencyStamp)
                .HasColumnName("ConcurrencyStamp")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.PhoneNumber)
                .HasColumnName("PhoneNumber")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.PhoneNumberConfirmed)
                .IsRequired()
                .HasColumnName("PhoneNumberConfirmed")
                .HasColumnType("bit");

            builder.Property(t => t.TwoFactorEnabled)
                .IsRequired()
                .HasColumnName("TwoFactorEnabled")
                .HasColumnType("bit");

            builder.Property(t => t.LockoutEnd)
                .HasColumnName("LockoutEnd")
                .HasColumnType("datetimeoffset");

            builder.Property(t => t.LockoutEnabled)
                .IsRequired()
                .HasColumnName("LockoutEnabled")
                .HasColumnType("bit");

            builder.Property(t => t.AccessFailedCount)
                .IsRequired()
                .HasColumnName("AccessFailedCount")
                .HasColumnType("int");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "Users";
        }

        public struct Columns
        {
            public const string Id = "Id";
            public const string FirstName = "FirstName";
            public const string LastName = "LastName";
            public const string Dob = "Dob";
            public const string UserName = "UserName";
            public const string NormalizedUserName = "NormalizedUserName";
            public const string Email = "Email";
            public const string NormalizedEmail = "NormalizedEmail";
            public const string EmailConfirmed = "EmailConfirmed";
            public const string PasswordHash = "PasswordHash";
            public const string SecurityStamp = "SecurityStamp";
            public const string ConcurrencyStamp = "ConcurrencyStamp";
            public const string PhoneNumber = "PhoneNumber";
            public const string PhoneNumberConfirmed = "PhoneNumberConfirmed";
            public const string TwoFactorEnabled = "TwoFactorEnabled";
            public const string LockoutEnd = "LockoutEnd";
            public const string LockoutEnabled = "LockoutEnabled";
            public const string AccessFailedCount = "AccessFailedCount";
        }
        #endregion
    }
}
