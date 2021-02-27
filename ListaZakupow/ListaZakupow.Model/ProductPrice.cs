using System;
using System.Collections.Generic;
using System.Text;

namespace ListaZakupow.Model
{
    public class ProductPrice
    {
        public int Id { get; set; }

        public float Price { get; set; }

        public DateTime FromWhen { get; set; }

        public DateTime ToWhen { get; set; }

        public bool IsSale { get; set; }

        public int AmountOfItemsAtSale { get; set; }

    }
}
