using Store.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Products
{
    internal class Check : Colleague
    {
        private static int checkCounter = 1;

        public void ClientInform(Buy buy)
        {
            //buy.UpdateProductPriceSum();
            Console.WriteLine();
            Console.WriteLine($"<--------- Check {checkCounter} ---------->");
            
            foreach (Product product in buy.ProductList)
            {
                Console.WriteLine(product);
            }
            Console.WriteLine($"Total Price: {buy.ProductPriceSum}");

            checkCounter++;
        }
      
        public override void Send(string msg)
        {
            mediator.Send(msg, this);
        }

        public override void Notify(string msg)
        {
            if (msg == "Print check, please")
            {
                Console.WriteLine("Buy successfully");
            }
        }
    }
}
