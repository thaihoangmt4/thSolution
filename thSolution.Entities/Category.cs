using System;
using System.Collections.Generic;

namespace thSolution.Entities
{
    public partial class Category
    {
        public Category()
        {
            #region Generated Constructor
            CategoryTranslactions = new HashSet<CategoryTranslaction>();
            ProductInCategories = new HashSet<ProductInCategory>();
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public int SortOrder { get; set; }

        public bool IsShowOnHome { get; set; }

        public int? ParentId { get; set; }

        public int Status { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        public string CreatedBy { get; set; }

        public string ModifiedBy { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<CategoryTranslaction> CategoryTranslactions { get; set; }

        public virtual ICollection<ProductInCategory> ProductInCategories { get; set; }

        #endregion
    }
}
