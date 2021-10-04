using Microsoft.EntityFrameworkCore;

namespace thSolution.Entities.Mapping
{
    public partial class RolesMap
        : IEntityTypeConfiguration<thSolution.Entities.Roles>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<thSolution.Entities.Roles> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Roles", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("uniqueidentifier");

            builder.Property(t => t.Description)
                .IsRequired()
                .HasColumnName("Description")
                .HasColumnType("nvarchar(200)")
                .HasMaxLength(200);

            builder.Property(t => t.Name)
                .HasColumnName("Name")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.NormalizedName)
                .HasColumnName("NormalizedName")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.ConcurrencyStamp)
                .HasColumnName("ConcurrencyStamp")
                .HasColumnType("nvarchar(max)");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "Roles";
        }

        public struct Columns
        {
            public const string Id = "Id";
            public const string Description = "Description";
            public const string Name = "Name";
            public const string NormalizedName = "NormalizedName";
            public const string ConcurrencyStamp = "ConcurrencyStamp";
        }
        #endregion
    }
}
