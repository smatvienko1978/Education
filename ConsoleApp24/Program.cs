using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    class Program
    {
        static void Main()
        {
            InternetShopDBEntities context = new InternetShopDBEntities();
            var tableProducts = context.Products.ToList();
            foreach (var product in tableProducts)
            {
                //foreach (var item in product)
                //    Console.Write(item);
                Console.WriteLine(product.ID +"\t"+ product.Name + "\t" + product.Stock);
            }
            Console.ReadKey();
        }
    }
}
