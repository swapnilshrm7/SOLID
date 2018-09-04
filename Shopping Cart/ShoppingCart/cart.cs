using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ShoppingCart
{
    public class cart : CartItem
    {
        CartItem buy = new CartItem();
        public void ShowAllCartItems()
        {
            //iterate through list and display items
        }
        public void AddItem(Details ItemToBeAdded)
        {
            cartItems.Add(ItemToBeAdded);
        }
        public void RemoveItem(int id, int quantity)
        {
            var ItemToBeRemoved = cartItems.Find(x => x.id == id);
            if (ItemToBeRemoved != null)
            {
                cartItems.Remove(ItemToBeRemoved);
                ItemToBeRemoved.quantity = ItemToBeRemoved.quantity - quantity;
                AddItem(ItemToBeRemoved);
            }
        }
        public int DisplayTotal()
        {
            //iterate through cart items and add their amounts
            return 0;
        }
        public void Checkout()
        {
           int total= DisplayTotal();
            Console.WriteLine("Pay {0} by: 1. Online Payment \n  2. COD(cash on delivery)",total);
            int choice = Convert.ToInt32(Console.ReadLine());
            if(choice==1)
            {
                buy.COD();
            }
            else if(choice==2)
            {
                buy.OnlinePayment();
            }
        }
        public void Clear()
        {
            cartItems = null;
        }
    }
}
