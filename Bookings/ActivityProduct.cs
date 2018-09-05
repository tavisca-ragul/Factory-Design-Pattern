﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookings
{
    class ActivityProduct : IProduct
    {
        public void Book()
        {
            Console.WriteLine("Booking");
        }

        public string GetTypeOfProduct()
        {
            return "Activity";
        }

        public void Save()
        {
            Console.WriteLine("Saving");
        }
    }
}
