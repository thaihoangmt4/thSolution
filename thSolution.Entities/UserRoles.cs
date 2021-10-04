using System;

namespace thSolution.Entities
{
    public partial class UserRoles
    {
        public UserRoles()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public Guid UserId { get; set; }

        public Guid RoleId { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Roles RoleRoles { get; set; }

        public virtual Users UserUsers { get; set; }

        #endregion
    }
}
