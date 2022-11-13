using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store.Products;

namespace Store.Services
{
    internal class ArrivedProducts
    {
        public List<Product> ArrivedGoods { get; set; }

        public ArrivedProducts():this(new List<Product>()) { }
        
        public ArrivedProducts(List<Product> arrivedGoods)
        {
            ArrivedGoods = arrivedGoods;
        }
        
        public List<Product> AddArrivedProduct(Product product)
        {
            ArrivedGoods.Add(product);
            return ArrivedGoods;
        }

        public string PrintArrivedGoods()
        {
            string arrivedGoods = "";
            for (int i = 0; i < ArrivedGoods.Count; i++)
            {
                arrivedGoods += ArrivedGoods[i].ToString() + "\n";
            }
            return arrivedGoods;
        }
        
        public override string ToString()
        {
            return "Arrived Goods:\n" + PrintArrivedGoods();
        }
    }
}
