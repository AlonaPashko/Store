using Store.Interfaces;
using Store.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Services
{
    internal static class Print
    {
        public static string PrintList(List<IProduct> products)
        {
            string line = "";
            foreach (IProduct prod in products) { line += prod.ToString() + '\n'; }
            return line;
        }
    }
}
