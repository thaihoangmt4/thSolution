using System;
using thSolution.Enums;

namespace thSolution.Entities
{
    public class Promotion : CommonEntity
    {
        public int Id { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public bool ApplyToAll { get; set; }
        public string DiscountPercent { get; set; }
        public string DiscountAmount { get; set; }
        public string ProductIds { get; set; }
        public string ProductCategoryIds { get; set; }
        public PromotionStatus Status { get; set; }
        public string Name { get; set; }
    }
}
