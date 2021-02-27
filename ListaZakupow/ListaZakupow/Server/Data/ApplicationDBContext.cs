using ListaZakupow.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListaZakupow.Server.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        public DbSet<Address> Address { get; set; }

        public DbSet<Delivery> Delivery { get; set; }

        public DbSet<Orders> Orders { get; set; }

        public DbSet<Payment> Payment { get; set; }

        public DbSet<PhotoGallery> PhotoGallery { get; set; }

        public DbSet<Product> Product { get; set; }

        public DbSet<ProductCategory> ProductCategory { get; set; }

        public DbSet<ProductOrder> ProductOrder { get; set; }

        public DbSet<ProductType> ProductType { get; set; }

        public DbSet<ProductPrice> ProductPrice { get; set; }

        public DbSet<ShopingList> ShopingList { get; set; }

        public DbSet<User> User { get; set; }
    }
}
