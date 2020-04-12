using System;
using System.Collections.Generic;
using System.Text;
using CEITeam.ECommerce.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CEITeam.ECommerce.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); // Because we use ApplicationUser : IdentityUser
            modelBuilder.Entity<ProductTag>().HasKey(pt => new { pt.Fk_ProductId, pt.Fk_TagtId });
            modelBuilder.Entity<Order>().HasKey(o => new { o.Fk_ProductId, o.Fk_CustomerId });
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<Product> Products { get; set; }
    }
}