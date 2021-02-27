using ListaZakupow.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListaZakupow.Model
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string LastName { get; set; }

        public string Password { get; set; }

        public ICollection<PhotoGallery> Photos { get; set; }

        public ICollection<Product> Products { get; set; }

        public ICollection<ShopingList> ShopingLists { get; set; }

        public ICollection<Address> Addresss { get; set; }

    }
}
