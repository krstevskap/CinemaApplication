using Cinema.Domain.DomainModels;
using Cinema.Domain.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace Cinema.Repository
{

    public class ApplicationDbContext : IdentityDbContext<CinemaAppUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Ticket> Tickets { get; set; }
        public virtual DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public virtual DbSet<TicketInShoppingCart> TicketInShoppingCarts { get; set; }
        public virtual DbSet<TicketInOrder> TicketInOrders { get; set; }
        public virtual DbSet<Order> Orders { get; set; }

        public DbSet<CinemaAppUser> UserAccounts { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasKey(p => new { p.UserId, p.RoleId });

            modelBuilder.Entity<Ticket>()
                .Property(t => t.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<ShoppingCart>()
                .Property(t => t.Id)
                .ValueGeneratedOnAdd();

            //modelBuilder.Entity<TicketInShoppingCart>()
            //    .HasKey(t => new { t.TicketId, t.ShoppingCartId });

            modelBuilder.Entity<TicketInShoppingCart>()
                .HasOne(t => t.Ticket)
                .WithMany(t => t.TicketInShoppingCarts)
                .HasForeignKey(t => t.ShoppingCartId);

            modelBuilder.Entity<TicketInShoppingCart>()
                .HasOne(t => t.ShoppingCart)
                .WithMany(t => t.TicketInShoppingCarts)
                .HasForeignKey(t => t.TicketId);

            modelBuilder.Entity<ShoppingCart>()
                .HasOne<CinemaAppUser>(t => t.Owner)
                .WithOne(t => t.UserCart)
                .HasForeignKey<ShoppingCart>(t => t.OwnerId);


            //modelBuilder.Entity<TicketInOrder>()
            //    .HasKey(t => new { t.TicketId, t.OrderId });

            modelBuilder.Entity<TicketInOrder>()
                .HasOne(t => t.OrderedTicket)
                .WithMany(t => t.TicketInOrders)
                .HasForeignKey(t => t.OrderId);

            modelBuilder.Entity<TicketInOrder>()
                .HasOne(t => t.UserOrder)
                .WithMany(t => t.TicketInOrders)
                .HasForeignKey(t => t.TicketId);
        }
    }

}
