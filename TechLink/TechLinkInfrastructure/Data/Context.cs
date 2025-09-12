using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TechLink.Domain.Entities;
using TechLink.Infrastructure.Configurations;

namespace TechLink.Infrastructure.Data
{
    public class TechLinkDbContext : DbContext
    {
        public DbSet<Address> Address { get; set; }
        public DbSet<Cart> Cart { get; set; }
        public DbSet<CartItem> CartItem { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Coupon> Coupon { get; set; }
        public DbSet<Notification> Notification { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderItem> OrderItem { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Review> Review { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Shipping> Shipping { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<WishList> WishList { get; set; }
        public TechLinkDbContext(DbContextOptions<TechLinkDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration<Address>(new AddressConfiguration());
            modelBuilder.ApplyConfiguration<Cart>(new CartConfiguration());
            modelBuilder.ApplyConfiguration<CartItem>(new CartItemConfiguration());
            modelBuilder.ApplyConfiguration<Category>(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration<Coupon>(new CouponConfiguration());
            modelBuilder.ApplyConfiguration<Notification>(new NotificationConfiguration());
            modelBuilder.ApplyConfiguration<Order>(new OrderConfiguration());
            modelBuilder.ApplyConfiguration<OrderItem>(new OrderItemConfiguration());
            modelBuilder.ApplyConfiguration<Payment>(new PaymentConfiguration());
            modelBuilder.ApplyConfiguration<Product>(new ProductConfiguration());
            modelBuilder.ApplyConfiguration<Review>(new ReviewConfiguration());
            modelBuilder.ApplyConfiguration<Role>(new RoleConfiguration());
            modelBuilder.ApplyConfiguration<Shipping>(new ShippingConfiguration());
            modelBuilder.ApplyConfiguration<User>(new UserConfiguration());
            modelBuilder.ApplyConfiguration<WishList>(new WishListConfiguration());
            modelBuilder.ApplyConfiguration<WishListProduct>(new WishListProductConfiguration());
        }
    }
}
