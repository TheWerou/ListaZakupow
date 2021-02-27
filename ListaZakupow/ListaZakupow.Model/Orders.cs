using System;
using System.Collections.Generic;
using System.Text;

namespace ListaZakupow.Model
{
    public class Orders
    {
        public int Id { get; set; }

        public DateTime DateOfPurchase { get; set; }

        public ICollection<Address> DeliveryAddresss { get; set; }

        public ICollection<Address> InvoiceAddresss { get; set; }

        public ICollection<Delivery> DeliveryType { get; set; }

        public ICollection<Payment> PaymentType { get; set; }

        public ICollection<ProductOrder> ProductOrders { get; set; }
    }
}
