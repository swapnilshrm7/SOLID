using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorySolid
{
    class AirProduct : IProduct
    {
        public string GetTypeOfProduct()
        {
            return "air";
        }
        public void Book()
        {
            Console.WriteLine("Booking air product");
        }
        public void Save()
        {
            Console.WriteLine("Saving air Product");
        }
    }
}
