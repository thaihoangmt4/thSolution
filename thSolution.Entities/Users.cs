using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace thSolution.Entities
{
    public class Users : IdentityUser<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Dob { get; set; }
        public List<Order> Orders { get; set; }
        public List<Transaction> Transactions { get; set; }
        public List<Cart> Carts { get; set; }
    }
}
