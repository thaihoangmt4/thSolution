using System;

namespace thSolution.Entities
{
    public partial class CategoryTranslaction
    {
        public CategoryTranslaction()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public int CategoryId { get; set; }

        public string Name { get; set; }

        public string SeoDescription { get; set; }

        public string SeoTitle { get; set; }

        public string SeoAlias { get; set; }

        public int LanguageId { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        public string CreatedBy { get; set; }

        public string ModifiedBy { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Category Category { get; set; }

        public virtual Language Language { get; set; }

        #endregion
    }
}
