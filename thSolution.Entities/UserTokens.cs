using System;

namespace thSolution.Entities
{
    public partial class UserTokens
    {
        public UserTokens()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public Guid UserId { get; set; }

        public string LoginProvider { get; set; }

        public string Name { get; set; }

        public string Value { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Users UserUsers { get; set; }

        #endregion
    }
}
