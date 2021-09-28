using System.Collections.Generic;
using thSolution.Enums;

namespace thSolution.Entities
{
    public class Category : CommonEntity
    {
        public int Id { get; set; }
        public int SortOrder { get; set; }
        public bool IsShowOnHome { get; set; }
        public int? ParentId { get; set; }
        public Status Status { get; set; }
        public List<ProductInCategory> ProductInCategories { get; set; }
        public List<CategoryTranslaction> CategoryTranslactions { get; set; }
    }
}
