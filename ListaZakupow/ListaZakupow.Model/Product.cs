using ListaZakupow.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ListaZakupow.Model
{
    public class Product
    {
        public Product()
        {
            this.ShopingLists = new HashSet<ShopingList>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Amount { get; set; }

        public User User { get; set; }

        public ICollection<ShopingList> ShopingLists { get; set; }

        public ICollection<ProductType> ProductTypes { get; set; }

        public ICollection<ProductCategory> ProductsCategory { get; set; }

        public ICollection<PhotoGallery> PhotosGallery { get; set; }

        public ICollection<ProductOrder> ProductOrders { get; set; }

        public ICollection<ProductPrice> ProductPrices { get; set; }

    }
}
