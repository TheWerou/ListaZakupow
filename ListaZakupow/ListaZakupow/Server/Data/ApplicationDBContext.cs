using ListaZakupow.Server.Models;
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

        public DbSet<Product> Products { get; set; }

        public DbSet<ProductCategory> ProductsCategory { get; set; }

        public DbSet<ShopingList> ShopingLists { get; set; }

        public DbSet<User> Users { get; set; }
    }
}
