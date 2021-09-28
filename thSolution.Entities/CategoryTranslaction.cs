namespace thSolution.Entities
{
    public class CategoryTranslaction : CommonEntity
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string SeoDescription { get; set; }
        public string SeoTitle { get; set; }
        public string SeoAlias { get; set; }
        public int LanguageId { get; set; }
        public Category Category { get; set; }
        public Language Language { get; set; }
    }
}
