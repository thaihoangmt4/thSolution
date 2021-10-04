using Microsoft.EntityFrameworkCore;

namespace thSolution.Repository.Context
{
    public partial class ThSolutionDbContext : DbContext
    {
        public ThSolutionDbContext(DbContextOptions<ThSolutionDbContext> options)
            : base(options)
        {
        }

        #region Generated Properties
        public virtual DbSet<thSolution.Entities.AppConfig> AppConfigs { get; set; }

        public virtual DbSet<thSolution.Entities.Cart> Carts { get; set; }

        public virtual DbSet<thSolution.Entities.Category> Categories { get; set; }

        public virtual DbSet<thSolution.Entities.CategoryTranslaction> CategoryTranslactions { get; set; }

        public virtual DbSet<thSolution.Entities.Contact> Contacts { get; set; }

        public virtual DbSet<thSolution.Entities.Language> Languages { get; set; }

        public virtual DbSet<thSolution.Entities.OrderDetail> OrderDetails { get; set; }

        public virtual DbSet<thSolution.Entities.Order> Orders { get; set; }

        public virtual DbSet<thSolution.Entities.ProductImage> ProductImages { get; set; }

        public virtual DbSet<thSolution.Entities.ProductInCategory> ProductInCategories { get; set; }

        public virtual DbSet<thSolution.Entities.ProductReview> ProductReviews { get; set; }

        public virtual DbSet<thSolution.Entities.Product> Products { get; set; }

        public virtual DbSet<thSolution.Entities.ProductTranslation> ProductTranslations { get; set; }

        public virtual DbSet<thSolution.Entities.Promotion> Promotions { get; set; }

        public virtual DbSet<thSolution.Entities.RoleClaims> RoleClaims { get; set; }

        public virtual DbSet<thSolution.Entities.Roles> Roles { get; set; }

        public virtual DbSet<thSolution.Entities.SystemActivities> SystemActivities { get; set; }

        public virtual DbSet<thSolution.Entities.Transaction> Transactions { get; set; }

        public virtual DbSet<thSolution.Entities.UserClaims> UserClaims { get; set; }

        public virtual DbSet<thSolution.Entities.UserLogins> UserLogins { get; set; }

        public virtual DbSet<thSolution.Entities.UserRoles> UserRoles { get; set; }

        public virtual DbSet<thSolution.Entities.Users> Users { get; set; }

        public virtual DbSet<thSolution.Entities.UserTokens> UserTokens { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Generated Configuration
            modelBuilder.ApplyConfiguration(new thSolution.Entities.Mapping.AppConfigMap());
            modelBuilder.ApplyConfiguration(new thSolution.Entities.Mapping.CartMap());
            modelBuilder.ApplyConfiguration(new thSolution.Entities.Mapping.CategoryMap());
            modelBuilder.ApplyConfiguration(new thSolution.Entities.Mapping.CategoryTranslactionMap());
            modelBuilder.ApplyConfiguration(new thSolution.Entities.Mapping.ContactMap());
            modelBuilder.ApplyConfiguration(new thSolution.Entities.Mapping.LanguageMap());
            modelBuilder.ApplyConfiguration(new thSolution.Entities.Mapping.OrderDetailMap());
            modelBuilder.ApplyConfiguration(new thSolution.Entities.Mapping.OrderMap());
            modelBuilder.ApplyConfiguration(new thSolution.Entities.Mapping.ProductImageMap());
            modelBuilder.ApplyConfiguration(new thSolution.Entities.Mapping.ProductInCategoryMap());
            modelBuilder.ApplyConfiguration(new thSolution.Entities.Mapping.ProductMap());
            modelBuilder.ApplyConfiguration(new thSolution.Entities.Mapping.ProductReviewMap());
            modelBuilder.ApplyConfiguration(new thSolution.Entities.Mapping.ProductTranslationMap());
            modelBuilder.ApplyConfiguration(new thSolution.Entities.Mapping.PromotionMap());
            modelBuilder.ApplyConfiguration(new thSolution.Entities.Mapping.RoleClaimsMap());
            modelBuilder.ApplyConfiguration(new thSolution.Entities.Mapping.RolesMap());
            modelBuilder.ApplyConfiguration(new thSolution.Entities.Mapping.SystemActivitiesMap());
            modelBuilder.ApplyConfiguration(new thSolution.Entities.Mapping.TransactionMap());
            modelBuilder.ApplyConfiguration(new thSolution.Entities.Mapping.UserClaimsMap());
            modelBuilder.ApplyConfiguration(new thSolution.Entities.Mapping.UserLoginsMap());
            modelBuilder.ApplyConfiguration(new thSolution.Entities.Mapping.UserRolesMap());
            modelBuilder.ApplyConfiguration(new thSolution.Entities.Mapping.UsersMap());
            modelBuilder.ApplyConfiguration(new thSolution.Entities.Mapping.UserTokensMap());
            #endregion
        }
    }
}
