using Cinema.Web.Models.Domain;
using System.Collections.Generic;

namespace Cinema.Web.Models.DTO
{
    public class ShoppingCartDto
    {
        public List<TicketInShoppingCart> Tickets { get; set; }
        public double TotalPrice { get; set; }
    }
}
