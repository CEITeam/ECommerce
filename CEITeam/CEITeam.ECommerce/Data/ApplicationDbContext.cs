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
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<Product> Products { get; set; }
    }
}