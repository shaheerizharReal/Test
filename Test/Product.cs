using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Product
    {
        public int prodId { get; set; }
        public string prodName { get; set; }
        public double prodPrice { get; set; }

        public List<Product> GetAllProducts(List<Product> prodlist)
        {
            foreach (var prod in prodlist)
            {

                Console.WriteLine("\t\tProductCode:\t{0}", prod.prodId);
                Console.WriteLine("\t\tName:\t\t{0}", prod.prodName);
                Console.WriteLine("\t\tPrice:\t\t{0}", prod.prodPrice);
                Console.WriteLine("_____________________________________________________________________________");
            }
            return prodlist;
        }
      
    }
}
