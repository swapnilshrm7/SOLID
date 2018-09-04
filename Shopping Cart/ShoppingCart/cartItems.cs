using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ShoppingCart
{
    public class CartItem : pay
    {
        pay payment = new pay();
        public static List<Details> cartItems = new List<Details>()
        {
            new Details {id=1,name="chips",price=40,brand="lays",quantity=1},
            new Details {id=2,name="biscuits",price=80,brand="britania",quantity=2},
            new Details {id=3,name="butter",price=130,brand="amul",quantity=1}
        };
        public void COD()
        {
            payment.COD(cartItems);
        }
        public void OnlinePayment()
        {
            payment.OnlinePayment(cartItems);
        }
    }
}
