using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorySolid
{
    class ActivityProduct : IProduct
    {
        public string GetTypeOfProduct()
        {
            return "activity";
        }
        public void Book()
        {
            Console.WriteLine("Booking activity product");
        }
        public void Save()
        {
            Console.WriteLine("Saving activity Product");
        }
    }
}
