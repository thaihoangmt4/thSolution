using System;

namespace thSolution.Entities
{
    public partial class SystemActivities
    {
        public SystemActivities()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public string ActionName { get; set; }

        public string ActionDate { get; set; }

        public string FunctionId { get; set; }

        public Guid UserId { get; set; }

        public string ClientIp { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        public string CreatedBy { get; set; }

        public string ModifiedBy { get; set; }

        #endregion

        #region Generated Relationships
        #endregion
    }
}
