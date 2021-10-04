using System;

namespace thSolution.Entities
{
    public partial class ProductInCategory
    {
        public ProductInCategory()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public int ProductId { get; set; }

        public int CategoryId { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        public string CreatedBy { get; set; }

        public string ModifiedBy { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Category Category { get; set; }

        public virtual Product Product { get; set; }

        #endregion
    }
}
