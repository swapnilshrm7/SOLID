using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorySolid
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string desc="";
                while (desc != "exit")
                {
                    desc = Console.ReadLine();
                    string TypeOfProduct;
                    Initializer product = new Initializer();
                    IProduct prod = product.GetProduct(desc);
                    TypeOfProduct = prod.GetTypeOfProduct();
                    Console.WriteLine(TypeOfProduct);
                    prod.Save();
                    prod.Book();
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
