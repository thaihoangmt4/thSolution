using System;
using System.Collections.Generic;

namespace thSolution.Entities
{
    public partial class Language
    {
        public Language()
        {
            #region Generated Constructor
            CategoryTranslactions = new HashSet<CategoryTranslaction>();
            ProductTranslations = new HashSet<ProductTranslation>();
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public string Name { get; set; }

        public bool IsDefault { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        public string CreatedBy { get; set; }

        public string ModifiedBy { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<CategoryTranslaction> CategoryTranslactions { get; set; }

        public virtual ICollection<ProductTranslation> ProductTranslations { get; set; }

        #endregion
    }
}
