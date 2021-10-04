using System;

namespace thSolution.Entities
{
    public partial class Transaction
    {
        public Transaction()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public DateTime TracsactionDate { get; set; }

        public int ExternalTracsactionId { get; set; }

        public int Amount { get; set; }

        public decimal Fee { get; set; }

        public bool Result { get; set; }

        public string Message { get; set; }

        public int Status { get; set; }

        public string Provider { get; set; }

        public Guid UserId { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        public string CreatedBy { get; set; }

        public string ModifiedBy { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Users UserUsers { get; set; }

        #endregion
    }
}
