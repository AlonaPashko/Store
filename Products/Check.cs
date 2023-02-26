using Store.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Products
{
    internal static class Check
    {
        private static int checkCounter = 1;
        
        public static void ClientInform(Buy buy)
        {
            buy.UpdateProductPriceSum();
            Console.WriteLine();
            Console.WriteLine($"<--------- Check {checkCounter} ---------->");
            
            foreach (Product product in buy.ProductList)
            {
                Console.WriteLine(product);
            }
            Console.WriteLine($"Total Price: {buy.ProductPriceSum}");

            checkCounter++;
               
        }
    }
}
