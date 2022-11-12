using Store.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Products
{
    public class CheckDecor : IViewerBuy
    {
        public void ViewerBuy(Buy buy)
        {
            Console.WriteLine("*********\n" + buy + "\n**********");
        }
    }
}
