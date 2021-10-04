using System;

namespace thSolution.Entities
{
    public partial class OrderDetail
    {
        public OrderDetail()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public int OrderId { get; set; }

        public int ProductId { get; set; }

        public decimal Quality { get; set; }

        public int Price { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        public string CreatedBy { get; set; }

        public string ModifiedBy { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Order Order { get; set; }

        public virtual Product Product { get; set; }

        #endregion
    }
}
