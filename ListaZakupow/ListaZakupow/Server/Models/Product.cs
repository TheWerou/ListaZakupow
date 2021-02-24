using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListaZakupow.Server.Models
{
    public class Product
    {
        public Product()
        {
            this.ShopingLists = new HashSet<ShopingList>();
        }
        public ICollection<ShopingList> ShopingLists { get; set; }

        public ICollection<ProductCategory> ProductsCategory { get; set; }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Amount { get; set; }

        public bool IsSelected { get; set; }
    }
}
