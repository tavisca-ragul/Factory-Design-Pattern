using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookings
{
    class AirProduct : IProduct
    {
        public void Book()
        {
            Console.WriteLine("Booking");
        }

        public string GetTypeOfProduct()
        {
            return "Air";
        }

        public void Save()
        {
            Console.WriteLine("Saving");
        }
    }
}
