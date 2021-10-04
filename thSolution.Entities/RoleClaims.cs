using System;

namespace thSolution.Entities
{
    public partial class RoleClaims
    {
        public RoleClaims()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public Guid RoleId { get; set; }

        public string ClaimType { get; set; }

        public string ClaimValue { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Roles RoleRoles { get; set; }

        #endregion
    }
}
