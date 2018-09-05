using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookings
{
    class HotelProduct : IProduct
    {
        public void Book()
        {
            Console.WriteLine("Booking");
        }

        public string GetTypeOfProduct()
        {
            return "Bookings";
        }

        public void Save()
        {
            Console.WriteLine("Saving");
        }
    }
}