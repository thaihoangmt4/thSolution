using System;

namespace thSolution.Entities
{
    public partial class Promotion
    {
        public Promotion()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public DateTime FromDate { get; set; }

        public DateTime ToDate { get; set; }

        public bool ApplyToAll { get; set; }

        public string DiscountPercent { get; set; }

        public string DiscountAmount { get; set; }

        public string ProductIds { get; set; }

        public string ProductCategoryIds { get; set; }

        public int Status { get; set; }

        public string Name { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        public string CreatedBy { get; set; }

        public string ModifiedBy { get; set; }

        #endregion

        #region Generated Relationships
        #endregion
    }
}
