using Microsoft.EntityFrameworkCore;

namespace thSolution.Entities.Mapping
{
    public partial class CategoryMap
        : IEntityTypeConfiguration<thSolution.Entities.Category>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<thSolution.Entities.Category> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Category", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.SortOrder)
                .IsRequired()
                .HasColumnName("SortOrder")
                .HasColumnType("int");

            builder.Property(t => t.IsShowOnHome)
                .IsRequired()
                .HasColumnName("IsShowOnHome")
                .HasColumnType("bit")
                .HasDefaultValueSql("(CONVERT([bit],(0)))");

            builder.Property(t => t.ParentId)
                .HasColumnName("ParentId")
                .HasColumnType("int");

            builder.Property(t => t.Status)
                .IsRequired()
                .HasColumnName("Status")
                .HasColumnType("int")
                .HasDefaultValueSql("((1))");

            builder.Property(t => t.CreatedDate)
                .IsRequired()
                .HasColumnName("CreatedDate")
                .HasColumnType("date");

            builder.Property(t => t.ModifiedDate)
                .IsRequired()
                .HasColumnName("ModifiedDate")
                .HasColumnType("date");

            builder.Property(t => t.CreatedBy)
                .IsRequired()
                .HasColumnName("CreatedBy")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.ModifiedBy)
                .HasColumnName("ModifiedBy")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "Category";
        }

        public struct Columns
        {
            public const string Id = "Id";
            public const string SortOrder = "SortOrder";
            public const string IsShowOnHome = "IsShowOnHome";
            public const string ParentId = "ParentId";
            public const string Status = "Status";
            public const string CreatedDate = "CreatedDate";
            public const string ModifiedDate = "ModifiedDate";
            public const string CreatedBy = "CreatedBy";
            public const string ModifiedBy = "ModifiedBy";
        }
        #endregion
    }
}
