using System;
using System.Collections.Generic;

namespace thSolution.Entities
{
    public partial class Order
    {
        public Order()
        {
            #region Generated Constructor
            Contacts = new HashSet<Contact>();
            OrderDetails = new HashSet<OrderDetail>();
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public DateTime OrderDate { get; set; }

        public Guid UserId { get; set; }

        public string ShipName { get; set; }

        public string ShipAddress { get; set; }

        public string ShipEmail { get; set; }

        public string ShipPhoneNumber { get; set; }

        public int Status { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        public string CreatedBy { get; set; }

        public string ModifiedBy { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<Contact> Contacts { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

        public virtual Users UserUsers { get; set; }

        #endregion
    }
}
