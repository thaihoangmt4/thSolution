using System.Collections.Generic;

namespace thSolution.Entities
{
    public class Language : CommonEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDefault { get; set; }
        public List<CategoryTranslaction> CategoryTranslactions { get; set; }
        public List<ProductTranslation> ProductTranslations { get; set; }
    }
}
