using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookings
{
    class CarProduct : IProduct
    {
        public void Book()
        {
            Console.WriteLine("Booking");
        }

        public string GetTypeOfProduct()
        {
            return "Car";
        }

        public void Save()
        {
            Console.WriteLine("Saving");
        }
    }
}