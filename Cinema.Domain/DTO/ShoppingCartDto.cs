using Cinema.Domain.DomainModels;
using System.Collections.Generic;

namespace Cinema.Domain.DTO
{
    public class ShoppingCartDto
    {
        public List<TicketInShoppingCart> Tickets { get; set; }
        public double TotalPrice { get; set; }
    }
}
