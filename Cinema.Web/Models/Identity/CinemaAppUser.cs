using Cinema.Web.Models.Domain;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Cinema.Web.Models.Identity
{
    public class CinemaAppUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public virtual ShoppingCart UserCart { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
