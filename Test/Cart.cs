using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Cart
    {
        public int cartId;
        public string ItemsInBasket;
        public double totalPrice;
        public List<Cart> GetAllCarts(List<Cart> cartlist)
        {
            if(!cartlist.Any()){
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Your Cart is empty right now");
                Console.WriteLine("----------------------------------------");

            }
            else
            {
                Console.WriteLine("Following is your cart");
                Console.WriteLine("_____________________________________________________________________________");
                foreach (var cart in cartlist)
                {
                    //string item = "";
                    //string itemString = "";
                    //Console.WriteLine("\t\tProductCode:\t{0}", cart.cartId);
                    //for (int i = 0; i < cart.ItemsInBasket.Length; i++)
                    //{
                    //    item = Convert.ToString(cart.ItemsInBasket[i]);
                    //    if (i == 0)
                    //    {
                    //        itemString += item;
                    //    }
                    //    else
                    //    {
                    //        itemString += "," + item;
                    //    }


                    //}
                    Console.WriteLine("\t\tItems In Bucket:\t{0}", cart.ItemsInBasket);
                    Console.WriteLine("\t\tTotal Price:\t\t{0}", cart.totalPrice);
                    Console.WriteLine("_____________________________________________________________________________");
                }
            }
            
            return cartlist;
        }
        public Cart CheckOut(Cart cart)
        {
            return cart;
        }
    }
}