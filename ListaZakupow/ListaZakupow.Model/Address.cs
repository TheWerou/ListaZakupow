using System;
using System.Collections.Generic;
using System.Text;

namespace ListaZakupow.Model
{
    public class Address
    {
        public int Id { get; set; }

        public int PhoneNumber { get; set; }

        public string Country { get; set; }

        public string City { get; set; }

        public string PostAddress { get; set; }

        public string Street { get; set; }

        public string NumOfBuilding { get; set; }

        public string ApartmentNumber { get; set; }

    }
}
