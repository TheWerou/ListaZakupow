using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListaZakupow.Server.Models
{
    public class ShopingList
    {
        public ShopingList()
        {
            this.Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public ICollection<Product> Products { get; set; }

    }
}
