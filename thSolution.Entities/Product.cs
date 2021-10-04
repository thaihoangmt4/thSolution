using System;
using System.Collections.Generic;

namespace thSolution.Entities
{
    public partial class Product
    {
        public Product()
        {
            #region Generated Constructor
            Carts = new HashSet<Cart>();
            OrderDetails = new HashSet<OrderDetail>();
            ProductImages = new HashSet<ProductImage>();
            ProductInCategories = new HashSet<ProductInCategory>();
            ProductReviews = new HashSet<ProductReview>();
            ProductTranslations = new HashSet<ProductTranslation>();
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public decimal Price { get; set; }

        public decimal OriginalPrice { get; set; }

        public int Stock { get; set; }

        public int ViewCount { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        public string CreatedBy { get; set; }

        public string ModifiedBy { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<Cart> Carts { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

        public virtual ICollection<ProductImage> ProductImages { get; set; }

        public virtual ICollection<ProductInCategory> ProductInCategories { get; set; }

        public virtual ICollection<ProductReview> ProductReviews { get; set; }

        public virtual ICollection<ProductTranslation> ProductTranslations { get; set; }

        #endregion
    }
}
