using System;

namespace thSolution.Entities
{
    public partial class Contact
    {
        public Contact()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string Message { get; set; }

        public int Status { get; set; }

        public int OrderId { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        public string CreatedBy { get; set; }

        public string ModifiedBy { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Order Order { get; set; }

        #endregion
    }
}
