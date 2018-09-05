using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookings
{
    class ProductFactory
    {
        public IProduct GetProduct(string product)
        {
            switch(product)
            {
                case "Car":
                    return new CarProduct();
                case "Air":
                    return new AirProduct();
                case "Hotel":
                    return new HotelProduct();
                case "Activity":
                    return new ActivityProduct();
                default:
                    return null;
            }
        }
    }
}