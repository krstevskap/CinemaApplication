using System;

namespace Cinema.Web.Models.Domain
{
    public class TicketInOrder
    {
        public Guid TicketId { get; set; }
        public Ticket OrderedTicket { get; set; }
        public Guid OrderId { get; set; }
        public Order UserOrder { get; set; }
    }
}
