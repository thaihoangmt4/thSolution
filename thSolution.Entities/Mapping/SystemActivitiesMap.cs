using Microsoft.EntityFrameworkCore;

namespace thSolution.Entities.Mapping
{
    public partial class SystemActivitiesMap
        : IEntityTypeConfiguration<thSolution.Entities.SystemActivities>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<thSolution.Entities.SystemActivities> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("SystemActivities", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.ActionName)
                .HasColumnName("ActionName")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.ActionDate)
                .HasColumnName("ActionDate")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.FunctionId)
                .HasColumnName("FunctionId")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.UserId)
                .IsRequired()
                .HasColumnName("UserId")
                .HasColumnType("uniqueidentifier");

            builder.Property(t => t.ClientIp)
                .HasColumnName("ClientIp")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.CreatedDate)
                .IsRequired()
                .HasColumnName("CreatedDate")
                .HasColumnType("datetime2");

            builder.Property(t => t.ModifiedDate)
                .IsRequired()
                .HasColumnName("ModifiedDate")
                .HasColumnType("datetime2");

            builder.Property(t => t.CreatedBy)
                .HasColumnName("CreatedBy")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.ModifiedBy)
                .HasColumnName("ModifiedBy")
                .HasColumnType("nvarchar(max)");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "SystemActivities";
        }

        public struct Columns
        {
            public const string Id = "Id";
            public const string ActionName = "ActionName";
            public const string ActionDate = "ActionDate";
            public const string FunctionId = "FunctionId";
            public const string UserId = "UserId";
            public const string ClientIp = "ClientIp";
            public const string CreatedDate = "CreatedDate";
            public const string ModifiedDate = "ModifiedDate";
            public const string CreatedBy = "CreatedBy";
            public const string ModifiedBy = "ModifiedBy";
        }
        #endregion
    }
}
