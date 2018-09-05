using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorySolid
{
    class CarProduct : IProduct
    {
        public string GetTypeOfProduct()
        {
            return "car";
        }
        public void Book()
        {
            Console.WriteLine("Booking car product");
        }
        public void Save()
        {
            Console.WriteLine("Saving car Product");
        }
    }
}
