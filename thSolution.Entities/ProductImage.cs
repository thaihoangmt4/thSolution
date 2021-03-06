using System;

namespace thSolution.Entities
{
    public partial class ProductImage
    {
        public ProductImage()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public int ProductId { get; set; }

        public string ImagePath { get; set; }

        public string Caption { get; set; }

        public bool IsDefault { get; set; }

        public int SortOrder { get; set; }

        public long FileSize { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        public string CreatedBy { get; set; }

        public string ModifiedBy { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Product Product { get; set; }

        #endregion
    }
}
