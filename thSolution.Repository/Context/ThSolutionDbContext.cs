using Microsoft.EntityFrameworkCore;
using thSolution.Entities;

namespace thSolution.Repository.Context
{
    public class ThSolutionDbContext : DbContext
    {
        #region Properties
        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<CategoryTranslaction> CategoryTranslactions { get; set; }

        public DbSet<Language> Languages { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }

        public DbSet<ProductTranslaction> ProductTranslactions { get; set; }

        public DbSet<Promotion> Promotions { get; set; }

        public DbSet<SystemActivity> SystemActivities { get; set; }

        public DbSet<Tracsaction> Tracsactions { get; set; }
        #endregion Properties

        public ThSolutionDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
