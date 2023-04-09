using Store.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Services
{
    internal static class Finder
    {
        public static IProduct FindProduct(List<IProduct> products, string name)
        {
            foreach (IProduct product in products)
            {
                product.Name = product.Name.ToLower();
                name = name.ToLower();
                if (product.Name == name)
                {
                    return product;
                }
            }
            throw new Exception("This product doesn't exists");
        }

    }
}
