using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ShoppingCart
{
    class Shopping : Inventory
    {   
        public static void Main(string[] args)
        {
            cart sample = new cart();
            Console.WriteLine("enter your choice : 1:Show items in cart \n 2:Add item to cart \n 3:Remove item from cart \n 4:Display cart value \n 5: Buy Now \n \n 6:clear cart");
            int x = Convert.ToInt32(Console.ReadLine());
            if(x==1)
            {
                sample.ShowAllCartItems();
            }
            else if (x == 2)
            {
                Console.WriteLine("enter id of item to be added :");
                int choice = Convert.ToInt32(Console.ReadLine());
                var ItemToBeAdded = AllItems.Find(xy => xy.id == choice);
                if (ItemToBeAdded != null)
                    sample.AddItem(ItemToBeAdded);
            }
            else if (x == 3)
                {
                Console.WriteLine("enter id of item to be added and its quantity:");
                int choice = Convert.ToInt32(Console.ReadLine());
                int qnt = Convert.ToInt32(Console.ReadLine());
                sample.RemoveItem(choice, qnt);
                }
            else if(x==4)
                {
                int total=sample.DisplayTotal();
                }
            else if(x==5)
                {
                sample.Checkout();
                }
            else if(x==6)
            {
                sample.Clear();
            }
            }
        }
    }
