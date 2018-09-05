using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookings
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            ProductFactory productType = new ProductFactory();
            IProduct product = productType.GetProduct(type);
            product.GetTypeOfProduct();
            product.Book();
            product.Save();
        }
    }
}