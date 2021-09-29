using Microsoft.AspNetCore.Identity;
using System;

namespace thSolution.Entities
{
    public class Roles : IdentityRole<Guid>
    {
        public string Description { get; set; }
    }
}
