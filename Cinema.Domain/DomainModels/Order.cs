using Cinema.Domain.Identity;
using System;
using System.Collections.Generic;

namespace Cinema.Domain.DomainModels
{
    public class Order : BaseEntity
    {
        public string UserId { get; set; }
        public CinemaAppUser User { get; set; }
        public IEnumerable<TicketInOrder> TicketInOrders { get; set; } 
    }
}
