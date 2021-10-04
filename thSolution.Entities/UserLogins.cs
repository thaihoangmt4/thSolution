using System;

namespace thSolution.Entities
{
    public partial class UserLogins
    {
        public UserLogins()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public Guid UserId { get; set; }

        public string LoginProvider { get; set; }

        public string ProviderKey { get; set; }

        public string ProviderDisplayName { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Users UserUsers { get; set; }

        #endregion
    }
}
