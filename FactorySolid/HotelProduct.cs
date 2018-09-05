using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorySolid
{
    class HotelProduct : IProduct
    {
        public string GetTypeOfProduct()
        {
            return "hotel";
        }
        public void Book()
        {
            Console.WriteLine("Booking hotel product");
        }
        public void Save()
        {
            Console.WriteLine("Saving hotel Product");
        }
    }
}
