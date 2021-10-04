using Microsoft.EntityFrameworkCore;

namespace thSolution.Entities.Mapping
{
    public partial class ContactMap
        : IEntityTypeConfiguration<thSolution.Entities.Contact>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<thSolution.Entities.Contact> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Contact", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Name)
                .IsRequired()
                .HasColumnName("Name")
                .HasColumnType("nvarchar(200)")
                .HasMaxLength(200);

            builder.Property(t => t.Email)
                .IsRequired()
                .HasColumnName("Email")
                .HasColumnType("nvarchar(200)")
                .HasMaxLength(200);

            builder.Property(t => t.PhoneNumber)
                .IsRequired()
                .HasColumnName("PhoneNumber")
                .HasColumnType("nvarchar(200)")
                .HasMaxLength(200);

            builder.Property(t => t.Message)
                .IsRequired()
                .HasColumnName("Message")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.Status)
                .IsRequired()
                .HasColumnName("Status")
                .HasColumnType("int");

            builder.Property(t => t.OrderId)
                .IsRequired()
                .HasColumnName("OrderId")
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
            builder.HasOne(t => t.Order)
                .WithMany(t => t.Contacts)
                .HasForeignKey(d => d.OrderId)
                .HasConstraintName("FK_Order_Contact");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "Contact";
        }

        public struct Columns
        {
            public const string Id = "Id";
            public const string Name = "Name";
            public const string Email = "Email";
            public const string PhoneNumber = "PhoneNumber";
            public const string Message = "Message";
            public const string Status = "Status";
            public const string OrderId = "OrderId";
            public const string CreatedDate = "CreatedDate";
            public const string ModifiedDate = "ModifiedDate";
            public const string CreatedBy = "CreatedBy";
            public const string ModifiedBy = "ModifiedBy";
        }
        #endregion
    }
}
