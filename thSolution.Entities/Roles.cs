using System;
using System.Collections.Generic;

namespace thSolution.Entities
{
    public partial class Roles
    {
        public Roles()
        {
            #region Generated Constructor
            RoleRoleClaims = new HashSet<RoleClaims>();
            RoleUserRoles = new HashSet<UserRoles>();
            #endregion
        }

        #region Generated Properties
        public Guid Id { get; set; }

        public string Description { get; set; }

        public string Name { get; set; }

        public string NormalizedName { get; set; }

        public string ConcurrencyStamp { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<RoleClaims> RoleRoleClaims { get; set; }

        public virtual ICollection<UserRoles> RoleUserRoles { get; set; }

        #endregion
    }
}
