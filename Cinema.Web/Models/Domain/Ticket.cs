﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Cinema.Web.Models.Domain
{
    public class Ticket
    {
        public Guid Id { get; set; }

        [Required]
        public string Title { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public string Genre { get; set; }
        public virtual ICollection<TicketInShoppingCart> TicketInShoppingCarts { get; set; }
        public IEnumerable<TicketInOrder> TicketInOrders { get; set; }
    }
}
