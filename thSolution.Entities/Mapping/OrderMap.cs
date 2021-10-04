using Microsoft.EntityFrameworkCore;

namespace thSolution.Entities.Mapping
{
    public partial class OrderMap
        : IEntityTypeConfiguration<thSolution.Entities.Order>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<thSolution.Entities.Order> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Order", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.OrderDate)
                .IsRequired()
                .HasColumnName("OrderDate")
                .HasColumnType("datetime2");

            builder.Property(t => t.UserId)
                .IsRequired()
                .HasColumnName("UserId")
                .HasColumnType("uniqueidentifier");

            builder.Property(t => t.ShipName)
                .HasColumnName("ShipName")
                .HasColumnType("varchar(40)")
                .HasMaxLength(40);

            builder.Property(t => t.ShipAddress)
                .HasColumnName("ShipAddress")
                .HasColumnType("varchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.ShipEmail)
                .HasColumnName("ShipEmail")
                .HasColumnType("varchar(60)")
                .HasMaxLength(60);

            builder.Property(t => t.ShipPhoneNumber)
                .HasColumnName("ShipPhoneNumber")
                .HasColumnType("varchar(10)")
                .HasMaxLength(10);

            builder.Property(t => t.Status)
                .IsRequired()
                .HasColumnName("Status")
                .HasColumnType("int");

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
            builder.HasOne(t => t.UserUsers)
                .WithMany(t => t.UserOrders)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_Order_User");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "Order";
        }

        public struct Columns
        {
            public const string Id = "Id";
            public const string OrderDate = "OrderDate";
            public const string UserId = "UserId";
            public const string ShipName = "ShipName";
            public const string ShipAddress = "ShipAddress";
            public const string ShipEmail = "ShipEmail";
            public const string ShipPhoneNumber = "ShipPhoneNumber";
            public const string Status = "Status";
            public const string CreatedDate = "CreatedDate";
            public const string ModifiedDate = "ModifiedDate";
            public const string CreatedBy = "CreatedBy";
            public const string ModifiedBy = "ModifiedBy";
        }
        #endregion
    }
}
