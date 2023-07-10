using Cinema.Web.Models.Identity;
using System;
using System.Collections.Generic;

namespace Cinema.Web.Models.Domain
{
    public class Order
    {
        public Guid Id { get; set; }
        public string UserId { get; set; }
        public CinemaAppUser User { get; set; }
        public IEnumerable<TicketInOrder> TicketInOrders { get; set; } 
    }
}
