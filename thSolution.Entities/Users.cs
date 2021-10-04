using System;
using System.Collections.Generic;

namespace thSolution.Entities
{
    public partial class Users
    {
        public Users()
        {
            #region Generated Constructor
            UserCarts = new HashSet<Cart>();
            UserOrders = new HashSet<Order>();
            UserTransactions = new HashSet<Transaction>();
            UserUserClaims = new HashSet<UserClaims>();
            UserUserRoles = new HashSet<UserRoles>();
            #endregion
        }

        #region Generated Properties
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime Dob { get; set; }

        public string UserName { get; set; }

        public string NormalizedUserName { get; set; }

        public string Email { get; set; }

        public string NormalizedEmail { get; set; }

        public bool EmailConfirmed { get; set; }

        public string PasswordHash { get; set; }

        public string SecurityStamp { get; set; }

        public string ConcurrencyStamp { get; set; }

        public string PhoneNumber { get; set; }

        public bool PhoneNumberConfirmed { get; set; }

        public bool TwoFactorEnabled { get; set; }

        public DateTimeOffset? LockoutEnd { get; set; }

        public bool LockoutEnabled { get; set; }

        public int AccessFailedCount { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<Cart> UserCarts { get; set; }

        public virtual ICollection<Order> UserOrders { get; set; }

        public virtual ICollection<Transaction> UserTransactions { get; set; }

        public virtual ICollection<UserClaims> UserUserClaims { get; set; }

        public virtual UserLogins UserUserLogins { get; set; }

        public virtual ICollection<UserRoles> UserUserRoles { get; set; }

        public virtual UserTokens UserUserTokens { get; set; }

        #endregion
    }
}
