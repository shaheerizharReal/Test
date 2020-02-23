using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        public static void prompt()
        {
            Console.WriteLine("====To Add New Product Press 0====");
            Console.WriteLine("====To Purchase New Items Press 1====");
            Console.WriteLine("====To Exit Press 5====");
        }
        static void Main(string[] args)
        {
            Product products = new Product();
            List<Product> listOfProducts = new List<Product>()
            {
            new Product() { prodId =1 ,prodName = "Curry Sauce", prodPrice = 1.95 },
            new Product() { prodId =2 ,prodName = "Pizza", prodPrice = 5.99 },
            new Product() { prodId =3 ,prodName = "Men T-Shirt", prodPrice = 25.00 },
            };
            Cart carts = new Cart();
            List<Cart> listOfCart = new List<Cart>()
            {
            //new Cart() { cartId =1 ,ItemsInBasket = new int[]{1,2}, totalPrice = 11.95 },
            //new Cart() { cartId =2 ,ItemsInBasket = new int[]{1,3}, totalPrice = 15.99 },
            //new Cart() { cartId =3 ,ItemsInBasket = new int[]{1}, totalPrice = 35.00 },
            };
            
 

            Console.WriteLine("_____________________________________________________________________________");
            Console.WriteLine("Welcome To Octek Test of Products App");
            Console.WriteLine("_____________________________________________________________________________");
            Console.WriteLine("Following are the products");
            Console.WriteLine("_____________________________________________________________________________");
            List<Product> prodlist = products.GetAllProducts(listOfProducts);
            Console.WriteLine("Please Wait for Cart Generation");
            Thread.Sleep(2000);
            List<Cart> cartlist = carts.GetAllCarts(listOfCart);
            prompt();
            string insert = Console.ReadLine();
            while(Int32.Parse(insert) != 5){
                if (insert == "0")
                {
                    Console.WriteLine("Enter ProductCode:");
                    string prodCode = Console.ReadLine();
                    Console.WriteLine("Enter ProductName:");
                    string prodName = Console.ReadLine();
                    Console.WriteLine("Enter ProductPrice:");
                    string prodPrice = Console.ReadLine();
                    listOfProducts.Add(new Product() { prodId = Int32.Parse(prodCode), prodName = prodName, prodPrice = Convert.ToDouble(prodPrice) });
                    Console.WriteLine("Your Products:");
                    prodlist = products.GetAllProducts(listOfProducts);
                    prompt();
                    insert = Console.ReadLine();
                }
                if (insert == "1"){
                    double price = 0;
                    double cartPrice = 0;
                    string item = "";
                    string itemString = "";
                    Console.WriteLine("These are your products");
                    prodlist = products.GetAllProducts(listOfProducts);
                    Console.WriteLine("Enter ProductCode You want to checkout/buy:");
                    string prodCode = Console.ReadLine();
                    var proditem = prodlist.Find(x => x.prodId == Int32.Parse(prodCode));
                    item = Convert.ToString(proditem.prodId);
                    itemString += item;
                    //itemString += "," + item;
                    price = Convert.ToDouble(proditem.prodPrice);
                    cartPrice += price;
                    Console.WriteLine("Want to buy more?(yes/no)");
                    string buymore = Console.ReadLine();
                    //////////////////////////////////////////////////////////////////////////////////
                    while(buymore == "yes"|| buymore == "y"){
                        Console.WriteLine("{0}", cartPrice);
                        Console.WriteLine("{0}", itemString);
                        Console.WriteLine("Enter ProductCode You want to checkout/buy:");
                        prodCode = Console.ReadLine();
                        proditem = prodlist.Find(x => x.prodId == Int32.Parse(prodCode));
                        item = Convert.ToString(proditem.prodId);
                        itemString += "," + item;
                        price = Convert.ToDouble(proditem.prodPrice);
                        cartPrice += price;
                        //if(cartPrice > 30){
                        //    cartPrice = 
                        //}
                        //listOfCart.Add(new Cart() { cartId = 1, ItemsInBasket = itemString, totalPrice = cartPrice });
                        Console.WriteLine("{0}",cartPrice);
                        //Console.WriteLine("Enter ProductName:");
                        //string prodName = Console.ReadLine();
                        //Console.WriteLine("Enter ProductPrice:");
                        //string prodPrice = Console.ReadLine();
                        //listOfProducts.Add(new Product() { prodId = Int32.Parse(prodCode), prodName = prodName, prodPrice = Convert.ToDouble(prodPrice) });
                        //Console.WriteLine("Your Products:");
                        //prodlist = products.GetAllProducts(listOfProducts);
                        //prompt();

                        Console.WriteLine("Want to buy more?");
                        buymore = Console.ReadLine();
                    }
                    if(cartPrice > 30){
                        double cartDiscount = ((double)cartPrice / 100) * 10;
                        cartPrice = cartPrice - cartDiscount;
                        listOfCart.Add(new Cart() { cartId = 1, ItemsInBasket = itemString, totalPrice = cartPrice });
                        Console.WriteLine("Cart Discount{0}",cartDiscount);
                    }
                    else
                    {
                        listOfCart.Add(new Cart() { cartId = 1, ItemsInBasket = itemString, totalPrice = cartPrice });
                    }
                   
                    ///////////////////////////////////////////////////////////////////
                    Console.WriteLine("Please Wait");
                    Thread.Sleep(2000);
                    //listOfCart.Add(new Cart() { cartId = 55, ItemsInBasket = new int[] { 55, 12 }, totalPrice = 51.95 });
                    cartlist = carts.GetAllCarts(listOfCart);
                    Console.WriteLine("Done:");
                    prompt();
                    insert = Console.ReadLine();
                    //string prodName = Console.ReadLine();
                    //Console.WriteLine("Enter ProductPrice:");
                    //string prodPrice = Console.ReadLine();
                    //listOfProducts.Add(new Product() { prodId = Int32.Parse(prodCode), prodName = prodName, prodPrice = Convert.ToDouble(prodPrice) });
                    //Console.WriteLine("Your Products:");
                    //prodlist = products.GetAllProducts(listOfProducts);
                    //Console.WriteLine("====To Add New Product Press 0====");
                    //Console.WriteLine("====To Purchase New Items Press 1====");
                    //Console.WriteLine("====To Exit Press 5====");
                }
  
            Console.WriteLine("_____________________________________________________________________________");
            }

            if (insert == "5")
            {
                Environment.Exit(0);
            }
        }
       
    }
}
